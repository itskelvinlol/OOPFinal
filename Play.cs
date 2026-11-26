namespace Play {
    public abstract class Play {

        public string PlayName { get; protected set; }

        public Play(string playName) {
            PlayName = playName;
        }

        protected void broadcastMsg(string msg, int delay = 1300) {
            Console.WriteLine($"\n {msg}");
            Thread.Sleep(delay);
        }
    }
}
