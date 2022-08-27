using System;
using System.Diagnostics;
using System.Threading;
using System.Text;
using analisisAlgoritmos;
using System.Runtime.CompilerServices;

public class Ejemplo
{
    public static void Main()
    {
        Console.WriteLine("Por favor digite el algoritmo a trabajar");
        int algoritmo = Convert.ToInt32(Console.ReadLine());

        var iteracciones = new List<dynamic>();

        iteracciones.Add(10);
        iteracciones.Add(100);
        iteracciones.Add(1000);
        iteracciones.Add(2000);


        if (algoritmo == 1)
        {
            var response = Servicios.ThreeSum(iteracciones);
            Console.ReadLine();

        }
        else if (algoritmo == 2)
        {
            var response = Servicios.TwoSumFast();
            Console.ReadLine();
        }
        else if (algoritmo == 3)
        {
            var response = Servicios.ThreeSumFast();
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
        /*
        Stopwatch timer1 = new Stopwatch();

        int cantidad = 0;
        Console.Write("Digite la cantidad de caracteres a trabajar ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        string string1 = "", string11 = "", string2 = "", string21 = "", string3 = "", string31 = "";

        string11 = "1";        
        string1 = string11.PadRight(cantidad, '0');        

        /*Console.Write("Introduce el primer número: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());
        suma = primerNumero + segundoNumero;

        Console.WriteLine("La suma de {0} y {1} es {2}",
            primerNumero, segundoNumero, suma);
        timer1.Start();
        String reversar = String.Empty;
        char[] reverse = string1.ToCharArray();
        for (int i = reverse.Length - 1; i > -1; i--)
        {
            reversar += reverse[i];
        }
        timer1.Stop();
        Console.WriteLine("El string 1 " +  reversar + " demoro " + timer1.ElapsedMilliseconds + " milisegundos");

        timer1.Restart();
        string reverse2 = "";
        Console.Write("Introduce el string2: ");
        try
        {
            string2 = Console.ReadLine();
        }
        catch (Exception e) { };
        foreach (char c in string2)
        {
            reverse2 = c + reverse2;
        }
        timer1.Stop();
        Console.WriteLine($"El string 2 : {reverse2} demoro {timer1.ElapsedMilliseconds} milisegundos");

        timer1.Restart();
        Console.Write("Enter a String3 : ");
        string3 = Console.ReadLine();
        char[] reverse3 = string3.ToCharArray();
        Array.Reverse(reverse3);
        string reverse31 = new string(reverse3);
        timer1.Stop();
        Console.WriteLine($"Reverse String is : {reverse31} demoro {timer1.ElapsedMilliseconds} milisegundos\"");
        Console.ReadLine();*/

    }
}