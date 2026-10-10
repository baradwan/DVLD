# DVLD – Driving & Vehicle License Department System

A desktop management system built with **C# and .NET Framework** to simulate the core operations of a Driving & Vehicle License Department.

The project was developed to practice building a structured, database-driven application using a **3-Layer Architecture**, SQL Server, ADO.NET, reusable UI components, validation, and separation of responsibilities.

---

## 🚀 Features

### 👤 People Management

* Add and update people
* Search and filter people
* View detailed personal information
* Store contact, nationality, and identification information
* Reusable person information controls

### 🔐 User Management

* Create and update system users
* Link users to people records
* Activate/deactivate users
* User login
* Change password functionality
* Account information management
* Remember Me functionality

### 📋 Application Management

* Manage application types
* Configure application fees
* Create and manage driving-license applications
* Track application information and status

### 🚗 Local Driving License Applications

* Create local driving license applications
* Select license classes
* Search and filter applications
* View application details
* Update and delete applications
* Application lifecycle management

### 📝 Test Management

* Manage test types
* Configure test titles, descriptions, and fees
* Foundation for driving-test workflows

### 🪪 License Domain

* License-class management
* License data models
* Driver and license-related business logic
* Support for multiple driving-license service types

---

## 🏗️ Architecture

The application follows a **3-Layer Architecture** to separate user-interface, business, and database responsibilities.

```text
┌──────────────────────────────┐
│      Presentation Layer      │
│     Windows Forms / UI       │
└──────────────┬───────────────┘
               │
               ▼
┌──────────────────────────────┐
│       Business Layer         │
│ Business Rules & Validation  │
└──────────────┬───────────────┘
               │
               ▼
┌──────────────────────────────┐
│      Data Access Layer       │
│       ADO.NET / SQL          │
└──────────────┬───────────────┘
               │
               ▼
┌──────────────────────────────┐
│          SQL Server          │
└──────────────────────────────┘
```

This structure keeps database access separate from business logic and UI code.

---

## 🛠️ Technology Stack

| Technology           | Usage                     |
| -------------------- | ------------------------- |
| C#                   | Main programming language |
| .NET Framework 4.7.2 | Application platform      |
| Windows Forms        | Desktop user interface    |
| SQL Server           | Relational database       |
| ADO.NET              | Database access           |
| Syncfusion WinForms  | UI components             |
| Git & GitHub         | Version control           |
| Visual Studio        | Development environment   |

---

## 📂 Project Structure

```text
DVLD/
│
├── DVLD/
│   ├── Applications/
│   ├── Login/
│   ├── Main/
│   ├── People/
│   ├── Tests/
│   └── Users/
│
├── DVLD_BusinessLayer/
│   └── Business rules and application logic
│
├── DVLD_AccessLayer/
│   └── SQL Server and ADO.NET data access
│
├── DVLD_Global/
│   ├── DTOs/
│   ├── Events/
│   ├── Validation
│   └── Shared utilities
│
├── TESTING/
│   └── Development/testing utilities
│
├── Resources/
│
└── DVLD.slnx
```

---

## 💾 Data Access

The Data Access Layer communicates directly with SQL Server using **ADO.NET**.

The project uses:

* `SqlConnection`
* `SqlCommand`
* `SqlDataReader`
* `DataTable`
* Parameterized SQL commands
* DTOs for transferring data between layers

Example application flow:

```text
User Interface
      ↓
Business Layer
      ↓
DTO
      ↓
Data Access Layer
      ↓
SQL Server
```

---

## 🧠 Engineering Concepts Practiced

This project helped me practice:

* Layered software architecture
* Separation of concerns
* Object-oriented programming
* Business-rule implementation
* CRUD operations
* Relational database design
* SQL queries
* Parameterized database commands
* DTO pattern
* Input validation
* Reusable Windows Forms controls
* Event-driven programming
* Authentication workflows
* Git-based version control
* Refactoring a growing application

---

## 📸 Screenshots

> Screenshots will be added here to demonstrate the main application workflows.

### Login

`docs/screenshots/login.png`

### Main Dashboard

`docs/screenshots/dashboard.png`

### People Management

`docs/screenshots/people-management.png`

### User Management

`docs/screenshots/user-management.png`

### Driving License Applications

`docs/screenshots/driving-license-applications.png`

---

## ⚙️ Getting Started

### Requirements

* Windows
* Visual Studio
* .NET Framework 4.7.2
* SQL Server

### Setup

1. Clone the repository.

```bash
git clone https://github.com/baradwan/DVLD.git
```

2. Open the solution in Visual Studio.

3. Configure your SQL Server database.

4. Configure the database connection locally.

5. Build and run the application.

> Database credentials should never be committed to source control. Configure your local environment with your own SQL Server credentials.

---

## 🔒 Security

This repository is intended as a learning and portfolio project.

Sensitive configuration such as database passwords and local credentials should be stored outside source control.

Future security improvements include:

* Secure password hashing
* Externalized database configuration
* Improved authentication handling
* Role-based authorization

---

## 🗺️ Future Improvements

Planned improvements include:

* Complete remaining license workflows
* Improve authentication security
* Add password hashing
* Move configuration outside source code
* Add automated tests
* Improve error handling and logging
* Add database setup scripts
* Continue refactoring reusable components
* Explore migration of the backend to ASP.NET Core Web API

---

## 👨‍💻 Author

**Ahmed Baredhwan**

Software Engineering Student focused on backend development, software architecture, and building reliable software systems.

---

## 📌 Project Purpose

DVLD was built as a learning project to move beyond small programming exercises and practice developing a larger application with multiple modules, persistent data, business rules, reusable components, and a structured architecture.
