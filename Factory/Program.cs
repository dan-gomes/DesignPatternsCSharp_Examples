using Microsoft.Extensions.DependencyInjection;
using System;

namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
           var provider = Startup.Iniciar();
        }
    }
}
