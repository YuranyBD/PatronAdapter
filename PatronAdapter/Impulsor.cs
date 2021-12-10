using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAdapter
{
    //clase abstracta que implementa cuatro operaciones
    public abstract class Impulsor 
    {
        public abstract void Acelerar();
        public abstract void Arranque();
        public abstract void Detener();
        public abstract void LlenarCombustible();
    }
}
