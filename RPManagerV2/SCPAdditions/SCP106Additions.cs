using Exiled.Events.EventArgs;

namespace RPManagerV2.SCPAdditions
{
    internal class SCP106Additions
    {
        public void onEnteringPocket(EnteringPocketDimensionEventArgs ev)
        {
            if (!RPManager.Singleton.Config.EnteringPocketMessageEnabled) { return; }

            ev.Player.EnableEffect(Exiled.API.Enums.EffectType.Corroding, 10, false);
            ev.Player.Broadcast(5, RPManager.Singleton.Config.Entering106PocketBroadcast, Broadcast.BroadcastFlags.Normal, false);
        }

        public void onEscapingPocket(EscapingPocketDimensionEventArgs ev)
        {
            if (!RPManager.Singleton.Config.EscapingPocketMessageEnabled) { return; }

            ev.Player.EnableEffect(Exiled.API.Enums.EffectType.Disabled, 5, false);
            ev.Player.Broadcast(5, RPManager.Singleton.Config.Escaping106PocketBroadcast, Broadcast.BroadcastFlags.Normal, false);
        }
    }
}