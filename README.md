# Exercise 2 - Reusable Form Component

A Blazor Server application demonstrating a reusable `UserForm` component that collects user information and can be integrated into different pages.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Any modern browser (Chrome, Edge, Firefox)

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/DataQuire/Exercise2.git
cd Exercise2
```

### 2. Run the application

```bash
dotnet run
```

### 3. Navigate to the form

Open your browser and go to: https://localhost:<port>/test-form


## Project Structure
Exercise2/
├── Components/
│   ├── Layout/
│   │   └── MainLayout.razor        # App layout
│   ├── Pages/
│   │   └── TestForm.razor          # Sample page demonstrating the component
│   ├── App.razor
│   ├── Routes.razor
│   ├── _Imports.razor
│   └── UserForm.razor              # Reusable form component
├── Models/
│   └── UserModel.cs                # Form model with DataAnnotations
├── Services/
│   ├── IEmailUniquenessService.cs  # Email uniqueness interface
│   └── MockEmailUniquenessService.cs # Mocked email uniqueness service
├── wwwroot/
│   └── app.css                     # Custom styles
└── Program.cs

## Features

- **Reusable form component** — `UserForm.razor` accepts a model and exposes a submit event via `EventCallback`
- **Create and Edit modes** — Create new users or select an existing user from a grid to edit
- **Validation** — DataAnnotations validation with per-field messages and a validation summary
- **Async email uniqueness check** — Simulates a database check before allowing submission
- **Duplicate submission prevention** — Submit button is disabled while processing
- **No model mutation** — The component always works on a clone of the original model
- **Manual field binding** — The `Name` field handles value and change events manually without `@bind`
- **Customizable submit button text** — Parent controls the button label

## How to Use the Form

1. Navigate to `/test-form`
2. Fill in the form fields and click **Create User**
3. The submitted data will appear as a notification in the top left
4. Switch to **Edit mode** to see the grid of submitted users
5. Click **Edit** on any row to modify that user's data
6. Click **Save Changes** to update

## Testing Email Uniqueness

The following emails are pre-blocked to demonstrate the async uniqueness check:

- `taken@example.com`
- `admin@example.com`

Any email you successfully submit will also be blocked for the duration of the session.

## Assumptions and Notes

- The application uses **Blazor Server** with `@rendermode InteractiveServer` for full interactivity
- The email uniqueness service is mocked — in a real application this would query a database
- Submitted user data is stored **in-memory** and resets when the application restarts
- Bootstrap 5 is loaded via CDN — an internet connection is required to load styles
- The `Name` field intentionally does not use `@bind` to demonstrate manual event handling as required by the exercise

## Built With

- [.NET 8](https://dotnet.microsoft.com/)
- [Blazor Server](https://learn.microsoft.com/en-us/aspnet/core/blazor/)
- [Bootstrap 5](https://getbootstrap.com/)
