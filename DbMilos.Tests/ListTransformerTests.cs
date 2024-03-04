using DbMilos.Application;

namespace DbMilos.Tests
{
    public class ListTransformerTests
    {
        private readonly ListTransformer _transformer;

        public ListTransformerTests()
        {
            _transformer = new ListTransformer();
        }

        [Fact]
        public void ListTransformer_ToUppercase_ItemsAreReturnedAsUppercase()
        {
            List<string> items = new List<string>()
            {
                "this",
                "is",
                "a (1) list",
                "that has to be",
                "in",
                "Uppercase"
            };

            string expected = "THIS IS A (1) LIST THAT HAS TO BE IN UPPERCASE";
            string actual = string.Join(" ",_transformer.ToUppercase(items));
            Assert.Equal(expected, actual); 
        }
    }
}