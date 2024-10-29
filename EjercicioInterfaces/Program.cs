class Program
{
    static void Main(string[] args)
    {
        Operaciones operaciones = new Operaciones();

        Console.WriteLine("Ingrese el radio para área, longitud y volumen:");
        double radio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese perímetro y superficie:");
        double lado = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("los paramametros ingresados son :");

        Console.WriteLine($"Área: {operaciones.Area(radio)} Cm");
        Console.WriteLine($"Longitud: {operaciones.Longitud(radio)}Cm");
        Console.WriteLine($"Volumen: {operaciones.Volumen(radio)}Cm");
        Console.WriteLine($"Perímetro: {operaciones.Perimetro(lado)}Cm");
        Console.WriteLine($"Superficie: {operaciones.Superficie(lado)}Cm");

        operaciones.Imprimir();
    }
}
