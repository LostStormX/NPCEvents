using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace Oxide.Plugins
{
    [Info("NPC Events", "DepressingDressing & LostStormX", "1.0.0")]
    [Description("Creates and controls different NPC Events such as Bradley Crashes, ect.")]

    class NPC_Events : RustPlugin
    {
        private float respawnDelay = 3600f;
        private void SpawningBradleyAtLocation(Vector3 position)
        {
            BaseEntity bradley = GameManager.server.CreateEntity("assets/prefabs/npc/military/barricade/barricade.prefab", position, Quaternion.identity);

            if (bradley != null)
            {
                bradley.Spawn();
            }
        }
    }
}
