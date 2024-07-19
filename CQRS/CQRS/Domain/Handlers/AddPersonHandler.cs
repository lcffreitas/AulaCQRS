using CQRS.Domain.Request;
using CQRS.Domain.Response;

namespace CQRS.Domain.Handlers
{
    public class AddPersonHandler : IAddPersonHandler
    {
        public AddPersonResponse Handler(AddPersonRequest request)
        {
            // Verifica se a pessoa existe
            // Valida os dados
            // Inserir e Adicionar a pessoa
            // Notifica
            return new AddPersonResponse
            {
                Id = Guid.NewGuid(),
                Name = "Lucas",
                Age = 18,
                TaxId = "123456"
            };
        }
    }
}
