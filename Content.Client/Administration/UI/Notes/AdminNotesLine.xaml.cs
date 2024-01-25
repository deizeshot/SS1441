using System.Text;
using Content.Shared.Administration.Notes;
using Content.Shared.Database;
using Robust.Client.AutoGenerated;
using Robust.Client.GameObjects;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Input;
using Robust.Shared.Utility;

namespace Content.Client.Administration.UI.Notes;

[GenerateTypedNameReferences]
public sealed partial class AdminNotesLine : BoxContainer
{
    private readonly SpriteSystem _sprites;

    private const string AdminNotesTextureBase = "/Textures/Interface/AdminNotes/";
    private static readonly Dictionary<NoteSeverity, string> SeverityIcons = new()
    {
        { NoteSeverity.None, AdminNotesTextureBase + "none_button.png" },
        { NoteSeverity.Minor, AdminNotesTextureBase + "minor_button.png" },
        { NoteSeverity.Medium, AdminNotesTextureBase + "medium_button.png" },
        { NoteSeverity.High, AdminNotesTextureBase + "high_button.png" },
    };
    private static readonly Dictionary<NoteType, string> NoteTypeIcons = new()
    {
        { NoteType.Message, AdminNotesTextureBase + "message.png" },
        { NoteType.Watchlist, AdminNotesTextureBase + "watchlist.png" },
    };

    public AdminNotesLine(SpriteSystem sprites, SharedAdminNote note)
    {
        RobustXamlLoader.Load(this);
        _sprites = sprites;

        Note = note;
        MouseFilter = MouseFilterMode.Pass;

        Separator.Visible = true;
        Refresh();
    }

    public SharedAdminNote Note { get; private set; }
    public int Id => Note.Id;

    public event Func<AdminNotesLine, bool>? OnClicked;

    /// <summary>
    /// Attempts to refresh the current note line with new data. The note it draws data on is stored in <see cref="Note"/>
    /// </summary>
    private void Refresh()
    {
        string? iconPath;
        if (Note.NoteSeverity is not null && !NoteTypeIcons.ContainsKey(Note.NoteType))
            SeverityIcons.TryGetValue(Note.NoteSeverity.Value, out iconPath);
        else
            NoteTypeIcons.TryGetValue(Note.NoteType, out iconPath);

        if (iconPath is null)
        {
            SeverityRect.Visible = false;
            Logger.WarningS("admin.notes", $"Could not find an icon for note ID {Note.Id}");
        }
        else
        {
            SeverityRect.Texture = _sprites.Frame0(new SpriteSpecifier.Texture(new ResPath(iconPath)));
        }

        TimeLabel.Text = Note.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss");
        ServerLabel.Text = Note.ServerName ?? "Unknown";
        RoundLabel.Text = Note.Round == null ? "Unknown round" : "Round " + Note.Round;
        AdminLabel.Text = Note.CreatedByName;
        PlaytimeLabel.Text = $"{Note.PlaytimeAtNote.TotalHours: 0.0}h";

        if (Note.Secret)
        {
            SecretSeparator.Visible = true;
            SecretLabel.Visible = true;
        }

        if (Note.UnbannedTime is not null)
        {
            ExtraLabel.Text = Loc.GetString("admin-notes-unbanned", ("admin", Note.UnbannedByName ?? "[error]"), ("date", Note.UnbannedTime));
            ExtraLabel.Visible = true;
        }
        else if (Note.ExpiryTime is not null)
        {
            // Notes should never be visible when expired, bans should
            if (Note.ExpiryTime.Value > DateTime.UtcNow)
            {
                ExpiresLabel.Text = Loc.GetString("admin-note-editor-expiry-label-params",
                    ("date", Note.ExpiryTime.Value.ToString("yyyy-MM-dd HH:mm:ss")),
                    ("expiresIn", (Note.ExpiryTime.Value - DateTime.UtcNow).ToString("d'd 'hh':'mm")));
                ExpiresLabel.Modulate = Color.FromHex("#86DC3D");
            }
            else
            {
                ExpiresLabel.Text = Loc.GetString("admin-note-editor-expiry-label-expired");
            }
            ExpiresLabel.Visible = true;
        }

        if (Note.LastEditedAt > Note.CreatedAt)
        {
            EditedLabel.Text = Loc.GetString("admin-notes-edited", ("author", Note.EditedByName), ("date", Note.LastEditedAt));
            EditedLabel.Visible = true;
        }

        switch (Note.NoteType)
        {
            case NoteType.ServerBan:
                NoteLabel.SetMessage(FormatBanMessage());
                break;
            case NoteType.RoleBan:
                NoteLabel.SetMessage(FormatRoleBanMessage());
                break;
            case NoteType.Note:
            case NoteType.Watchlist:
            case NoteType.Message:
            default:
                NoteLabel.SetMessage(Note.Message);
                break;
        }

        if (Note.Seen == true)
        {
            ExtraLabel.Text = Loc.GetString("admin-notes-message-seen");
            ExtraLabel.Visible = true;
        }
    }

    private string FormatBanMessage()
    {
        var banMessage = new StringBuilder($"{Loc.GetString("admin-notes-banned-from")} {Loc.GetString("admin-notes-the-server")} ");
        return FormatBanMessageCommon(banMessage);
    }

    private string FormatRoleBanMessage()
    {
        var banMessage = new StringBuilder($"{Loc.GetString("admin-notes-banned-from")} {string.Join(", ", Note.BannedRoles ?? new []{"unknown"})} ");
        return FormatBanMessageCommon(banMessage);
    }

    private string FormatBanMessageCommon(StringBuilder sb)
    {
        if (Note.ExpiryTime is null)
        {
            sb.Append(Loc.GetString("admin-notes-permanently"));
        }
        else
        {
            sb.Append("for ");
            var banLength = Note.ExpiryTime.Value - Note.CreatedAt;
            if (banLength.Days > 0)
                sb.Append(Loc.GetString("admin-notes-days", ("days", banLength.TotalDays.ToString(".00"))));
            else if (banLength.Hours > 0)
                sb.Append(Loc.GetString("admin-notes-hours", ("hours", banLength.TotalHours.ToString(".00"))));
            else
                sb.Append(Loc.GetString("admin-notes-minutes", ("minutes", banLength.TotalMinutes.ToString(".00"))));
        }

        sb.Append(" - ");
        sb.Append(Note.Message);
        return sb.ToString();
    }

    protected override void KeyBindDown(GUIBoundKeyEventArgs args)
    {
        base.KeyBindDown(args);

        if (args.Function != EngineKeyFunctions.UIRightClick &&
            args.Function != EngineKeyFunctions.UIClick)
        {
            return;
        }

        if (OnClicked?.Invoke(this) == true)
        {
            args.Handle();
        }
    }

    public void UpdateNote(SharedAdminNote note)
    {
        Note = note;
        Refresh();
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (!disposing)
        {
            return;
        }

        OnClicked = null;
    }
}