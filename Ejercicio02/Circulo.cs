using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Circulo : FiguraGeometrica
    {
        //Atributos de la clase
        public double iRadio;
        public Punto iCentro;

        //Propiedades
        public Punto Centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        }

        public double Radio
        {
            get { return this.iRadio; }
            set { this.iRadio = value; }
        }


        //Constructor Circulo a partir de coordenadas
        public Circulo(double pX, double pY, double pRadio)
        {
            iCentro = new Punto(pX, pY);
            iRadio = pRadio;
        }

        //Constructor Circulo a partir del punto
        public Circulo(Punto pPunto, double pRadio)
        {
            iCentro = pPunto;
            iRadio = pRadio;
        }

        //Metodos sobreescritos

        public override double CalcularArea()
        {
            return (Math.PI * Math.Pow(this.iRadio, 2));
        }
        public override double CalcularPerimetro()
        {
            return (2 * Math.PI * this.iRadio);
        }
    }
}
