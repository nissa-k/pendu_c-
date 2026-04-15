# Jeu du Pendu (C#)

Petit projet en C# qui implémente le jeu classique du **pendu** en console.

Le joueur doit deviner un mot en proposant des lettres une par une.  
Chaque mauvaise lettre fait perdre une vie.

---

## Fonctionnalités

- Choix aléatoire d’un mot
- Système de vies
- Affichage du mot caché
- Liste des lettres déjà utilisées
- Vérification des entrées utilisateur
- Messages de victoire ou de défaite

---

## Structure du projet


pendu_c-
│
├── Program.cs # Point d'entrée du programme
├── Jeu.cs # Logique principale du jeu
├── Utils.cs # Fonctions utilitaires (validation, vérification des lettres)
├── pendu.csproj # Configuration du projet .NET
└── README.md


### Description des fichiers

**Program.cs**

Contient la fonction `Main()` qui lance le jeu.

**Jeu.cs**

Contient la classe principale `Jeu` qui gère :

- l'initialisation
- la boucle du jeu
- l'affichage de l'état
- la gestion des vies
- la fin de partie

**Utils.cs**

Contient des méthodes utilitaires :

- demander une lettre au joueur
- vérifier si la lettre est dans le mot

---

## Installation

### Prérequis

- .NET SDK installé (version récente)

Vérifier avec :


dotnet --version


---

## Lancer le projet

Dans le dossier du projet :


dotnet run


---

## Exemple de jeu


******** Jeu du pendu ********

Mot : _ _ _ _ _ _ _
Vies restantes : 5
Lettres testées :

Propose une lettre : a
Bonne lettre !

Mot : _ a _ _ _ _ _


---

## Améliorations possibles

- Ajouter un dessin du pendu (ASCII)
- Ajouter plusieurs niveaux de difficulté
- Charger les mots depuis un fichier
- Ajouter un mode multijoueur
- Ajouter un système de score

---

## Auteur 
Safaa zemmar 
Nissa karadag
