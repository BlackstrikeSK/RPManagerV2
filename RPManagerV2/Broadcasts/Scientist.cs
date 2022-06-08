using Exiled.Events.EventArgs;

namespace RPManagerV2.Broadcasts
{
    public class Scientist
    {
        public void onSpawningScientist(SpawningEventArgs ev)
        {
            if (ev.Player.Role == RoleType.Scientist)
            {
                string[] array = RPManager.Singleton.Config.SciBroadcast.ToArray();

                int num = UnityEngine.Random.Range(0, array.Length);
                ev.Player.Broadcast(5, array[num]);
            }
        }
    }
}