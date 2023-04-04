﻿using GamesCorner.Server.Requests;
using MediatR;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;

namespace GamesCorner.Server.Handlers
{
    public class GetProductHandler: IRequestHandler<GetProductRequest, IResult>
    {
        public async Task<IResult> Handle(GetProductRequest request, CancellationToken cancellationToken)
        {
            var product = request.UnitOfWork.ProductRepository.GetAsync(request.Id);
            return product is null ? Results.NotFound("Product doesn't exist") : Results.Ok(product);
        }
    }
}