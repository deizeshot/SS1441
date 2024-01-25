using System;
using Robust.Client.AutoGenerated;
using Robust.Client.Replays.Playback;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared;
using Robust.Shared.Configuration;
using Robust.Shared.Input;
using Robust.Shared.IoC;
using Robust.Shared.Localization;
using Robust.Shared.Timing;

namespace Robust.Client.Replays.UI;

/// <summary>
/// This is a simple replay demonstration widget that has basic controls for manipulating a replay.
/// </summary>
[GenerateTypedNameReferences]
public sealed partial class ReplayControlWidget : UIWidget // AKA Tardis - The funny time control box.
{
    [Dependency] private readonly IReplayPlaybackManager _playback = default!;
    [Dependency] private readonly IConfigurationManager _cfg = default!;

    public const string TimeFormat = @"hh\:mm\:ss";

    /// <summary>
    /// Number of ticks to jump by when using the forward/backward buttons.
    /// </summary>
    public int SmallJump = 1;

    /// <summary>
    /// Number of ticks to jump by when using the fast forward/backward buttons.
    /// </summary>
    public int BigJump = 10;

    public ReplayControlWidget()
    {
        RobustXamlLoader.Load(this);

        PlayButton.OnToggled += _ => _playback.Playing = !_playback.Playing;
        ResetButton.OnPressed += _ => _playback.SetIndex(0);
        SkipForwardButton.OnPressed += _ => _playback.SetIndex(SmallJump + (_playback.Replay?.CurrentIndex ?? 0));
        SkipBackButton.OnPressed += _ => _playback.SetIndex(-SmallJump + (_playback.Replay?.CurrentIndex ?? 0));
        SkipForwardManyButton.OnPressed += _ => _playback.SetIndex(BigJump + (_playback.Replay?.CurrentIndex ?? 0));
        SkipBackwardManyButton.OnPressed += _ => _playback.SetIndex(-BigJump + (_playback.Replay?.CurrentIndex ?? 0));
        StopButton.OnPressed += _ => _playback.StopReplay();
        DynamicScrubbingCheckbox.Pressed = _cfg.GetCVar(CVars.ReplayDynamicalScrubbing);
        DynamicScrubbingCheckbox.OnToggled += args => _cfg.SetCVar(CVars.ReplayDynamicalScrubbing, args.Pressed);

        TickSlider.OnKeyBindUp += args =>
        {
            if (args.Function != EngineKeyFunctions.Use)
                return;

            _playback.ScrubbingTarget = null;
            var time = TimeSpan.FromSeconds(TickSlider.Value);
            _playback.SetTime(time);
        };
    }

    protected override void FrameUpdate(FrameEventArgs args)
    {
        base.FrameUpdate(args);
        if (_playback.Replay is not { } replay)
        {
            return;
        }

        TickSlider.MinValue = 0;
        TickSlider.MaxValue = (float)replay.ReplayTime[^1].TotalSeconds;

        _playback.ScrubbingTarget = null;
        var index = replay.CurrentIndex;
        if (!TickSlider.Grabbed)
        {
            TickSlider.SetValueWithoutEvent((float)replay.CurrentReplayTime.TotalSeconds);
        }
        else
        {
            var time = TimeSpan.FromSeconds(TickSlider.Value);
            index = Array.BinarySearch(replay.ReplayTime, time);
            if (index < 0)
                index = Math.Max(0, ~index - 1);

            if (_cfg.GetCVar(CVars.ReplayDynamicalScrubbing))
                _playback.ScrubbingTarget = index;
        }

        var percentage = (100 * TickSlider.GetAsRatio()).ToString("F2");
        var maxIndex = Math.Max(1, replay.States.Count - 1);
        var state = replay.States[index];
        var replayTime = TimeSpan.FromSeconds(TickSlider.Value);

        IndexLabel.Text = Loc.GetString("replay-time-box-index-label",
            ("current", index), ("total", maxIndex), ("percentage", percentage));

        TickLabel.Text = Loc.GetString("replay-time-box-tick-label",
            ("current", state.ToSequence), ("total", replay.States[^1].ToSequence), ("percentage", percentage));

        TimeLabel.Text = Loc.GetString("replay-time-box-replay-time-label",
            ("current", replayTime.ToString(TimeFormat)), ("end", replay.Duration.ToString(TimeFormat)), ("percentage", percentage));

        var serverTime = (replayTime + replay.StartTime).ToString(TimeFormat);
        var duration = (replay.Duration + replay.StartTime).ToString(TimeFormat);
        ServerTimeLabel.Text = Loc.GetString("replay-time-box-server-time-label",
            ("current", serverTime), ("end", duration), ("percentage", percentage));

        PlayButton.Pressed = _playback.Playing;
    }
}
