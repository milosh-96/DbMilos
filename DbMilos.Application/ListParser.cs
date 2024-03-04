using DbMilos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbMilos.Application
{
    public class ListParser : IListParser
    {
        public List<string> ParseItems(string items, string separator)
        {
            return items.Split(separator).ToList();
        }

        
    }
}
