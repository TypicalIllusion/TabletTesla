using System;

using Exiled.API.Features;
using Exiled.API.Enums;

using PPlayer = Exiled.Events.Handlers.Player;

namespace TabletTesla
{
    public class TabletTesla : Plugin<Config>
    {
        private Handlers.Player player = new Handlers.Player();
        public override string Name { get; } = "TabletTesla";
        public override string Author { get; } = "TypicalIllusion";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 1, 19);
        public override string Prefix { get; } = "TabletTesla";

        public override PluginPriority Priority { get; } = PluginPriority.Low;

        public void RegisterEvents()
        {
            PPlayer.TriggeringTesla += player.OnTeslaGate;
        }
        public void UnregisterEvents()
        {
            PPlayer.TriggeringTesla -= player.OnTeslaGate;
            player = null;
        }

        public override void OnEnabled()
        {
            base.OnEnabled();
            RegisterEvents();
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
            UnregisterEvents();
        }
    }
}
