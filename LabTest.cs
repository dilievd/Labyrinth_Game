﻿using System;

namespace Labyrinth
{
	// smilih se nad vas kolegi, ne sym puskal obfuskatora, shtoto se zamislih, che i vie moze da imate
    class LabTest
    {
        static void Main()
        {
            Scoreboard ladder = new Scoreboard();
          
            while (true)
            {
                Game game = new Game(ladder);
            }
        }
    }
}
