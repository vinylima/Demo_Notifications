﻿
using MediatR;

namespace ProjectName.Shared.Bus.Abstractions
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, bool>
        where TCommand : ICommand
    {

    }
    
    public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
    {

    }
}