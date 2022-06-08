using Exiled.Events.EventArgs;

namespace RPManagerV2.Features
{
    internal class NoDecon
    {
        public void onDecon(DecontaminatingEventArgs ev)
        {
            if (!RPManager.Singleton.Config.NoDeconEnabled) { return; }

            ev.IsAllowed = false;
        }
    }
}