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

        public string CpuMove(int move)
        {
            string cpuMove = "";
            return cpuMove;
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
        public double[] CalculateWeight(int move)
        {
            // Array med vikter för dragen skjuta, ladda, blocka, shotgun
            double[] weights = new double[] { 0.0, 0.0, 0.0, 0.0 };
            if (move == 1) weights = new double[] { 0.0, 2.5, 0.25, 0.0 };
            if (move == 2) weights = new double[] { 0.0, 1.0, 1.0, 0.0 };
            if (move == 3) weights = new double[] { 0.0, 2.5, 1.0, 0.0 };
            if (move == 4) weights = new double[] { 1.0, 1.0, 0.25, 0.0 };
            if (move == 5) weights = new double[] { 1.0, 1.0, 1.0, 0.0 };
            if (move == 6) weights = new double[] { 1.0, 2.5, 0.25, 0.0 };
            if (move == 7) weights = new double[] { 1.0, 2.5, 1.00, 0.0 };
            if (move == 8) weights = new double[] { 0.25, 0.25, 0.25, 2.5 };
            return weights;
        }
    }
}