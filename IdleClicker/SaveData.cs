using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleClicker
{
    public class SaveData
    {
        // Settings
        public int BackgroundIndex { get; set; } = 0;
        public int MusicVolume { get; set; } = 50;
        public int SfxVolume { get; set; } = 50;

        // Progress
        public double Currency { get; set; } = 0;
        public double IdleGen { get; set; } = 1;
        public int ClickPower { get; set; } = 1;
        public int[] UpgradeLevels { get; set; } = new int[4];

        public int[] UpgradePrice { get; set; } = {10, 100, 1000, 10000};
    }
}
