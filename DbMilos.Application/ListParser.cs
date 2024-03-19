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

        public List<string> ParseItems(string items, string separator, bool trimWhitespace = true)
        {
            var parsed = this.ParseItems(items, separator);
            if (trimWhitespace)
            {
                List<string> trimmed = new List<string>();
                parsed.ForEach(x =>
                {
                    trimmed.Add(x.Trim());
                });
                return trimmed;
            }
            return parsed;
        }
    }
}
