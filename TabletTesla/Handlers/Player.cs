using Exiled.Events.EventArgs;
using System.Linq;
namespace TabletTesla.Handlers
{
    class Player
    {
        public void OnTeslaGate(TriggeringTeslaEventArgs ev)
        {
            if (ev.Player.Inventory.items.Any(item => item.id == ItemType.WeaponManagerTablet))
            {
                ev.IsTriggerable = false;
            }
        }
    }
}
