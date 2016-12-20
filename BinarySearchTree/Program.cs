using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchTree<int> tree = new SearchTree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(25);
            tree.Add(12);
            tree.Add(5);
            tree.Display();
            tree.Search(5);
            tree.Search(12);
            tree.Search(25);
            tree.Search(1);
            tree.Search(8);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
