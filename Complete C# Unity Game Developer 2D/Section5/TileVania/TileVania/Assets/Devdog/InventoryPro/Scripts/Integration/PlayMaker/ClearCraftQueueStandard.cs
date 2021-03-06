#if PLAYMAKER

using Devdog.General;
using HutongGames.PlayMaker;

namespace Devdog.InventoryPro.Integration.PlayMaker
{
    [ActionCategory("Inventory Pro")]
    [HutongGames.PlayMaker.Tooltip("Clear crafting queue. This removes all the active crafting blueprints.")]
    public class ClearCraftQueueStandard : FsmStateAction
    {
        public CraftingStandardTrigger trigger;

        public override void Reset()
        {

        }

        public override void OnEnter()
        {
            trigger.progressContainer.CancelActiveCraftAndClearQueue();
            Finish();
        }
    }
}

#endif