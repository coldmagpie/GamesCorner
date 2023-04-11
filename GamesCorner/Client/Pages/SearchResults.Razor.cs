﻿using System.Net.Http.Json;
using GamesCorner.Shared.DTOs;
using Microsoft.AspNetCore.Components;

namespace GamesCorner.Client.Pages
{
	partial class SearchResults : ComponentBase
	{
		[Parameter] public string SearchTerm { get; set; } = "";

		private List<ProductModelDto>? _products = new();
		private List<ProductModelDto>? _filteredProducts = new();
		public List<string> categories = new();



		protected override async Task OnParametersSetAsync()
		{
			await Search();
			await base.OnParametersSetAsync();
		}

		private async Task Search()
		{

			var client = HttpClientFactory.CreateClient("public");

			var response = await client.GetAsync($"search?name={SearchTerm}");

			if (response.IsSuccessStatusCode)
			{
				_filteredProducts = await response.Content.ReadFromJsonAsync<List<ProductModelDto>>();
			}
			StateHasChanged();

		}

		private void FilterResultsByCategory(ChangeEventArgs obj)
		{

			var category = obj.Value;
			if (category is not null)
			{
				_filteredProducts = _products.Where(x => x.Category == category.ToString()).ToList();
			}

			StateHasChanged();
		}

		protected override async Task OnInitializedAsync()
		{
			await GetAllProducts();
			await base.OnInitializedAsync();
		}

		private async Task GetAllProducts()
		{
			var client = HttpClientFactory.CreateClient("public");

			var response = await client.GetAsync($"search?name={""}");

			if (response.IsSuccessStatusCode)
			{
				_products = await response.Content.ReadFromJsonAsync<List<ProductModelDto>>();
			}

			categories = _products.Select(x => x.Category).Distinct().ToList();
			StateHasChanged();
		}
	}
}
