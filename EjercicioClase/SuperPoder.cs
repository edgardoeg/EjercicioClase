
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioClase
{
    public class SuperPoder
    {

        public string? Nombre {  get; set; }
        public string? Descripcion { get; set; }
        public double Nivel { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre : {Nombre}");
            Console.WriteLine($"Descripcion : {Descripcion}");
            Console.WriteLine($"Nivel : {Nivel}");
        }

    }
}
