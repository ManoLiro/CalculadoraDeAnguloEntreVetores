using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeAnguloEntreVetores
{
    public class Calculos
    {
        public static double DotProduct(double[] vector1, double[] vector2)
        {
            double result = 0;
            for (int i = 0; i < vector1.Length; i++)
            {
                result += vector1[i] * vector2[i];
            }
            return result;
        }

        public static double VectorMagnitude(double[] vector)
        {
            double result = 0;
            foreach (double component in vector)
            {
                result += component * component;
            }
            return Math.Sqrt(result);
        }

        public static double AngleBetweenVectors(double[] vector1, double[] vector2)
        {
            double dot = DotProduct(vector1, vector2);
            double magnitude1 = VectorMagnitude(vector1);
            double magnitude2 = VectorMagnitude(vector2);
            double cosTheta = dot / (magnitude1 * magnitude2);
            return Math.Acos(cosTheta) * (180.0 / Math.PI); // Converte para graus
        }
    }
}
