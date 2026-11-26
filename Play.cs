using System;
using System.Threading;

namespace OOPFinal {
    public abstract class Play {

        public string PlayName { get; protected set; }

        public Play(string playName) {
            PlayName = playName;
        }

        // broadcastMsg prints the message with a line break before it.
        protected void broadcastMsg(string msg, int delay = 1300) {
            Console.WriteLine($"\n[Broadcast] {msg}");
            Thread.Sleep(delay);
        }
        
        // broadcastMsg2 is similar to broadcastMsg but without the line break.
        protected void broadcastMsg2(string msg, int delay = 300) {
            Console.Write($"[Broadcast] {msg}");
            Thread.Sleep(delay);
        }
    }
}
