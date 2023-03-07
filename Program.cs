using Patrones_de_Diseño.AbstractFactory;
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("PATRONES DE DISEÑO");
using System;
/*class PruebaSingleton
{
static void Main(string[] args)
 {
 Console.WriteLine(Singleton.Instance.mensaje);
 Singleton.Instance.mensaje="Patron Singleton 2";
 Console.WriteLine(Singleton.Instance.mensaje);
 }
}*/

/*class PruebaState
    {
        static void Main(string[] args)
        {
            ServidorContext oServior = new ServidorContext();
            oServior.State = new DisponibleServerState();

            oServior.AtenderSolicitud();

            oServior.State = new SaturadoServerState();
            oServior.AtenderSolicitud();
            oServior.AtenderSolicitud();

            oServior.State = new SuperSaturadoServerState();
            oServior.AtenderSolicitud();
            oServior.AtenderSolicitud();

            oServior.State = new CaidoServerState();
            oServior.AtenderSolicitud();
            oServior.AtenderSolicitud();

            oServior.State = new DisponibleServerState();
            oServior.AtenderSolicitud();
            oServior.AtenderSolicitud();
        }
    }*/


/*class PruebaComposite
    {
        static void Main(string[] args)
        {
            Ingrediente oIngrediente1 = new Ingrediente("Harina", 100, 200, "gramos");
            Ingrediente oIngrediente2 = new Ingrediente("Leche", 20, 1, "litro");
            Ingrediente oIngrediente3 = new Ingrediente("Huevo", 20, 1, "kilo");

            PastelComposite oPastel = new PastelComposite("Pastel de leche");
            oPastel.Add(oIngrediente1);
            oPastel.Add(oIngrediente2);
            oPastel.Add(oIngrediente3);

           // Console.WriteLine(oPastel.Costo);

            Ingrediente oIngrediente4 = new Ingrediente("Chocolate",200,1,"litro");
            PastelComposite oPastelChocolateYLeche =new PastelComposite("Pastel compuesto");

            oPastelChocolateYLeche.Add(oIngrediente4);
            oPastelChocolateYLeche.Add(oPastel);

            Console.WriteLine(oPastelChocolateYLeche.CostoTotal);
        }
    }*/

/*class PruebaFactory
    {
        static void Main(string[] args)
        {
BebidaEmbriagante oBebida = Creador.CreadorBebida(Creador.VINO_TINTO);
Console.WriteLine(oBebida.CuantoMeEmbriagaPorHora());
        }
        
    }*/

    class PruebaAbstractFactory
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla = Console.ReadKey();

            Pizzeria fabrica = null;
            if (tecla.KeyChar=='a')
            {
                fabrica = new Patrones_de_Diseño.AbstractFactory.PizzeriaArgentina();
            }
            else if (tecla.KeyChar=='b')
            {
                fabrica = new PizzeriaItaliana();
            }
            else
            {
               fabrica = new PizzeriaJaponesa(); 
            }
            
            MostrarCatalogo(fabrica);

            Console.ReadKey();
        
        }
        public static void MostrarCatalogo(Pizzeria fabrica)
        {
            Pizza pizza = fabrica.CrearPizza();
            Empanada empanada = fabrica.CrearEmpanada();
            Console.WriteLine($"Pizza: {pizza.Descripcion}, Empanada: {empanada.Descripcion}");
        }
    }