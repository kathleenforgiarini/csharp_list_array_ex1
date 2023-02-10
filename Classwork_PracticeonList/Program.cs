using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CODED BY KATHLEEN FORGIARINI DA SILVA

namespace Classwork_PracticeonList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating the list
            List<int> listStudents = new List<int>();

            // creating a loop to insert data to the list
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number to add to the list: ");
                listStudents.Add(Convert.ToInt32(Console.ReadLine()));
            }

            // displaying the elements of the list at the first moment:
            Console.WriteLine("\nElements of the list at the first moment: \n");
            foreach (int element in listStudents)
            {
                Console.WriteLine("Number " + element);
            }

            // creating the array
            int[] arrStudents = new int[5];

            // creating the loop to insert data to the array
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number to add to the array: ");
                arrStudents[i] = Convert.ToInt32(Console.ReadLine());
            }

            // displaying the elements of the array:
            Console.WriteLine("\nElements of the array at the first moment: \n");
            foreach (int element in arrStudents)
            {
                Console.WriteLine("Number " + element);
            }


            // inserting the data of the array to the list
            listStudents.AddRange(arrStudents);

            // displaying the elements of the list
            Console.WriteLine("\nAll the elements: \n");
            foreach (int element in listStudents)
            {
                Console.WriteLine("Number " + element);
            }

            Console.ReadKey();
        }
    }
}
