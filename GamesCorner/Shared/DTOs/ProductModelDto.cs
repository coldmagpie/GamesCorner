﻿using GamesCorner.Shared.Dtos;

namespace GamesCorner.Shared.DTOs
{
	public class ProductModelDto
	{
		public string Id { get; set; }
		public string Name { get; set; }
        public string BannerUrl { get; set; }
        public string ImageUrl { get; set; }
		public double Price { get; set; }
		public string Category { get; set; }
		public string Description { get; set; }
		public int AgeRestriction { get; set; }
		public bool InStock { get; set; }
		public List<ReviewsDto> Reviews { get; set; }
	}
}
