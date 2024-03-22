using DbMilos.Application;
using DbMilos.Domain.Interfaces;
using DbMilos.Domain.ListTransformer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbMilos.WebApi.Features.Tools.Lists.ListTransformer
{
    [Route("api/lists/[controller]/[action]")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ListTransformerController : ControllerBase
    {
        private readonly IListParser _parser;
        private readonly IListTransformer _transformer;

        public ListTransformerController(IListParser parser, IListTransformer transformer)
        {
            _parser = parser;
            _transformer = transformer;
        }

        [HttpPost]
        public async Task<IActionResult> Transform([FromBody]ListTransformerRequest request)
        {
            bool trim = true;
            Boolean.TryParse(request.Trim, out trim);
            var parsed = _parser.ParseItems(request.Content, request.Separator,trim);
            var result = new List<string>();
            switch(request.Operation)
            {
                default:
                    result.AddRange(_transformer.ToUppercase(parsed));
                    break;
                case ListTransformerOperations.ToUppercase:
                    result.AddRange(_transformer.ToUppercase(parsed));
                    break;
                case ListTransformerOperations.ToLowercase:
                    result.AddRange(_transformer.ToLowercase(parsed));
                    break;
                case ListTransformerOperations.ToPascalCase:
                    result.AddRange(_transformer.ToPascalCase(parsed));
                    break;
                case ListTransformerOperations.ToReverse:
                    result.AddRange(_transformer.ToReverse(parsed));
                    break;
                case ListTransformerOperations.ToSlug:
                    result.AddRange(_transformer.ToSlug(parsed));
                    break;
            }
            return new JsonResult(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetOperations()
        {
            return new JsonResult(Enum.GetValues<ListTransformerOperations>());
        }
    }
}
