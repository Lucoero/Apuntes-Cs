using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_Cs
{
    internal class SubClass : SuperClass
    {
        public override void Modificable()
        {
            base.Modificable(); // Ejecuta lo que haya originalmente
            Console.WriteLine("Espera... ¡Si soy SubClass!");
        }
    }
}
