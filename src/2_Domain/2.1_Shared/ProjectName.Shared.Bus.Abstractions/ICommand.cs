
using MediatR;

namespace ProjectName.Shared.Bus.Abstractions
{
    public interface ICommand : IRequest<bool>
    {
    }

    public interface ICommand<TResponse> : IRequest<TResponse>
    {

    }
}
