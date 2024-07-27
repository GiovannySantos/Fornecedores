namespace Fornecedores.Api.Endpoints
{
    public static class FornecedorEndpoints
    {
        public static RouteGroupBuilder MapFornecedorEndpoints(this RouteGroupBuilder builder)
        {
            builder.MapGet("/fornecedores", (HttpContext context) => ObterFornecedores(context))
                .Produces(200, typeof(List<string>))
                .WithSummary("Obtém todos os fornecedores")
                .WithOpenApi();
            
            builder.MapGet("/fornecedores/{id}", (HttpContext context, string id) => ObterFornecedorPorId(context, id))
                .Produces(200, typeof(List<string>))
                .WithSummary("Obtém um fornecedor pelo ID")
                .WithOpenApi();

            builder.MapPost("/fornecedores", (HttpContext context, string novoFornecedor) => AdicionarFornecedor(context, novoFornecedor))
                .WithSummary("Adiciona um novo fornecedor")
                .WithOpenApi();

            builder.MapPut("/fornecedores/{id}", (HttpContext context, string id) => AtualizarFornecedor(context, id))
                .WithSummary("Atualiza um fornecedor existente por ID")
                .WithOpenApi();

            builder.MapPut("/fornecedores/{id}", (HttpContext context, string id) => RemoverFornecedor(context, id))
                .WithSummary("Remove um fornecedor existente por ID")
                .WithOpenApi();

            return builder;
        }

        private static string RemoverFornecedor(HttpContext context, string id)
        {
            throw new NotImplementedException();
        }

        private static string AtualizarFornecedor(HttpContext context, string id)
        {
            throw new NotImplementedException();
        }

        private static string AdicionarFornecedor(HttpContext context, string novoFornecedor)
        {
            throw new NotImplementedException();
        }

        private static string ObterFornecedorPorId(HttpContext context, string id)
        {
            throw new NotImplementedException();
        }

        public static List<string> ObterFornecedores(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
