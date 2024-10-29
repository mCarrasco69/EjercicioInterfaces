using EjercicioInterfaces;

public class Operaciones : IOperaciones
{
    public double Area(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public double Longitud(double radio)
    {
        return 2 * Math.PI * radio;
    }

    public double Volumen(double radio)
    {
        return (4 / 3) * Math.PI * Math.Pow(radio, 3);
    }

    public double Perimetro(double lado)
    {
        return 4 * lado;
    }

    public double Superficie(double lado)
    {
        return lado * lado;
    }

    public void Imprimir()
    {
        Console.WriteLine();
        Console.WriteLine("Resultados de las operaciones:");
        Console.WriteLine($"Área: {Area(5)}Cm");
        Console.WriteLine($"Longitud: {Longitud(5)}Cm");
        Console.WriteLine($"Volumen: {Volumen(5)}Cm");
        Console.WriteLine($"Perímetro: {Perimetro(5)}Cm");
        Console.WriteLine($"Superficie: {Superficie(5)}Cm");
    }
}
