﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro= new Perro();
            Gato gato= new Gato();
            Animal[] animales = { perro, gato};
            Veterinaria Vet = new();
            Vet.AceptarMasDeUnAnimal(animales);

        }
    }
}