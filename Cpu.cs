using System;

namespace Shotgun
{
    class Cpu
    {
        public static string CpuName()
        {
            //Random random = new Random(); - funktion för random namn?
            string cpuName = "Donuthelloh";
            return cpuName;
        }

        // Välj scenario baserat på ammo
        public int MoveCalculator(int cpuAmmo, int playerAmmo)
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
        public int[] CalculateWeight(int move)
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
        public string CpuMove(int[] weights)
        {
            string[] cpuMove = new string[] { "SKJUTA", "LADDA", "BLOCKA", "SHOTGUN" };
            int chosenMove = 0;
            return cpuMove[chosenMove];
        }
    }
}