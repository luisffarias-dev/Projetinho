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
* [🔗 API Endpoints](#-api-endpoints)
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
* Docker (optional)
* GitHub Actions (optional)

---

## 📁 Project Structure
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
API will be available at: http://localhost:8080

3. Configure and Run the Frontend (VB.NET)
Open the solution in Visual Studio

Adjust API URL in project global settings

Compile and run the project (F5)


🧪 Testing
API Testing: via Postman, Swagger and Insomnia

Interface Testing: manual VB.NET execution

🔗 API Endpoints
Method	Endpoint	Description
GET	/users	List all users
POST	/users	Create a new user
GET	/workouts	List workouts by user
POST	/workouts	Generate new automatic workout
GET	/cardio	List cardio activities
POST	/cardio	Register cardio activity
🤝 Contribution
Fork the project

Create a feature branch:
git checkout -b feature/NewFeature

Commit your changes:
git commit -m "feat: change description"

Push to the repository:
git push origin feature/NewFeature

Open a Pull Request

📄 License
This project is distributed under the MIT license.

👥 Team Members
Luis Fernando França Farias

Douglas Barbosa de Oliveira

Ryan Pereira da Mota

Guilherme Pim

Developed with 💪 and ☕ by the Projetinho team
