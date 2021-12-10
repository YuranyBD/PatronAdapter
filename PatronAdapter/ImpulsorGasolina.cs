using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAdapter
{
    // Clase con herencia que muestra en consola lo que sucede con el impulsor 
    class ImpulsorGasolina :Impulsor
    {
        public override void Acelerar()
        {
            Console.WriteLine("ACELERANDO IMPULSOR A GASOLINA");
        }
        public override void Arranque()
        {
            Console.WriteLine("ARRANCANDO IMPULSOR A GOSOLINA");
        }
        public override void LlenarCombustible()
        {
            Console.WriteLine("LLENANDO COMBUSTIBLE AL IMPULSOR DE GASOLINA");
        }
        public override void Detener()
        {
            Console.WriteLine("DETENIENDO EL IMPULSOR A GASOLINA");
        }
    }
}
