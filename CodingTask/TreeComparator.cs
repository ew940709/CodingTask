using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTask
{
    public static class TreeComparator
    {

        public static bool Compare(BTN first, BTN second)
        {
            if (first == null && second == null)
            {
                return true;
            }
            else if (first != null && second != null)
            {
               return first.Value == second.Value && Compare(first.Left, second.Left) && Compare(first.Right, second.Right);             
            }
            else
            {
                return false;
            }
        }
    }
}
