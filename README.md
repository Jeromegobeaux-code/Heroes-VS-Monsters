# Heroes VS Monsters
 
Un jeu d'aventure en console, écrit en C# (.NET 8).
 
> **Contexte :** ce projet est l'exercice final de mon initiation à la programmation. Il rassemble les notions vues durant la formation (POO, héritage, classes abstraites, encapsulation, structures de contrôle, collections...) dans un mini-jeu jouable.
 
## Pitch
 
Vous incarnez un héros lâché dans la forêt de Cèverissi, une grille de 15x15 cases peuplée de monstres. Le but : explorer la carte, affronter les monstres croisés en chemin, gagner de l'or, du cuir et de l'expérience, et éliminer toutes les créatures pour remporter la victoire — sans tomber à 0 PV avant.
 
## Fonctionnalités
 
- **Création de personnage** : choix d'un nom et d'une classe de héros parmi 4 (Humain, Nain, Elfe, Mage), chacune avec ses propres bonus et mécaniques de combat.
- **Statistiques aléatoires** : Force et Endurance sont générées en lançant 4 dés à 6 faces et en gardant les 3 meilleurs résultats.
- **Déplacement sur une grille** : navigation aux flèches directionnelles sur un plateau 15x15, avec un système de « jetons » affichant le héros et les monstres.
- **Système de combat au tour par tour** : le combat se déclenche automatiquement quand le héros se retrouve sur la même case qu'un monstre. Chaque classe attaque différemment (attaque simple, double attaque, sort à charges...).
- **Monstres variés** : Loups, Orcs et Dragons, chacun avec ses propres butins (or, cuir) et récompenses en expérience.
- **Progression du personnage** : gain d'XP après chaque victoire, passage de niveau et amélioration au choix d'une statistique (Force ou Endurance).
- **Interface console illustrée** : ASCII art pour l'écran-titre, les monstres rencontrés, la victoire et le game over.
## Les classes de héros
 
| Classe | Particularité |
|---|---|
| **Humain** | Profil équilibré, bonus de base en Force et Endurance |
| **Nain** | Gros bonus d'Endurance, encaisse mieux les coups |
| **Elfe** | Inflige moins de dégâts par coup, mais attaque deux fois par tour |
| **Mage** | Charge sa mana sur plusieurs tours pour lancer des sorts de plus en plus dévastateurs (jusqu'à l'Inferno) |
 
## Les monstres
 
- **Loup** : rôdeur des bois, laisse du cuir.
- **Orc** : combattant robuste, laisse de l'or.
- **Dragon** : le plus coriace, laisse à la fois or et cuir en bonne quantité.
## Commandes
 
- **Flèches directionnelles** (↑ ↓ ← →) : déplacer le héros sur la grille.
- Le combat se lance automatiquement au contact d'un monstre ; suivez ensuite les instructions affichées à l'écran (choix d'action, appui sur une touche pour enchaîner les tours).
## Prérequis
 
- [.NET SDK 8.0](https://dotnet.microsoft.com/download) ou supérieur.
## Lancer le jeu
 
Depuis le dossier du projet (celui contenant le fichier `.csproj`) :
 
```bash
dotnet run
```
 
Ou en ouvrant la solution `Heroes VS Monsters.sln` dans Visual Studio et en lançant l'exécution (F5).
 
## Structure du projet
 
```
Heroes VS Monsters/
├── Program.cs                  # Point d'entrée et boucle de jeu principale
├── Classes/
│   ├── Characters.cs           # Classe abstraite de base (Force, Endurance, PV...)
│   ├── Heroes.cs                # Classe abstraite héros (niveau, XP, montée de niveau)
│   ├── Human.cs / Dwarf.cs / Elf.cs / Magus.cs   # Classes de héros jouables
│   ├── Monsters.cs              # Classe abstraite monstre
│   ├── Wolf.cs / Orc.cs / Dragon.cs              # Types de monstres
│   └── dice.cs                  # Simulation de lancers de dés
└── Utils/
    ├── CharactersSystem.cs      # Création du héros et attribution des statistiques
    ├── GridSystem.cs             # Affichage de la grille de jeu et des stats
    ├── MouvementsSystem.cs       # Gestion des déplacements
    ├── MonstersManagement.cs     # Génération et placement des monstres
    ├── BattleSystem.cs           # Logique de combat
    └── GameLoop.cs                # Écrans titre, victoire et game over
```
 
## Pistes d'amélioration
 
Le code contient encore quelques TODO et idées notées durant le développement, notamment :
- Éviter de rafraîchir toute la console à chaque déplacement (utiliser `Console.SetCursorPosition` pour ne redessiner que le pion du joueur).
- Ajouter des capacités spéciales pour l'Humain et le Nain (prévues mais pas encore implémentées).
- Revoir le système de spawn des monstres pour gérer le cas où le héros se retrouve au contact de plusieurs monstres en même temps.
## Auteur
 
JGobeaux — projet réalisé dans le cadre d'une initiation à la programmation.
