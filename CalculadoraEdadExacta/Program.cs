using System;

class Program
{
    static void Main(string[] args)
    {
        // ===============================
        // 1️⃣ Calculadora de Edad Exacta
        // ===============================

        Console.WriteLine("=== CALCULADORA DE EDAD EXACTA ===");
        Console.Write("Ingresa tu fecha de nacimiento (yyyy-MM-dd): ");
        string fechaTexto = Console.ReadLine();

        DateTime fechaNacimiento = DateTime.Parse(fechaTexto);
        DateTime fechaActual = DateTime.Now;

        TimeSpan diferencia = fechaActual - fechaNacimiento;

        Console.WriteLine($"Tienes {diferencia.Days} días de vida.");
        Console.WriteLine();


        // ===============================
        // 2️⃣ Corrector de Nombres
        // ===============================

        Console.WriteLine("=== CORRECTOR DE NOMBRES ===");
        Console.Write("Ingresa tu nombre completo: ");
        string nombre = Console.ReadLine();

        string nombreLimpio = nombre.Trim().ToUpper();

        Console.WriteLine($"BIENVENIDO, {nombreLimpio}");
        Console.WriteLine();


        // ===============================
        // 3️⃣ Analizador de Correos
        // ===============================

        Console.WriteLine("=== ANALIZADOR DE CORREOS ===");
        Console.Write("Ingresa tu correo: ");
        string correo = Console.ReadLine();

        // Opción 1: usando Split
        string[] partes = correo.Split('@');
        string dominio = partes[1];

        Console.WriteLine($"El dominio es: {dominio}");
    }
}
