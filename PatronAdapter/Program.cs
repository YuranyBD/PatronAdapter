using System;
//nombre del proyecto
namespace PatronAdapter
{
    //clase
    class Program
    {
        //INSTANCIAS
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("--------------*IMPULSOR A DISEL*--------------");
            ImpulsorDisel impulsor1 = new ImpulsorDisel();
            impulsor1.Arranque();
            impulsor1.Acelerar();
            impulsor1.Detener();
            impulsor1.LlenarCombustible();
            Console.WriteLine("**************************************************");
            Console.WriteLine("--------------*IMPULSOR A GASOLINA*--------------");
            ImpulsorGasolina impulsor2 = new ImpulsorGasolina();
            impulsor2.Arranque();
            impulsor2.Acelerar();
            impulsor2.Detener();
            impulsor2.LlenarCombustible();
            Console.WriteLine("**************************************************");
            Console.WriteLine("--------------*IMPULSOR ELÉCTRICO*--------------");
            //EN ESTA PARTE SE UTILIZA EL ADAPTER PARA EL IMPULSOR ELECTRICO 

            ImpulsorElectricoAdapter impulsor3 = new ImpulsorElectricoAdapter();
            impulsor3.Arranque();
            impulsor3.Acelerar();
            impulsor3.Detener();
            impulsor3.LlenarCombustible();
            Console.WriteLine("**************************************************");
            Console.ReadKey();
        }
    }
}
