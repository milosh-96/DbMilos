using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbMilos.Domain.Interfaces
{
    public interface IListParser
    {
        public List<string> ParseItems(string items, string separator);
        public List<string> ParseItems(string items, string separator, bool trimWhitespace);
    }
}
