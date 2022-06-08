using Exiled.Events.EventArgs;

namespace RPManagerV2.Broadcasts
{
    public class FacilityGuard
    {
        public void onSpawningFG(SpawningEventArgs ev)
        {
            if (ev.Player.Role == RoleType.FacilityGuard)
            {
                string[] array = RPManager.Singleton.Config.FacilityGuardBroadcast.ToArray();

                int num = UnityEngine.Random.Range(0, array.Length);
                ev.Player.Broadcast(5, array[num]);
            }
        }
    }
}