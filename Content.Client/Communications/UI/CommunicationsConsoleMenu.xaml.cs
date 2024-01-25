﻿using Content.Client.UserInterface.Controls;
using System.Threading;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Utility;
using Timer = Robust.Shared.Timing.Timer;

namespace Content.Client.Communications.UI
{
    [GenerateTypedNameReferences]
    public sealed partial class CommunicationsConsoleMenu : FancyWindow
    {
        private CommunicationsConsoleBoundUserInterface Owner { get; set; }
        private readonly CancellationTokenSource _timerCancelTokenSource = new();

        public CommunicationsConsoleMenu(CommunicationsConsoleBoundUserInterface owner)
        {
            IoCManager.InjectDependencies(this);
            RobustXamlLoader.Load(this);

            Owner = owner;

            var loc = IoCManager.Resolve<ILocalizationManager>();
            MessageInput.Placeholder = new Rope.Leaf(loc.GetString("comms-console-menu-announcement-placeholder"));

            AnnounceButton.OnPressed += (_) => Owner.AnnounceButtonPressed(Rope.Collapse(MessageInput.TextRope));
            AnnounceButton.Disabled = !owner.CanAnnounce;

            AlertLevelButton.OnItemSelected += args =>
            {
                var metadata = AlertLevelButton.GetItemMetadata(args.Id);
                if (metadata != null && metadata is string cast)
                {
                    Owner.AlertLevelSelected(cast);
                }
            };
            AlertLevelButton.Disabled = !owner.AlertLevelSelectable;

            EmergencyShuttleButton.OnPressed += (_) => Owner.EmergencyShuttleButtonPressed();
            EmergencyShuttleButton.Disabled = !owner.CanCall;

            UpdateCountdown();
            Timer.SpawnRepeating(1000, UpdateCountdown, _timerCancelTokenSource.Token);
        }

        // The current alert could make levels unselectable, so we need to ensure that the UI reacts properly.
        // If the current alert is unselectable, the only item in the alerts list will be
        // the current alert. Otherwise, it will be the list of alerts, with the current alert
        // selected.
        public void UpdateAlertLevels(List<string>? alerts, string currentAlert)
        {
            AlertLevelButton.Clear();

            if (alerts == null)
            {
                var name = currentAlert;
                if (Loc.TryGetString($"alert-level-{currentAlert}", out var locName))
                {
                    name = locName;
                }
                AlertLevelButton.AddItem(name);
                AlertLevelButton.SetItemMetadata(AlertLevelButton.ItemCount - 1, currentAlert);
            }
            else
            {
                foreach (var alert in alerts)
                {
                    var name = alert;
                    if (Loc.TryGetString($"alert-level-{alert}", out var locName))
                    {
                        name = locName;
                    }
                    AlertLevelButton.AddItem(name);
                    AlertLevelButton.SetItemMetadata(AlertLevelButton.ItemCount - 1, alert);
                    if (alert == currentAlert)
                    {
                        AlertLevelButton.Select(AlertLevelButton.ItemCount - 1);
                    }
                }
            }
        }

        public void UpdateCountdown()
        {
            if (!Owner.CountdownStarted)
            {
                CountdownLabel.SetMessage("");
                EmergencyShuttleButton.Text = Loc.GetString("comms-console-menu-call-shuttle");
                return;
            }

            EmergencyShuttleButton.Text = Loc.GetString("comms-console-menu-recall-shuttle");
            CountdownLabel.SetMessage($"Time remaining\n{Owner.Countdown.ToString()}s");
        }

        public override void Close()
        {
            base.Close();

            _timerCancelTokenSource.Cancel();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
                _timerCancelTokenSource.Cancel();
        }
    }
}