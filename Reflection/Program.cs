using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EMSEntities ems =new EMSEntities()){
                Console.WriteLine("Please enter search field");
                var searchField = Console.ReadLine();
                Console.WriteLine("Please enter search value");
                var searchValue = Console.ReadLine();

                var result = ExtractInfo.GetByCodi<Employee>(ems.Employees, searchValue, searchField);

                
                
                    Console.WriteLine(result.FirstName);
                    Console.WriteLine(result.LastName);
                    Console.WriteLine(result.State);
                    Console.WriteLine(result.City);
                

                Console.ReadKey();
            }
        }
    }
}
