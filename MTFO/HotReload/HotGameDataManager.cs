﻿using System;
using GameData;
using MTFO.Utilities;

namespace MTFO.HotReload
{
    class HotGameDataManager : IHotManager
    {
        public void OnHotReload(int id)
        {
            GameDataInit.ReInitialize(); // refresh game data
            Log.Verbose("Reinitialized GameData");
        }
    }
}
