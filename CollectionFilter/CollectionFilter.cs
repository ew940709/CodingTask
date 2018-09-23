using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFilter
{
    public static class CollectionFilter
    {
        public static IEnumerable<Element> Filter(IEnumerable<Element> elementList)
        {
            var uniqueByNum = GetUniqueByNum(elementList);
            return uniqueByNum.Where(element => element.Age > 20).Distinct();
        }


        private static IEnumerable<Element> GetUniqueByNum(IEnumerable<Element> elements)
        {
            return elements.GroupBy(element => element.Num).Select(element => element.FirstOrDefault());
        }
    }
}
