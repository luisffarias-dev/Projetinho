# 🏋️‍♂️ Projetinho - Aplicativo de Treinos

> **Sistema de gerenciamento de treinos** com **API Spring Boot** e **Frontend VB.NET**.
> Permite cadastro de usuários, geração automática de treinos, acompanhamento de cardio e consulta de histórico.

---

## 📋 Índice

* [🎯 Sobre o Projeto](#-sobre-o-projeto)
* [🏗️ Arquitetura](#️-arquitetura)
* [⚙️ Funcionalidades](#️-funcionalidades)
* [🛠️ Tecnologias Utilizadas](#️-tecnologias-utilizadas)
* [📁 Estrutura do Projeto](#-estrutura-do-projeto)
* [⚙️ Pré-requisitos](#️-pré-requisitos)
* [🚀 Instalação e Configuração](#-instalação-e-configuração)
* [🧪 Testes](#-testes)
* [🔗 Endpoints da API](#-endpoints-da-api)
* [🤝 Contribuição](#-contribuição)
* [📄 Licença](#-licença)
* [👥 Integrantes](#-integrantes)

---

## 🎯 Sobre o Projeto

O **Projetinho** é um aplicativo de treinos que integra:

* 👨‍💻 **Backend:** API REST desenvolvida em **Spring Boot**
* 🖥️ **Frontend:** Aplicação **VB.NET** para desktop
* 🗄️ **Banco de dados:** persistência dos dados de usuários, treinos e cardio

O sistema é voltado para academias ou usuários que desejam:

* 👤 Criar e gerenciar cadastros de usuários
* 🏋️ Gerar automaticamente rotinas de treino (iniciante, intermediário, avançado)
* 🫀 Registrar e acompanhar exercícios de cardio
* 📅 Visualizar histórico de treinos

---

## 🏗️ Arquitetura

```
        ┌──────────────────────┐
        │      VB.NET App      │
        │  (Frontend Desktop)  │
        └─────────▲────────────┘
                  │ HTTP/JSON
                  ▼
        ┌──────────────────────┐
        │   API Spring Boot    │
        │ (Backend REST API)   │
        └─────────▲────────────┘
                  │ JPA/Hibernate
                  ▼
        ┌──────────────────────┐
        │    Banco de Dados    │
        │ (MySQL/SQLServer)   │
        └──────────────────────┘
```

---

## ⚙️ Funcionalidades

* 👤 **Cadastro de usuários**
* 🏋️ **Geração automática de treinos** (por nível e sexo)
* 🫀 **Registro de atividades de cardio** (corrida, caminhada, etc.)
* 📅 **Histórico de treinos**
* 📊 **Consulta e filtro de treinos**
* 🔐 **Autenticação e autorização**

---

## 🛠️ Tecnologias Utilizadas

### Backend (API)

* Java 17+
* Spring Boot
* Spring Web
* Spring Data JPA
* Hibernate
* MySQL ou PostgreSQL
* Maven

### Frontend (VB.NET)

* VB.NET (.NET Framework ou .NET 6+)
* Windows Forms
* HttpClient
* DataGridView

### Infraestrutura

* Git & GitHub
* Postman
* Docker (opcional)
* GitHub Actions (opcional)

---

## 📁 Estrutura do Projeto

```
Projetinho/
├── 📁 api/Projetinho
│   ├── 📁 src/main/java/com/...      # Código fonte da API
│   ├── 📁 src/main/resources         # Configurações (application.properties)
│   ├── 📄 pom.xml                    # Dependências Maven
│   └── 📄 README.md                  # Documentação da API
│
├── 📁 vb.net/Projetinho
│   ├── 📁 Forms                      # Telas da aplicação
│   ├── 📁 Modules                    # Módulos e funções globais
│   ├── 📁 Resources                  # Imagens e ícones
│   └── 📄 README.md                  # Documentação do frontend
│
├── 📄 Integrantes.txt                # Lista de integrantes do projeto
└── 📄 .gitignore
```

---

## ⚙️ Pré-requisitos

* Java 17+
* Maven 3.8+
* .NET Framework 4.7.2 ou .NET 6+
* MySQL ou PostgreSQL
* Git

---

## 🚀 Instalação e Configuração

### 1. Clonar o Repositório

```bash
git clone https://github.com/luisffarias-dev/Projetinho.git
cd Projetinho
```

### 2. Configurar e Executar a API (Spring Boot)

```bash
cd api/Projetinho

# Instalar dependências
mvn install

# Configurar banco de dados
# Editar src/main/resources/application.properties:
# spring.datasource.url=jdbc:mysql://localhost:8080/projetinho
# spring.datasource.username=usuario
# spring.datasource.password=senha

# Rodar API
mvn spring-boot:run
```

A API estará disponível em: `http://localhost:8080`

### 3. Configurar e Executar o Frontend (VB.NET)

1. Abrir a solução no **Visual Studio**
2. Ajustar URL da API nas configurações globais do projeto
3. Compilar e executar o projeto (`F5`)

---

## 🧪 Testes

* Testes de API: via Postman,Swagger e Insomnia
* Testes de interface: execução manual do VB.NET


---

## 🔗 Endpoints da API

| Método | Endpoint  | Descrição                     |
| ------ | --------- | ----------------------------- |
| GET    | /usuarios | Listar todos os usuários      |
| POST   | /usuarios | Criar um novo usuário         |
| GET    | /treinos  | Listar treinos por usuário    |
| POST   | /treinos  | Gerar novo treino automático  |
| GET    | /cardio   | Listar atividades de cardio   |
| POST   | /cardio   | Registrar atividade de cardio |

---

## 🤝 Contribuição

1. Faça um fork do projeto
2. Crie uma branch para sua feature:

```bash
git checkout -b feature/NovaFuncionalidade
```

3. Commit suas mudanças:

```bash
git commit -m "feat: descrição da mudança"
```

4. Envie para o repositório:

```bash
git push origin feature/NovaFuncionalidade
```

5. Abra um Pull Request

---

## 📄 Licença

Este projeto é distribuído sob a licença **MIT**.

---

## 👥 Integrantes

* Luis Fernando França Farias
* Douglas Barbosa de Oliveira
* Ryan Pereira da Mota
* Guilherme Pim

*Desenvolvido com 💪 e ☕ pela equipe Projetinho*
