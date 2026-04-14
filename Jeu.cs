using System;
using System.Collections.Generic;

class Jeu
{
    // Liste de mots pour le jeu
    private string[] mots = {
        "ordinateur", "programmation", "developpeur",
        "nissa", "safaa", "clavier", "souris",
        "ecran", "internet", "logiciel", "ynov",
        "riot", "marseille", "football", "basketball",
        "tennis", "voiture", "avion", "bateau",
        "montagne", "plage"
    };

    // Variables de jeu
    private string motSecret;
    private char[] motCache;
    private int vies = 5;

    // Liste dynamique pour stocker les lettres déjà testées
    private List<char> lettresTestees = new List<char>();

    public void Lancer()
    {
        InitialiserJeu();

        Console.WriteLine("******** Jeu du pendu ********");

        // Variable pour suivre si le joueur a gagné
        bool gagne = false;

        // Boucle principale du jeu tant que le joueur a des vies et n'a pas gagné
        while (vies > 0 && !gagne)
        {
            // Afficher l'état actuel du jeu
            AfficherEtat();

            // Demander une lettre au joueur et vérifier si elle est dans le mot secret
            char lettre = Utils.DemanderLettre(lettresTestees);
            lettresTestees.Add(lettre);

            if (Utils.VerifierLettre(motSecret, motCache, lettre))
            {
                Console.WriteLine("Bonne lettre !");
            }
            else
            {
                vies--;
                Console.WriteLine("Mauvaise lettre !");
            }

            gagne = !new string(motCache).Contains('_');
        }

        FinDeJeu(gagne);
    }

    // Méthodes privées pour gérer l'initialisation, l'affichage et la fin du jeu
    private void InitialiserJeu()
    {
        Random rand = new Random();
        motSecret = mots[rand.Next(mots.Length)];
        motCache = new string('_', motSecret.Length).ToCharArray();
    }

    // Affiche le mot caché, les vies restantes et les lettres testées
    private void AfficherEtat()
    {
        // Affiche le mot caché avec des espaces entre les lettres
        Console.WriteLine("\nMot : " + string.Join(" ", motCache));
        Console.WriteLine("Vies restantes : " + vies);
        Console.WriteLine("Lettres testées : " + string.Join(", ", lettresTestees));
    }

    // Affiche le message de fin de jeu en fonction du résultat
    private void FinDeJeu(bool gagne)
    {
        if (gagne)
        {
            Console.WriteLine("\nBravo ! Tu as trouvé le mot : " + motSecret);
        }
        else
        {
            Console.WriteLine("\nPerdu ! Le mot était : " + motSecret);
        }
    }
}