﻿using FluentValidation;
using MediatR;

namespace Mediator.CQRS.Application.PipelineBehaviour;

public class RequestPipeline<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;
    public RequestPipeline(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }


    public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var context = new ValidationContext<TRequest>(request);
        var failures = _validators
            .Select(x => x.Validate(context))
            .SelectMany(x => x.Errors)
            .Where(x => x is not null)
            .ToList();

        if (failures.Any())
            throw new ValidationException(failures);

        return next();
    }


}
