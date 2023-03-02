using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_Cs
{
    internal class Contraseñas
    {
        private string contraseña;
        public string AdministrarContraseña
        {
            get { return contraseña; } // Ejemplo de getter. Cojo el valor de contraseña y lo almaceno en value
            set
            {
                if (value == "1234")
                {
                    Console.WriteLine("Amigo, tu contraseña es un poco cacas");
                }
                else
                {
                    contraseña = value; // Finalmente la actualizo
                }
                 
            } // Ejemplo de setter
        }
        /* Duda interesante:
         * En la primera atribución de un valor a contraseña pasamos por AdministrarContraseña (véase el Constructor de abajo)
         * Sin embargo, AdministrarContraseña para funcionar llama primero a contraseña (véase el get)
         * Así, ¿cómo pasa por el if, si el valor de contraseña en esa situación es null?
        */
        public Contraseñas(string aPass)
        {
            AdministrarContraseña = aPass; // En vez de entrar directamente en contraseña, paso por el filtro de AdministrarContraseña
        }
        
    }
}
