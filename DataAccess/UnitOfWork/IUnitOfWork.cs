﻿using DataAccess.Repositories.Interfaces;

namespace DataAccess.UnitOfWork;

public interface IUnitOfWork
{
	public Task<int> Save();

	public void Dispose();
	public IProductRepository ProductRepository { get; }
	public IOrderRepository OrderRepository { get; }
	public IEventRepository EventRepository { get; }
    public IReviewRepository ReviewRepository { get; }
	public IInterestedUserEventRepository InterestedUserEventRepository { get; }

}