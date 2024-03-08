using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbMilos.Domain.Interfaces
{
    public interface IListTransformer
    {
        public List<string> ToUppercase(List<string> items);
        public List<string> ToLowercase(List<string> items);
        public List<string> ToPascalCase(List<string> items);
        public List<string> ToReverse(List<string> items);
        public List<string> ToSlug(List<string> items);
    }
}
