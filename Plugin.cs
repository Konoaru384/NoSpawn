using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using Exiled.Events.EventArgs.Server;
using Respawning;
using System;
using ServerEvent = Exiled.Events.Handlers.Server;

namespace NoSpawn
{
    public class NoSpawnPlugin : Plugin<Config>
    {
        public override string Name => "NoSpawn";
        public override string Author => "Konoara";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            if (Config.IsEnabled)
                ServerEvent.RespawningTeam += OnRespawningTeam;
        }

        public override void OnDisabled()
        {
            ServerEvent.RespawningTeam -= OnRespawningTeam;
        }

        private void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            var delay = new TimeSpan(
                Config.DelayHours,
                Config.DelayMinutes,
                Config.DelaySeconds
            );

            var faction = ev.Wave.SpawnableFaction;

            if (Round.ElapsedTime < delay &&
               (faction == SpawnableFaction.NtfWave ||
                faction == SpawnableFaction.NtfMiniWave ||
                faction == SpawnableFaction.ChaosWave ||
                faction == SpawnableFaction.ChaosMiniWave))
            {
                ev.IsAllowed = false;
                if (Config.Debug)
                    Log.Info($"[NoSpawn] Bloqué {faction} à {Round.ElapsedTime}");
            }
        }
    }
}
