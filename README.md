# Jeu du Pendu – C#

## Description

Ce projet est une implémentation du **jeu du pendu** en **C# dans la console**.
Le joueur doit deviner un mot aléatoire en proposant des lettres une par une.

À chaque mauvaise lettre, une partie du pendu apparaît en **ASCII**.
Le joueur perd lorsqu'il n'a plus de vies.

---

## Fonctionnalités

* Sélection aléatoire d’un mot
* Saisie d’une lettre par le joueur
* Vérification des lettres proposées
* Affichage du mot caché
* Affichage des lettres déjà utilisées
* Gestion des vies
* Dessin du pendu en ASCII
* Message de victoire ou de défaite

---

## Structure du projet

```
pendu_c-
│
├── Program.cs
├── Jeu.cs
├── Utils.cs
├── pendu.csproj
└── README.md
```

### Description des fichiers

**Program.cs**

Contient le point d'entrée du programme (`Main`) qui lance le jeu.

**Jeu.cs**

Contient la logique principale du jeu :

* choix du mot
* boucle du jeu
* gestion des vies
* affichage de l'état du jeu
* affichage du pendu ASCII

**Utils.cs**

Contient les fonctions utilitaires :

* demander une lettre au joueur
* vérifier si une lettre est dans le mot

---

## Installation

### Prérequis

Installer **.NET SDK**

Vérifier avec :

```
dotnet --version
```

---

## Lancer le projet

Dans le dossier du projet :

```
dotnet run
```

---

## Exemple de jeu

```
====================
Jeu du pendu
====================

Mot : _ _ _ _ _ _
Vies restantes : 6
Lettres testées :

Etat du pendu :

  +---+
  |   |
      |
      |
      |
      |
=========
```

---

## Auteur
Safaa Zemmar 
Nissa Karzadag 
