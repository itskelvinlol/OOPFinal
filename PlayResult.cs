namespace OOPFinal {
    public class PlayResult {
        

        public int YardsGained { get; set; }
        public int SecondsUsed { get; set; }
        public bool ClockStopped { get; set; }
        public bool TouchdownScored { get; set; }
        public bool FieldGoalGood { get; set; }
        public bool Turnover { get; set; }
        public string Description { get; set; }

        public PlayResult(int yards, int seconds, bool clockStopped, string description) {
            YardsGained = yards;
            SecondsUsed = seconds;
            ClockStopped = clockStopped;
            TouchdownScored = false;
            FieldGoalGood = false;
            Turnover = false;
            Description = description;
        }
    }
}