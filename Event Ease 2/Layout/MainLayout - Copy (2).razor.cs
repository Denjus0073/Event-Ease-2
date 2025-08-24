using Microsoft.AspNetCore.Components;
using Blazored.LocalStorage;
using Event_Ease_2.Models;
using System.Collections.Generic;

namespace Event_Ease_2.Layout
{
    public partial class MainLayout : LayoutComponentBase
    {
        [Inject] public ILocalStorageService? LocalStorage { get; set; }
        public List<Product> CartItems { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            var items = await LocalStorage!.GetItemAsync<List<Product>>("cartItems");
            CartItems = items ?? new();
        }
    }
}
