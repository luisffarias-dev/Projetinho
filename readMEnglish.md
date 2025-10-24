# 🏋️‍♂️ Projetinho - Workout Application

> **Workout management system** with **Spring Boot API** and **VB.NET Frontend**.
> Allows user registration, automatic workout generation, cardio tracking, and history consultation.

---

## 📋 Table of Contents

* [🎯 About the Project](#-about-the-project)
* [🏗️ Architecture](#️-architecture)
* [⚙️ Features](#️-features)
* [🛠️ Technologies Used](#️-technologies-used)
* [📁 Project Structure](#-project-structure)
* [⚙️ Prerequisites](#️-prerequisites)
* [🚀 Installation and Configuration](#-installation-and-configuration)
* [🧪 Testing](#-testing)
* [🤝 Contribution](#-contribution)
* [📄 License](#-license)
* [👥 Team Members](#-team-members)

---

## 🎯 About the Project

**Projetinho** is a workout application that integrates:

* 👨‍💻 **Backend:** REST API developed in **Spring Boot**
* 🖥️ **Frontend:** **VB.NET** desktop application
* 🗄️ **Database:** persistence of user, workout, and cardio data

The system is designed for gyms or users who want to:

* 👤 Create and manage user registrations
* 🏋️ Automatically generate workout routines (beginner, intermediate, advanced)
* 🫀 Register and track cardio exercises
* 📅 View workout history

---

## 🏗️ Architecture
    ┌──────────────────────┐
    │      VB.NET App      │
    │  (Desktop Frontend)  │
    └─────────▲────────────┘
              │ HTTP/JSON
              ▼
    ┌──────────────────────┐
    │   Spring Boot API    │
    │   (REST Backend)     │
    └─────────▲────────────┘
              │ JPA/Hibernate
              ▼
    ┌──────────────────────┐
    │     Database         │
    │ (MySQL/SQLServer)    │
    └──────────────────────┘

    
---

## ⚙️ Features

* 👤 **User registration**
* 🏋️ **Automatic workout generation** (by level and gender)
* 🫀 **Cardio activity registration** (running, walking, etc.)
* 📅 **Workout history**
* 📊 **Workout query and filtering**
* 🔐 **Authentication and authorization**

---

## 🛠️ Technologies Used

### Backend (API)

* Java 17+
* Spring Boot
* Spring Web
* Spring Data JPA
* Hibernate
* MySQL or PostgreSQL
* Maven

### Frontend (VB.NET)

* VB.NET (.NET Framework or .NET 6+)
* Windows Forms
* HttpClient
* DataGridView

### Infrastructure

* Git & GitHub
* Postman
* Swagger
* sql server management studio 20

---

## 📁 Project Structure
```
Projetinho/
├── 📁 api/Projetinho
│ ├── 📁 src/main/java/com/... # API source code
│ ├── 📁 src/main/resources # Configurations (application.properties)
│ ├── 📄 pom.xml # Maven dependencies
│ └── 📄 README.md # API documentation
│
├── 📁 vb.net/Projetinho
│ ├── 📁 Forms # Application screens
│ ├── 📁 Modules # Global modules and functions
│ ├── 📁 Resources # Images and icons
│ └── 📄 README.md # Frontend documentation
│
├── 📄 TeamMembers.txt # Project team members list
└── 📄 .gitignore
```
---

## ⚙️ Prerequisites

* Java 17+
* Maven 3.8+
* .NET Framework 4.7.2 or .NET 6+
* MySQL or PostgreSQL
* Git

---

## 🚀 Installation and Configuration

### 1. Clone the Repository

```bash
git clone https://github.com/luisffarias-dev/Projetinho.git
cd Projetinho
```
### 2. Configure and Run the API (Spring Boot)
```cd api/Projetinho

# Install dependencies
mvn install

# Configure database
# Edit src/main/resources/application.properties:
# spring.datasource.url=jdbc:mysql://localhost:8080/projetinho
# spring.datasource.username=username
# spring.datasource.password=password

# Run API
mvn spring-boot:run
```
API will be available at: http://localhost:8080

### 3. Configure and Run the Frontend (VB.NET)
* Open the solution in Visual Studio

* Adjust API URL in project global settings

* Compile and run the project (F5)

---
## 🧪 Testing

API Testing: via Postman, Swagger and Insomnia

Interface Testing: manual VB.NET execution

## 🔗 API Endpoints

### Users
| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/users` | List all users |
| `POST` | `/users` | Create a new user |
| `GET` | `/users/{id}` | Get user by ID |
| `PUT` | `/users/{id}` | Update user |
| `DELETE` | `/users/{id}` | Delete user |

### Workouts
| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/workouts` | List all workouts |
| `POST` | `/workouts` | Generate automatic workout |
| `GET` | `/workouts/user/{userId}` | List workouts by user |
| `GET` | `/workouts/{id}` | Get workout by ID |
| `PUT` | `/workouts/{id}` | Update workout |
| `DELETE` | `/workouts/{id}` | Delete workout |

### Cardio
| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/cardio` | List all cardio activities |
| `POST` | `/cardio` | Register cardio activity |
| `GET` | `/cardio/user/{userId}` | List cardio by user |
| `GET` | `/cardio/{id}` | Get cardio activity by ID |
| `PUT` | `/cardio/{id}` | Update cardio activity |
| `DELETE` | `/cardio/{id}` | Delete cardio activity |

### Example Requests

#### Create User
```http
POST /users
Content-Type: application/json

{
  "name": "John Doe",
  "email": "john@email.com",
  "Password": "*******",
}
```
---
## 🖼️ Images

### Application Screenshots


---
## 🤝 Contribution
* Fork or clone the project
```
git clone https://github.com/luisffarias-dev/Projetinho.git
```
* Create a feature branch:
```
git checkout -b feature/NewFeature
```
* Commit your changes:
```
git commit -m "feat: change description"
```
* Push to the repository:
```
git push origin feature/NewFeature
```
* Open a Pull Request
```
https://github.com/luisffarias-dev/Projetinho/pulls
```
---
## 📄 License
This project is distributed under the MIT license.

---
## 👥 Team Members
Luis Fernando França Farias

Douglas Barbosa de Oliveira

Ryan Pereira da Mota

Guilherme Pim

Developed with 💪 and ☕ by the Projetinho team
