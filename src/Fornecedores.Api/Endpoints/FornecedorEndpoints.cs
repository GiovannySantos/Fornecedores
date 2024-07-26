using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System.Net;

namespace Fornecedores.Api.Endpoints
{
    public static class FornecedorEndpoints
    {
        public static RouteGroupBuilder MapFornecedorEndpoints(this RouteGroupBuilder builder)
        {
            builder.MapGet("/fornecedores", () => ObterFornecedores)
                .Produces(200, typeof(List<string>))
                .WithSummary("Obtém todos os fornecedores")
                .WithOpenApi();

            return builder;
        }

        public static List<string> ObterFornecedores(HttpContext context)
        {
            return ["Fornecedor 1", "Fornecedor 2"];
        }
    }
}
