using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbMilos.Domain.ListTransformer
{
    public enum ListTransformerOperations
    {
        ToUppercase = 1,
        ToLowercase = 2,
        ToPascalCase = 3,
        ToReverse = 4,
        ToSlug = 5
    }
}
