using System;

namespace Kaprekar;

internal class Kaprekar
{
    static void Main()
    {
        Console.Title = "Kaprekar";
        Start:
        Console.WriteLine("Introduce un número de 4 cifras, donde todas no pueden ser iguales");
        int[] kpkcifras = new int[4];
        int i = 0;
        bool Kpkcompletado = true;

        int kpkFormado = 0;
        int kpkFormadoDes = 0;
        int neokpk = 0;
        int kpkInput = 0;
        int steps = 0;

        try
        {
            kpkInput = int.Parse(Console.ReadLine());
        }
        catch (FormatException e)
        {
            Console.Clear();
            Console.WriteLine("Se introdujo algo que no era un numero :)");
            Console.ReadKey();
            goto Start;
        }
        
        while(Kpkcompletado){
            i = 0; kpkFormado = 0; kpkFormadoDes = 0;
            Array.Clear(kpkcifras);

            if (kpkInput == 1111 || kpkInput == 2222 || kpkInput == 3333 || kpkInput == 4444 || kpkInput == 5555 || kpkInput == 6666 || kpkInput == 7777 || kpkInput == 8888 || kpkInput == 9999 || kpkInput <= 999)
            {
                Console.WriteLine("Estás poniendo cosas que no te dije\n");
                goto Start;
            }
            do
            {
                kpkcifras[i] = kpkInput % 10;
                kpkInput /= 10;
                i++;
            } while (kpkInput > 0);
        
        //Ascendente acá
        Array.Sort(kpkcifras);
        
        for (int d = 0; d < kpkcifras.Length; d++)
        {
            kpkFormado += kpkcifras[d] * (int)Math.Pow(10, (kpkcifras.Length -1 - d));
        }
        //Console.WriteLine(kpkFormado);

        Array.Reverse(kpkcifras);
        
        for (int d = 0; d < kpkcifras.Length; d++)
        {
            kpkFormadoDes += kpkcifras[d] * (int)Math.Pow(10, (kpkcifras.Length -1 - d));
        }
        //Console.WriteLine(kpkFormadoDes);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"El número elegido ordenado a menor es {kpkFormado}");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"El número elegido ordenado a mayor es {kpkFormadoDes}");

        Console.ForegroundColor = ConsoleColor.Green;
        neokpk = kpkFormadoDes - kpkFormado;
        Console.WriteLine($"El número nuevo formado es --------- {neokpk}");
        kpkInput = neokpk;
        steps++;
        System.Console.WriteLine("Continuar...");
        Console.ReadKey();
        
        //Kpkcompletado = (neokpk == 6174) ? Kpkcompletado = false : continue;
        if (neokpk == 6174){ Kpkcompletado = false; }
        else{ continue; }
        }
        Console.WriteLine("Se ha completado tu kaprekar con {0} pasos", steps);
        Console.ReadKey();
    }
}
//Como ordenar las cifras de un numero
//Formar un numero a partrir de numeros de un array
//Ordenar un array de amnera ascendente y descendente