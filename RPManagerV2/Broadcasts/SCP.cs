using Exiled.Events.EventArgs;

namespace RPManagerV2.Broadcasts
{
    internal class SCP
    {
        public void onSpawningSCP(SpawningEventArgs ev)
        {
            if (ev.Player.Role == RoleType.Scp049)
            {
                ev.Player.Broadcast(5, RPManager.Singleton.Config.SCP049);
            }

            if (ev.Player.Role == RoleType.Scp079)
            {
                ev.Player.Broadcast(5, RPManager.Singleton.Config.SCP079);
            }

            if (ev.Player.Role == RoleType.Scp096)
            {
                ev.Player.Broadcast(5, RPManager.Singleton.Config.SCP096);
            }

            if (ev.Player.Role == RoleType.Scp106)
            {
                ev.Player.Broadcast(5, RPManager.Singleton.Config.SCP106);
            }

            if (ev.Player.Role == RoleType.Scp173)
            {
                ev.Player.Broadcast(5, RPManager.Singleton.Config.SCP173);
            }
        }
    }
}