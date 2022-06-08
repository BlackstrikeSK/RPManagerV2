using Exiled.API.Enums;
using Exiled.API.Features;
using RPManagerV2.Broadcasts;
using RPManagerV2.Features;
using RPManagerV2.SCPAdditions;
using System;
using Map = Exiled.Events.Handlers.Map;
using Player = Exiled.Events.Handlers.Player;

namespace RPManagerV2
{
    public class RPManager : Plugin<Config>
    {
        public override string Author => "BlackStrike SK";

        public override string Name => "RpManager";

        public override string Prefix => "RpManager";

        public override Version Version => new Version(1, 0, 0);

        public override Version RequiredExiledVersion => new Version(5, 2, 1);

        public override PluginPriority Priority => PluginPriority.Default;

        public static RPManager Singleton;

        internal ClassD ClassD { get; set; }
        internal Scientist Scientist { get; set; }
        internal FacilityGuard FacilityGuard { get; set; }
        internal SCP SCP { get; set; }
        internal SCP106Additions SCP106Additions { get; set; }
        internal NoDecon NoDecon { get; set; }

        public override void OnEnabled()
        {
            Singleton = this;
            ClassD = new ClassD();
            Scientist = new Scientist();
            FacilityGuard = new FacilityGuard();
            SCP = new SCP();
            NoDecon = new NoDecon();
            SCP106Additions = new SCP106Additions();

            Player.Spawning += ClassD.onSpawningClassD;
            Player.Spawning += Scientist.onSpawningScientist;
            Player.Spawning += FacilityGuard.onSpawningFG;
            Player.Spawning += SCP.onSpawningSCP;

            Player.EnteringPocketDimension += SCP106Additions.onEnteringPocket;
            Player.EscapingPocketDimension += SCP106Additions.onEscapingPocket;

            Map.Decontaminating += NoDecon.onDecon;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.Spawning -= ClassD.onSpawningClassD;
            Player.Spawning -= Scientist.onSpawningScientist;
            Player.Spawning -= FacilityGuard.onSpawningFG;
            Player.Spawning -= SCP.onSpawningSCP;

            Player.EnteringPocketDimension -= SCP106Additions.onEnteringPocket;
            Player.EscapingPocketDimension -= SCP106Additions.onEscapingPocket;

            Map.Decontaminating -= NoDecon.onDecon;

            Singleton = null;
            ClassD = null;
            Scientist = null;
            FacilityGuard = null;
            SCP = null;
            NoDecon = null;
            SCP106Additions = null;
            base.OnDisabled();
        }
    }
}