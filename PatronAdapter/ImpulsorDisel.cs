using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAdapter
{
    // Clase con herencia que muestra en consola lo que sucede con el impulsor 
    class ImpulsorDisel : Impulsor
    {
        
        //METODOS DEL IMPULSOR A DISEL 
        public override void Acelerar()
        {
            Console.WriteLine("ACELERANDO IMPULSOR A DISEL");
        }
        public override void Arranque()
        {
            Console.WriteLine("ARRANCANDO IMPULSOR A DISEL");
        }
        public override void LlenarCombustible()
        {
            Console.WriteLine("LLENANDO COMBUSTIBLE AL IMPULSOR DE DISEL");
        }
        public override void Detener()
        {
            Console.WriteLine("DETENIENDO EL IMPULSOR A DISEL");
        }
    }
}
