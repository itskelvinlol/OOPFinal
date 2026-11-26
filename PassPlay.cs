using System;
using System.Threading;

namespace Play {
    public class PassPlay : Play {
        public PassPlay() : base("Boundary / End Zone Pass") {
        }

        public override PlayResult ExecutePlay(string defensiveCoverage) {
            broadcastMsg("Five seconds left on the play clock.");
            broadcastMsg("And he takes the snap.");
        }
    }
}