using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ResourceManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var resourcesManager = new System.Resources.ResourceManager("ResourceManager.Resources.Strings", typeof(Program).GetTypeInfo().Assembly);

            var result = resourcesManager.GetString("key1", CultureInfo.CurrentUICulture);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
