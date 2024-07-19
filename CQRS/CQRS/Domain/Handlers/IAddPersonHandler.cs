using CQRS.Domain.Request;
using CQRS.Domain.Response;

namespace CQRS.Domain.Handlers
{
    public interface IAddPersonHandler
    {
        AddPersonResponse Handler(AddPersonRequest request);
    }
}
