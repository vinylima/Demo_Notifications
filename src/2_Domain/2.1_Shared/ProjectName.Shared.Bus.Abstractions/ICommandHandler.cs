
using MediatR;

using ProjectName.Shared.Bus.Abstractions.ValueObjects;

namespace ProjectName.Shared.Bus.Abstractions
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, bool> where TCommand : Command
    {

    }

    public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : Command<TResponse>
    {

    }
}