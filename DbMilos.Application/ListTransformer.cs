using DbMilos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbMilos.Application
{
    public class ListTransformer : IListTransformer
    {
        //
        public List<string> ToUppercase(List<string> items)
        {
            for(int i = 0; i < items.Count; i++)
            {
                items[i] = items[i].ToUpper();
            }
            return items;
        }
    }
}
