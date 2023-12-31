﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeAnguloEntreVetores
{
    public class Calculos
    {

        public static string DotProductString(double[] vector1, double[] vector2)
        {
            double result = 0;
            string Conta = "";
            for (int i = 0; i < vector1.Length; i++)
            {
                Conta += vector1[i].ToString() + " * " + vector2[i].ToString();
                result += vector1[i] * vector2[i];
                if (i <= vector1.Length - 2)
                {
                    Conta += " + ";
                }
            }
            Conta += $" = {result}";
            return Conta;
        }

        public static string VectorMagnitude5tring(double[] vector)
        {
            double result = 0;
            string Conta = "Raiz Quadrada de ";
            int i = 0;
            foreach (double component in vector)
            {
                Conta += component.ToString() + " * " + component.ToString();
                result += component * component;
                if (i < vector.Length - 1)
                {
                    Conta += " + ";
                }
                i++;
            }
            Conta += $" = {Math.Sqrt(result).ToString("N2", new CultureInfo("pt-BR"))}";
            return Conta;
        }

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
        public static string cosThetaString(double[] vector1, double[] vector2)
        {
            double dot = DotProduct(vector1, vector2);
            double magnitude1 = VectorMagnitude(vector1);
            double magnitude2 = VectorMagnitude(vector2);
            string cosTheta = dot.ToString() + " / " + $"({magnitude1} * {magnitude2})";
            return cosTheta;
        }
        public static string AngleBetweenVectorsString(double[] vector1, double[] vector2)
        {
            double dot = DotProduct(vector1, vector2);
            double magnitude1 = VectorMagnitude(vector1);
            double magnitude2 = VectorMagnitude(vector2);
            double cosTheta = dot / (magnitude1 * magnitude2);
            double result = Math.Acos(cosTheta) * (180.0 / Math.PI);
            return "ArcoSeno = " + Math.Acos(cosTheta).ToString() + "\n" + "Ângulo = " + Math.Acos(cosTheta).ToString() + " * " + "(180 / 3,14) = " + result.ToString("N2", new CultureInfo("pt-BR")); // Converte para graus
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
