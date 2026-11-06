# WebAppMMS

Application web de gestion de supermarché développée avec **ASP.NET Core MVC**.

Le projet constitue la base d'une application permettant de gérer les éléments d'un supermarché, notamment les catégories de produits. Il utilise des contrôleurs C#, des modèles et des vues Razor (`.cshtml`).

## Technologies utilisées

- .NET 10
- ASP.NET Core MVC
- C#
- Razor Views

## Prérequis

- Installer le SDK .NET 10 : [dotnet.microsoft.com](https://dotnet.microsoft.com/download)
- Vérifier l'installation :

```bash
dotnet --version
```

## Installation et lancement

Depuis la racine du dépôt :

```bash
cd WebAppMMS
dotnet restore
dotnet run
```

L'application affiche ensuite l'adresse locale dans le terminal. Ouvrir cette adresse dans un navigateur, par exemple :

```text
https://localhost:xxxx
```

Pour arrêter l'application, appuyer sur `Ctrl+C`.

## Fonctionnalités actuelles

- Page d'accueil.
- Consultation de la page des catégories.
- Ouverture de la page d'édition d'une catégorie à partir d'un identifiant.
- Modèle `Category` contenant un identifiant, un nom et une description.

> L'enregistrement en base de données et la persistance des catégories restent à implémenter.

## Routes principales

| URL | Description |
|---|---|
| `/` | Page d'accueil |
| `/Categories` | Liste des catégories |
| `/Categories/Edit` | Édition d'une nouvelle catégorie |
| `/Categories/Edit/5` | Édition de la catégorie ayant l'identifiant `5` |

Les routes sont configurées dans `WebAppMMS/Program.cs` avec le modèle MVC suivant :

```text
{controller=Home}/{action=Index}/{id?}
```

## Structure du projet

```text
WebAppMMS/
├── Controllers/
│   ├── CategoriesController.cs
│   └── HomeController.cs
├── Models/
│   └── Category.cs
├── Views/
│   ├── Categories/
│   │   ├── Edit.cshtml
│   │   └── Index.cshtml
│   └── Home/
│       └── Index.cshtml
├── Program.cs
└── WebAppMMS.csproj
```

## Évolutions prévues

- Ajouter une base de données avec Entity Framework Core.
- Implémenter les opérations CRUD complètes sur les catégories.
- Ajouter la gestion des produits, des stocks et des ventes.
- Ajouter la validation des formulaires et la gestion des utilisateurs.
