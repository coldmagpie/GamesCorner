﻿using DataAccess.UnitOfWork;
using GamesCorner.Server.Requests.Interface;

namespace GamesCorner.Server.Requests
{
    public class GetReviewsFromProduct : IHttpRequest
    {
         public Guid ProductId { get; set; }
         public HttpContext HttpContext { get; set; }
         public IUnitOfWork UnitOfWork { get; set; }
    }
}
