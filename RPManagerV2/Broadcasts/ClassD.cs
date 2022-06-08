using Exiled.Events.EventArgs;

namespace RPManagerV2.Broadcasts
{
    public class ClassD
    {
        public void onSpawningClassD(SpawningEventArgs ev)
        {
            if (ev.Player.Role == RoleType.ClassD)
            {
                string[] array = RPManager.Singleton.Config.ClassDBroadcast.ToArray();

                int num = UnityEngine.Random.Range(0, array.Length);
                ev.Player.Broadcast(5, array[num]);
            }
        }
    }
}