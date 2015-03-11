using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Analyze();
        }

        /// <summary>
        /// Example of how to connect.
        /// </summary>
        public static void Analyze()
        {
            using (var context = AppConfig.DbContext())
            {
                // do some stuff here.
            }
        }
    }
}
