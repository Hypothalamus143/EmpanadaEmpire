# 🥐 Empanada Empire

> *"Happiness, by the handful. Baked with a little extra love."*

**Empanada Empire** is a modern, responsive web application for an artisanal empanada bakery based in Cebu City, Philippines. Built with **.NET Blazor** and **Tailwind CSS v4**, the app provides a warm, tactile digital ordering experience for daily fresh *merienda* delivery.

---

## ✨ Features

- **Artisanal Menu Catalog:** Filter by categories (*Savory favorites, Sweet treats, Vegetarian*), live search by filling keywords, and view signature badges (*Bestseller, Crowd Favorite, A Little Heat*).
- **Interactive Bag & Live Sticky Bar:** Add to cart with real-time quantity steppers (`+` / `–`) and an interactive floating bag summary with reactive price recalculations.
- **Localized Cebu City Delivery:** Built specifically for Cebu City deliveries, featuring pre-configured barangay selectors, local landmark tagging, and flat delivery rates.
- **Two-Step Registration:** Clean onboarding divided into personal details and address credentials with locked regional scopes and instant validation.
- **Split-Screen Bakery Login:** Editorial-style, food-photography login experience with password visibility toggles and direct bakery navigation.
- **Tailwind CSS v4 (CSS-First):** Configured entirely using the new CSS `@theme` specification without relying on legacy `tailwind.config.js` files.

---

## 🛠️ Tech Stack

- **Framework:** [.NET 8 / .NET 9 Blazor Web App](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) (Interactive Server Components)
- **Styling:** [Tailwind CSS v4](https://tailwindcss.com/)
- **Typography:**
  - Headings: `Playfair Display` (Warm Serif)
  - Body: `Plus Jakarta Sans` / `Inter` (Sans)
- **Icons:** Heroicons / Inline SVG
- **Language:** C# 12 / 13

---

## 📁 Project Structure

```text
EmpanadaEmpire/
├── Models/
│   ├── Auth/
│   │   ├── LoginModel.cs           # User credentials & remember me
│   │   ├── RegisterModel.cs        # Two-step registration & address DTO
│   │   └── UserProfile.cs          # User identity & header avatar initials
│   ├── Cart/
│   │   ├── CartItem.cs             # Item calculations & product mappings
│   │   └── ShoppingCart.cs         # Cart state, pieces count & subtotals
│   ├── Catalog/
│   │   └── Product.cs              # Product entity & price formatting
│   ├── Enums/
│   │   ├── OrderStatus.cs          # Bakery order lifecycle
│   │   ├── ProductBadge.cs         # UI pills (Bestseller, Heat, etc.)
│   │   └── ProductCategory.cs      # Menu filtering taxonomy
│   ├── Location/
│   │   └── DeliveryAddress.cs      # Cebu City address binding model
│   └── Orders/
│       ├── Order.cs                # Order entity with snapshot totals
│       └── OrderItem.cs            # Order line items
├── Pages/
│   ├── Login.razor                 # Split-screen bakery login
│   ├── Register.razor              # Two-step account & address creation
│   ├── Menu.razor                  # Catalog dashboard & sticky cart bar
│   └── Cart.razor                  # Full order breakdown & checkout preview
└── wwwroot/
    ├── app.css                     # Tailwind v4 import & @theme font tokens
    └── images/
        └── products/               # Local empanada photography (.webp / .jpg)