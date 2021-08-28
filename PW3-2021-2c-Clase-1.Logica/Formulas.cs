using System;

namespace PW3_2021_2c_Clase_1.Logica
{
    public class Formulas
    {

        public static string calcularIMC(double altura, double peso, out double IMC)
        {
            IMC = peso / Math.Pow(altura, 2);


            if (IMC < 18.50)                    return "Bajo peso";
            if (IMC < 16)                       return "Delgadez severa";
            if (IMC >= 16 && IMC <= 16.99)      return "Delgadez moderada";
            if (IMC >= 17 && IMC <= 18.49)      return "Delgadez leve";
            if (IMC >= 18.5 && IMC <= 24.99)    return "Normal";
            if (IMC == 25)                      return "Sobrepeso";
            if (IMC > 25 && IMC <= 29.99)       return "Preobesidad";
            if (IMC == 30)                      return "Obesidad";
            if (IMC > 30 && IMC <= 34.99)       return "Obesidad leve";
            if (IMC > 35 && IMC <= 39.99)       return "Obesidad media";
            
            
            return "Obesidad mórbida";
        }



    }
}
