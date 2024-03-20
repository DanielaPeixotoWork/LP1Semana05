using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main()
        {

        Stopwatch crono1 = new Stopwatch();
        Stopwatch crono2 = new Stopwatch();

        crono1.Start();

        Thread.Sleep(600);

        crono2.Start();

        Thread.Sleep(200);

        crono1.Stop();
        crono2.Stop();


        Console.WriteLine("Tempo decorrido em crono1: {0:F3} segundos", crono1.ElapsedMilliseconds / 1000.0);
        Console.WriteLine("Tempo decorrido em crono2: {0:F3} segundos", crono2.ElapsedMilliseconds / 1000.0);
        }
    }
}

