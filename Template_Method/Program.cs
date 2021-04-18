using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Template_Method.Entidades.Enumerators;
using Template_Method.Interfaces;

namespace Template_Method
{
    public class Program
    {
        private static IDictionary<TheThirteenColoniesEnum, Type> _repository = new Dictionary<TheThirteenColoniesEnum, Type>();

        static void Main(string[] args)
        {

            var repositorys = Enum.GetNames(typeof(TheThirteenColoniesRepositoryEnum));
            var colonies = Enum.GetNames(typeof(TheThirteenColoniesEnum));

            for (int i = 0; i < repositorys.Length; i++)
            {
                _repository[(TheThirteenColoniesEnum)Enum
                    .Parse(typeof(TheThirteenColoniesEnum), colonies[i])] = Type.GetType($"Template_Method.Entidades.{repositorys[i]}");
            }

            Console.WriteLine("Informe o enumerador: ");
            int input = int.Parse(Console.ReadLine());

            var resultado = Create((TheThirteenColoniesEnum)input)
                .GetByState();

            Console.WriteLine(
                "Population: " + resultado.Item1.ToString("F2", CultureInfo.InvariantCulture) 
                + Environment.NewLine
                + "Description: " + resultado.Item2);
        }

        /// <summary>
        /// This method will instantiate through the assembly of a class.
        /// </summary>
        /// <param name="theThirteenColoniesEnum"></param>
        /// <returns>A new instance of a class that has the interface <see cref="ITheThirteenColonies"/> </returns>
        public static ITheThirteenColonies Create(TheThirteenColoniesEnum theThirteenColoniesEnum)
        {
            ITheThirteenColonies result = null;

            if (_repository.TryGetValue(theThirteenColoniesEnum, out Type type))
            {
                var assembly = Assembly.Load("Template_Method")
                    .GetTypes()
                    .First(t => t.Name == type.Name);
                result = Activator.CreateInstance(assembly) as ITheThirteenColonies;
            }
            return result;
        }      
    }
}
