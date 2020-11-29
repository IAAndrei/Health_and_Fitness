using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_and_Fitness
{
    class Mixrr
    {
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        public static double BMICalc(string height, string weight)
        {
            double heightPVT = Convert.ToDouble(height);
            double weightPVT = Convert.ToDouble(weight);
            double CalculatedBMI = (weightPVT / heightPVT / heightPVT) * 10000;
            return CalculatedBMI;
        }

        public static double FindAverage(params double[] numbers)
        {
            double result = 0.0;
            if (numbers != null && numbers.Length > 0)
            {
                result = numbers.Average();
            }
            return result;
        }

        public static double CalculateCaloriesBurned(double weight, double MET, double time)
        {
            double CaloriesBurned = (time * (MET * 3.5 * weight) / 200);
            return CaloriesBurned;
        }
    }
}
