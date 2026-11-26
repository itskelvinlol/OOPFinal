using System;

namespace OOPFinal {
    public class DriveManager {
        private int _timeRemaining;
        private int _yardLine;
        private int _timeoutsLeft;
        public int CurrentDown { get; private set; }
        public int YardsToGo { get; private set; }
        public int VikingsScore { get; set; }
        public int OpponentScore { get; set; }
        public bool GameEnded { get; set; }
    }
}