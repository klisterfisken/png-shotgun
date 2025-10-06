using System;

namespace Shotgun
{
    class Cpu
    {
        public static string CpuName()
        {
            Random random = new Random();
            int botNumber = random.Next(1, 5);
            string cpuName = "";
            if (botNumber == 1) cpuName = "SPRAK";
            else if (botNumber == 2) cpuName = "MARVIN";
            else if (botNumber == 3) cpuName = "HAL";
            else cpuName = "MATHILDA JUNKBOTTOM";
            return cpuName;
        }

        // Välj scenario baserat på ammo
        public static int MoveCalculator(int cpuAmmo, int playerAmmo)
        {
            int move = 0;
            if (cpuAmmo == 0)
            {
                if (playerAmmo == 0) move = 1;
                else if (playerAmmo == 1 || playerAmmo == 2) move = 2;
                else move = 3;
            }
            else if (cpuAmmo == 1)
            {
                if (playerAmmo == 0) move = 4;
                else move = 5;
            }
            else if (cpuAmmo == 2)
            {
                if (playerAmmo == 0) move = 6;
                else move = 7;
            }
            else move = 8;
            return move;
        }

        // Ange beslutens vikt baserat på scenario 
        public static int[] CalculateWeight(int move)
        {
            // Array med vikter för dragen skjuta, ladda, blocka, shotgun
            // Otillåten = 0, Dum = 25, Neutral = 100, Smart = 250
            int[] weights = new int[] { 0, 0, 0, 0 };
            if (move == 1) weights = new int[] { 0, 250, 25, 0 };
            if (move == 2) weights = new int[] { 0, 100, 100, 0 };
            if (move == 3) weights = new int[] { 0, 250, 100, 0 };
            if (move == 4) weights = new int[] { 100, 100, 25, 0 };
            if (move == 5) weights = new int[] { 100, 100, 100, 0 };
            if (move == 6) weights = new int[] { 100, 250, 25, 0 };
            if (move == 7) weights = new int[] { 100, 250, 100, 0 };
            if (move == 8) weights = new int[] { 25, 25, 25, 250 };
            return weights;
        }

        // Slumpa fram ett drag baserat på vikt
        public static string CpuMoveChoice(int[] weights)
        {
            string[] cpuMove = new string[] { "SKJUTA", "LADDA", "BLOCKA", "SHOTGUN" };
            int chosenMove = 0;
            Random random = new Random();
            int totalWeight = 0;
            foreach (int weight in weights) totalWeight += weight;
            int randomChoice = random.Next(1, totalWeight + 1);
            int choiceWeight = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                choiceWeight += weights[i];
                if (randomChoice <= choiceWeight)
                {
                    chosenMove = i;
                    break;
                }
            }
            return cpuMove[chosenMove];
        }

        // Använd metoderna för att göra ett drag
        public static string CpuMove(int cpuAmmo, int playerAmmo)
        {
            return CpuMoveChoice(CalculateWeight(MoveCalculator(cpuAmmo, playerAmmo)));
        }
    }
}