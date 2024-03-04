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
    }
}
