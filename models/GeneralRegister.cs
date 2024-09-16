using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2Prueba.models
{
    internal class GeneralRegister  
    {
        private string[,] Registro = new string[30, 2]; //Creamos el array (bidimensional). Persona-Edad

        public void AddName(string name, int pos) //Función añadir nombre
        {
            Registro[pos, 0] = name;
        }

        public void AddAge(DateTime fechaNac, int pos) //Función añadir edad
        {
            int age = CalculateAge(fechaNac);
            Registro[pos, 1] = age.ToString();
        }

        public string GetName(int pos) //Se añade en la fila el nombre
        {
            return Registro[pos, 0];
        }

        public string GetAge(int pos) //Se añade en la columna la edad
        {
            return Registro[pos, 1];
        }

        private int CalculateAge(DateTime fechaNac) //Fórmula para calcular la edad
        {
            int age = DateTime.Now.Year - fechaNac.Year;
            if (DateTime.Now.DayOfYear < fechaNac.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }

}
