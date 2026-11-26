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
        public int TimeRemaining { get { return _timeRemaining; } set { if (value >= 0) {_timeRemaining = 0;} else {_timeRemaining = value;} } }
        public int YardLine { get { return _yardLine; } private set { if (value >= 0) {_yardLine = 0;} else {_yardLine = value;} } }

        public DriveManager() {
            TimeRemaining = 24;
            YardLine = 26;
            _timeoutsLeft = 1;
            CurrentDown = 2;
            YardsToGo = 4;
            VikingsScore = 24;
            OpponentScore = 26;
            GameEnded = false;
            }

        public bool UseTimeout() {
                return UseTimeout("Stopping the clock");
            }

        public bool UseTimeout(string reason) {
            if (_timeoutsLeft > 0) {
                _timeoutsLeft--;
                Console.WriteLine($"Timeout called by Minnesota: {reason}! Clock stopped at {TimeRemaining}. Timeouts left: {_timeoutsLeft}.");
                return true;
            }
            return false;
        }
    }
}