using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Veterinaria
    {
        public void AceptarAnimales(Animal animal)
        {
            animal.HacerRuido();
        }

        public void AceptarMasDeUnAnimal(Animal[] animales)
        {
            for (int i = 0; i < animales.Length; i++)
            { animales[i].HacerRuido(); }
        }
    }
}
