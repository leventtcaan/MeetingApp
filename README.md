# MeetingApp 🚀

## Overview
MeetingApp is a streamlined **ASP.NET Core 8.0 MVC** application built to practice core web development principles. Rather than focusing on complex database persistence, this project dives deep into the "heart" of MVC: Model Binding, form validations, and the Repository design pattern. It serves as a transparent reference for technical interviews and concept reinforcement.

## Key Features & Learning Outcomes
* **Model Binding & HTTP Verbs:** Implementation of strongly-typed data transfer between HTML forms (POST) and C# objects.
* **In-Memory Repository Pattern:** Demonstration of data encapsulation using a static list to handle CRUD operations (Create & Read) within the application lifecycle.
* **Data Annotations & Server-Side Validation:** Enhancing security and UX by enforcing rules on user input using `ModelState.IsValid`.
* **Tag Helpers:** Utilizing `asp-for`, `asp-controller`, and `asp-validation-summary` for clean, readable Razor views.
* **Dynamic Routing:** Handling participant details via `/Meeting/Details/{id}` with built-in protection against invalid entity IDs.
* **Clean Repository Management:** Strategic use of **Libman (Library Manager)** to keep the repository lightweight by excluding `wwwroot/lib` from version control.

## Technologies Used
* .NET Core 8.0 (ASP.NET Core MVC)
* C# (LINQ, OOP, Encapsulation)
* Bootstrap 5 (via Libman)
* Git & GitHub

## Getting Started

### Prerequisites
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Installation
1. **Clone the repository:**
   ```bash
   git clone [https://github.com/leventtcaan/MeetingApp.git](https://github.com/leventtcaan/MeetingApp.git)
   cd MeetingApp