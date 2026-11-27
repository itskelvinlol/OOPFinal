using System;

namespace OOPFinal {
    public class PassPlay : Play {
        public PassPlay() : base("Boundary / End Zone Pass") {
        }
        private static Random _rng = new Random();
        // ExecutePlay 
        public override PlayResult ExecutePlay(string defensiveCoverage) {

        // Generic broadcast messages before the RNG
            broadcastMsg("Five seconds left on the play clock.");
            broadcastMsg("And he takes the snap.", 2200); // Dramatic pause before the play unfolds

            int roll = _rng.Next(1, 101);

        // RNG
        // 1. Defense runs blitz. Gets sacked.
            if (defensiveCoverage == "All-Out Blitz") {
                if (roll <= 20) {
                    broadcastMsg("BLITZ COMING FREE OFF THE EDGE!");
                    broadcastMsg("SACK! The quarterback is down! Brought down for a loss of yards.");
                    return new PlayResult(-8, 5, false, "Quarterback sacked with the blitz in-bounds."); //Currently 8 yards loss instead of randomized 8-12 yards. Todo later?
                }

        // 2. Blitz, QB throws under pressure. Gets picked off.
                else if (roll <= 30) {
                    broadcastMsg("HE THROWS UNDER DURESS!");
                    broadcastMsg("PICKED OFF! The defense intercepts the pass.");
                    PlayResult pickResult = new PlayResult(0, 5, true, "Interception by the defense.");
                    pickResult.Turnover = true;
                    return pickResult;
                }

        // 3. Successful pass into the end zone.
                else if (roll <= 85) {
                    broadcastMsg("In the pocket.");
                    broadcastMsg("And he throws");
                    broadcastMsg2(".");
                    broadcastMsg2(".");
                    broadcastMsg2(".");
                    broadcastMsg("JUSTIN JEFFERSON CATCHES THE PASS IN THE END ZONE! TOUCHDOWN!");
                    PlayResult tdResult = new PlayResult(30, 5, true, "Touchdown by the offense.");
                    tdResult.TouchdownScored = true;
                    return tdResult;
                }
    
        // 4. Standard pass with moderate yardage gain.
                else {
                    int yards = _rng.Next(14, 22);
                    broadcastMsg("He beats the blitz with a laser to the sideline!");
                    broadcastMsg($"Caught! Gains {yards} yards and runs out of bounds to stop the clock.");
                    return new PlayResult(yards, 5, true, $"Completed pass for {yards} yards. Receiver runs out of bounds to stop the clock.");
                }
            } else {
        // 5. Incomplete pass.        
                
            }
        
        }
    }
}