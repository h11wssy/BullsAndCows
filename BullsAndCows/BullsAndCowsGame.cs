﻿using System;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly SecretGenerator secretGenerator;
        private readonly string secret;
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            secret = secretGenerator.GenerateSecret();
        }

        public bool CanContinue => true;

        public string Guess(string guess)
        {
            int bulls = 0;
            int cows = 0;
            for (int i = 0; i < secret.Length; i++)
            {
                if (guess[i] == secret[i])
                {
                    bulls++;
                }
                else if (guess.IndexOf(secret[i]) >= 0)
                {
                    cows++;
                }
            }

            return $"{bulls}A{cows}B";
        }
    }
}