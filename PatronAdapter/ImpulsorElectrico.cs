using System;
using System.Collections.Generic;
using System.Text;

namespace PatronAdapter
{
    class ImpulsorElectrico
    {
        //estructura boolena implementada para utilizar true y false tambien hacer uso de if y else
        bool _CONECTAR;
        bool _ACTIVAR;
        bool _MOVER;

        public void Conectar()
        {
            if (_CONECTAR)
            Console.WriteLine("EL IMPULSOR YA ESTÁ CONECTADO POR LO TAL NO SE PUEDE VOLVER A CONECTAR");
            else
            {
                _CONECTAR = true;
                    Console.WriteLine("SU IMPULSOR ELÉCTRICO FUE CONECTADO DE MANERA CORRECTA");
            }
        }
        public void Activar()
        {
            if (!_CONECTAR)
                Console.WriteLine("EL IMPULSOR ELÉCTRICO YA ESTÁ ACTIVADO POR LO TAL NO SE PUEDE VOLVER A ACTIVAR");
            else
            {
                _CONECTAR = true;
                Console.WriteLine("SU IMPULSOR ELÉCTRICO FUE ACTIVADO DE MANERA CORRECTA");
            }

        }
        public void Mover()
        {
            if (_CONECTAR && _ACTIVAR)
            {
                _MOVER = true;
                Console.WriteLine("SU IMPULSOR DEBE ESTAR CONECTADO Y ACTIVADO PARA PODER MOVERSE SU VEHICULO SE ESTA MOVIENDO GRACIAS AL IMPULSOR ELÉCTRICO");
            }
            else
            {
                Console.WriteLine("SU IMPULSOR ELÉCTRICO ESTÁ EN MOVIMIENTO");
            }

        }
        public void Parar()
        {
            if (_MOVER)
            {

                _MOVER = false;
                Console.WriteLine("NO ES POSIBLE PARAR SU MOTOR, ESTE NO ESTÁ EN MOVIMIENTO");
            }
            else
            {
                Console.WriteLine("SU IMPULSOR ELÉCTRICO ESTÁ PARANDO");
            }
        }
        public void Desconectar()
        {
            if (_CONECTAR)
            {
                Console.WriteLine("SU IMPULSOR ELÉCTRICO ESTÁ DESCONECTADO");
            }
            else
            {
                Console.WriteLine("EL IMPULSOR NO SE PUEDE DETENER YA QUE ESTE NO ESTA CONECTADO");
            }
        }
        public void Desactivar()
        {
            if (_ACTIVAR)
            {
                _ACTIVAR = false;
                Console.WriteLine("SU IMPULSOR NO SE PUEDE DESACTIVAR YA QUE NO ESTA ACTIVADO");
            }
            else
            {
                Console.WriteLine("SU IMPULSOR ELÉCTRICO ESTA DESACTIVADO");
            }
        }
        public void Enchufar()
        {
            if (!_ACTIVAR)
            {
                _ACTIVAR = false;
                Console.WriteLine("SU IMPULSOR ELÉCTRICO ESTÁ CARGANDO BATERIAS");

            }
            else
            {
                Console.WriteLine("NO ES POSIBLE ENCHUFAR SU IMPULSOR PORQUE SE ENCUENTRA ACTIVO");
            }
        }
    }
}
