using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTask
{
    class Program
    {

        static void Main(string[] args)
        {
            var firstTree = new BTN();
            firstTree.Value = 1;
            var secondTree = new BTN();
            secondTree.Value = 1;

            Console.WriteLine(TreeComparator.Compare(firstTree, secondTree));
            Console.ReadKey();

        }

    }
}
