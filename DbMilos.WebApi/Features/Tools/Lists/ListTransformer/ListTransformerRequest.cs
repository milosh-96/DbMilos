using DbMilos.Domain.ListTransformer;

namespace DbMilos.WebApi.Features.Tools.Lists.ListTransformer
{
    public class ListTransformerRequest
    {
        public string Content { get; set; }

        public string Separator { get; set; }

        public ListTransformerOperations Operation { get; set; }

        public string Trim { get; set; } = "true";
    }
}
