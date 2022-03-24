using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Unorderedlist
    {
        public void Operation()
        {
            string data = File.ReadAllText(@"C:\User\@nkush\DataType\Data Structure Programs Day16-17\Data_Structure_Programs\DataStructure\DataStructure\Unorderedlist.cs");
            Console.WriteLine("-----------------------Data from the file..---------------------------");
            Console.WriteLine(data);
            string[] words = data.Split(' ');
            LinkedList<string> linkedlist = new LinkedList<string>();
            foreach (string item in words)
            {
                linkedlist.AddLast(item);
            }
            Console.WriteLine("data into array...");
            Display(linkedlist);
            Console.WriteLine("Enter the string you want to search");
            string input = Console.ReadLine();
            if (linkedlist.Contains(input))
            {
                linkedlist.Remove(input);
                Console.WriteLine($"{input} removed from the list");
            }
            else
            {
                linkedlist.AddLast(input);
                Console.WriteLine($"{input} added to the list");
            }
            Console.WriteLine("-----------Data from the file after changes-----------------");
            Display(linkedlist);
        }
        private void Display(LinkedList<string> linkedlist)
        {
            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}