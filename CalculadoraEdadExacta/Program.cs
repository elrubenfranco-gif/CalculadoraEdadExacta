using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa tu fecha de nacimiento (yyyy-MM-dd): ");
        string fechaTexto = Console.ReadLine() ?? "";

        if (DateTime.TryParse(fechaTexto, out DateTime fechaNacimiento))
        {
            TimeSpan diferencia = DateTime.Now - fechaNacimiento;
            Console.WriteLine($"Tienes {diferencia.Days} días de vida.");
        }
        else
        {
            Console.WriteLine("Fecha inválida.");
        }

        Console.Write("Ingresa tu nombre completo: ");
        string nombre = Console.ReadLine() ?? "";
        string nombreLimpio = nombre.Trim().ToUpper();
        Console.WriteLine($"BIENVENIDO, {nombreLimpio}");

        Console.Write("Ingresa tu correo: ");
        string correo = Console.ReadLine() ?? "";

        if (correo.Contains("@"))
        {
            string[] partes = correo.Split('@');
            Console.WriteLine($"El dominio es: {partes[1]}");
        }
        else
        {
            Console.WriteLine("Correo inválido.");
        }
    }
}
