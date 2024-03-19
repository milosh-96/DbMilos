using DbMilos.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbMilos.Tests
{
    public class ListParserTests
    {
        private readonly ListParser parser;

        public ListParserTests()
        {
            parser = new ListParser();  
        }

        [Theory]
        [InlineData("1,2,3,4,5,6,7",",",7)]
        [InlineData(@"space seperated list items works correctly"," ",6)]
        [InlineData(@"email@email.com","@",2)]
        public void ListParser_ParseFromString_ReturnsCorrectNumberOfItemsWithSeparators(string items, string separator, int expected)
        {
            int actual = parser.ParseItems(items, separator).Count;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ListParser_ParseFromString_TrimmingWorksIfActivated()
        {
            string actual = string.Join(",",parser.ParseItems("1, 2, 3, 4, 5, 6,7,  ",",",true));
            string expected = "1,2,3,4,5,6,7,";
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ListParser_ParseFromString_TrimmingDoesntHappenIfDectivated()
        {
            string actual = string.Join(",",parser.ParseItems("1, 2, 3, 4, 5, 6,7,  ",",",false));
            string expected = "1, 2, 3, 4, 5, 6,7,  ";
            Assert.Equal(expected, actual);
        }
    }
}
