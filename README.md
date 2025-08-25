# 🛍️ Event Ease 2

A Blazor WebAssembly e-commerce application showcasing featured products, shopping cart functionality, user login/registration, and local storage persistence.

## 🔧 Features

- 📦 **Product Display**: View featured and all products with name, category, and price.
- 🛒 **Shopping Cart**: Add/remove products to a cart with dynamic item count in the navbar.
- 🔐 **Login/Registration**: Secure login using localStorage (email + username).
- ✅ **User Access Control**: Cart features restricted to logged-in users.
- 💾 **State Persistence**: Cart and login state preserved via browser localStorage.
- 🎨 **Responsive Design**: Custom CSS with clean layout and accessible design.

## 📁 Project Structure

- `Product.cs` – Model class for individual products.
- `ProductCard.razor` – Displays individual product with "Add to Cart" logic.
- `Cart.razor` – Displays and manages shopping cart.
- `Login.razor` – Handles login and registration using localStorage.
- `MainLayout.razor` – Handles layot in nav.
- `NavMenu.razor` – Navigation bar with links and cart icon.
- `Index.razor` – Home page showing featured products.
- `Products.razor` – Page showing all available products.

## 🛠️ Technologies Used

- Blazor WebAssembly (.NET 8)
- C# for components and logic
- HTML/CSS for structure and design
- [Blazored.LocalStorage](https://github.com/Blazored/LocalStorage) for state persistence

## 🚀 How to Run

1. Clone the repository
2. Open in Visual Studio 2022 or later
3. Run the project (`F5` or `Ctrl+F5`)
4. Use the Login page to register and explore features!

## 🎯 Project Requirements Met

- ✅ Custom product and cart classes
- ✅ Blazor components and layout with parameter passing
- ✅ Cart interaction restricted to authenticated users
- ✅ State stored via localStorage
- ✅ Clean, responsive UI with CSS styling

---

## 📄 License

MIT License (or as per your course/project rules).
