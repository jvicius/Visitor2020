using System;
using VisitorDemo.models;

namespace VisitorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var billetes = new IBillete[]
            {
                new Billete200(),
                new Billete50(),
                new Billete200(),
                new Billete50(),
                new Billete100(),
                new Billete50(),
                new Billete100(),
                new Billete100(),
                new Billete200(),
                new Billete50(),
                new Billete200(),
                new Billete50(),
                new Billete100(),
                new Billete50(),
                new Billete100(),
                new Billete100(),
                new Billete200(),
                new Billete50(),
                new Billete200(),
                new Billete50(),
                new Billete100(),
                new Billete50(),
                new Billete100(),
                new Billete100(),
                new Billete200(),
                new Billete20(),
            };

            var organizador = new BilleteOrganizador();
            var contador = new BilleteContador();

            foreach(var billete in billetes)
            {
                billete.Aceptar(organizador);
                billete.Aceptar(contador);
            }

            Console.WriteLine($"$20 :{organizador.Billetes20.Count}");
            Console.WriteLine($"$50 :{organizador.Billetes50.Count}");
            Console.WriteLine($"$100 :{organizador.Billetes100.Count}");
            Console.WriteLine($"$200 :{organizador.Billetes200.Count}");
            Console.WriteLine($"Tolal: ${contador.total}");

            Console.ReadKey();
        }
    }
}
