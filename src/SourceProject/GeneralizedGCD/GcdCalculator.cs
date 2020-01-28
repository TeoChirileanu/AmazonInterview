using System;

namespace SourceProject.GeneralizedGCD
{
    public class GcdCalculator : IGcdCalculator
    {
        public int CalculateGcd(int[] arr)
        {
            if (arr.Length <= 0) return 0;
            if (arr.Length <= 1) return Math.Abs(arr[0]);

            var localGcd = CalculateGcd(arr[0], arr[1]);
            return Math.Abs(localGcd);
        }

        private static int CalculateGcd(int a, int b)
        {
            return b == 0 ? a : CalculateGcd(b, a % b);
        }
    }
}