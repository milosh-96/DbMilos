using DbMilos.Application;

namespace DbMilos.Tests
{
    public class ListTransformerTests
    {
        private readonly ListTransformer _transformer;

        List<string> items { get; set; } = new List<string>()
            {
                "this",
                "is",
                "a","(1)", "list",
                "that","has","to","be",
                "transformed",
                "correctly!",
            };
        public ListTransformerTests()
        {
            _transformer = new ListTransformer();
        }

        [Fact]
        public void ListTransformer_ToUppercase_ItemsAreReturnedAsUppercase()
        {
            string expected = "THIS IS A (1) LIST THAT HAS TO BE TRANSFORMED CORRECTLY!";
            string actual = string.Join(" ",_transformer.ToUppercase(items));
            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void ListTransformer_ToLowercase_ItemsAreReturnedAsLowercase()
        {
            string expected = "this is a (1) list that has to be transformed correctly!";
            string actual = string.Join(" ",_transformer.ToLowercase(items));
            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void ListTransformer_ToPascalcase_ItemsAreReturnedAsPascalcase()
        {
            string expected = "This Is A (1) List That Has To Be Transformed Correctly!";
            string actual = string.Join(" ",_transformer.ToPascalCase(items));
            Assert.Equal(expected, actual); 
        }
    }
}