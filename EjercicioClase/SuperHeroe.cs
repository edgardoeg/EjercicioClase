namespace EjercicioClase
{
    public class SuperHeroe
    {

        public string? Nombre { get; set; }
        public string? IdentidadSecreta { get; set; }
        public string? Ciudad { get; set; }
        public bool PuedeVolar { get; set; }
        public string? SuperPoder { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre : {Nombre}");
            Console.WriteLine($"Identidad Secreta : {IdentidadSecreta}");
            Console.WriteLine($"Ciudad : {Ciudad}");
            Console.WriteLine($"Puede Volar : {PuedeVolar}");
            Console.WriteLine($"Super Poder : {SuperPoder}");
        }
    }
}
