using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAdapter
{
    //clase adapter con operaciones distintas a las otras clases 
    class ImpulsorElectricoAdapter:Impulsor
    {
        ImpulsorElectrico impulsorElectrico = new ImpulsorElectrico();

        internal ImpulsorElectrico ImpulsorElectrico
        {
            get => default;
            set
            {
            }
        }

        public override void Acelerar()
        {
            impulsorElectrico.Mover();
        }
        public override void Arranque()
        {
            impulsorElectrico.Conectar();
            impulsorElectrico.Activar();
        }
        public override void LlenarCombustible()
        {
            impulsorElectrico.Enchufar();
        }
        public override void Detener()
        {
            impulsorElectrico.Desactivar();
            impulsorElectrico.Parar();
        }
    }
}
