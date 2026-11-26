namespace Play {
    public abstract class Play {

        public string PlayName { get; protected set; }

        public Play(string playName) {
            PlayName = playName;
        }
    }
}
