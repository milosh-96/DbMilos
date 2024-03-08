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
        public List<string> ToLowercase(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                items[i] = items[i].ToLower();
            }
            return items;
        }

        public List<string> ToPascalCase(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                string temp = "";
                for(int j = 0; j < items[i].Length; j++)
                {
                    if(j == 0)
                    {
                        temp += (items[i][j].ToString().ToUpper());
                    }
                    else
                    {
                        temp += items[i][j].ToString().ToLower();
                    }
                }
                items[i] = temp;
            }
            return items;
        }

        public List<string> ToReverse(List<string> items)
        {
            throw new NotImplementedException();
        }

        public List<string> ToSlug(List<string> items)
        {
            throw new NotImplementedException();
        }

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
