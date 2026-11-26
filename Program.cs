using System;

namespace OOPFinal {
    internal class Program {
        private static Random _rng = new Random();
        public static void Main(string[] args) {
            Msg("Okay coach, let's get started.");
            Msg("24 seconds left, 26-24, ball is on the 26-yard line. 1 timeout remaining.");
            Msg("What's your call, coach?");


            // The user prompts 1, 2, or 3 for their choice.
        }

        public static void Msg(string message) {
            Console.WriteLine(message);
        }
    }
}