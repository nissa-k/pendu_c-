using System;
using System.Collections.Generic;

class Utils
{
    // Demande une lettre au joueur, vérifie la validité et retourne la lettre
    public static char DemanderLettre(List<char> lettresTestees)
    {
        while (true)
        {
            Console.Write("\nPropose une lettre : ");
            string input = Console.ReadLine().ToLower();

            if (input.Length != 1)
            {
                Console.WriteLine("Entre UNE seule lettre !");
                continue;
            }

            char lettre = input[0];

            // Vérifie que l'entrée est une lettre et n'a pas déjà été testée
            if (!char.IsLetter(lettre))
            {
                Console.WriteLine("Les chiffres et symboles sont interdits !");
                continue;
            }

            // Vérifie que la lettre n'a pas déjà été testée
            if (lettresTestees.Contains(lettre))
            {
                Console.WriteLine("Lettre déjà utilisée !");
                continue;
            }

            return lettre;
        }
    }

    // Vérifie si la lettre proposée est dans le mot secret et met à jour le mot caché
    public static bool VerifierLettre(string motSecret, char[] motCache, char lettre)
    {
        bool bonneLettre = false;

        // Parcourt le mot secret pour trouver les occurrences de la lettre proposée
        for (int i = 0; i < motSecret.Length; i++)
        {
            if (motSecret[i] == lettre)
            {
                motCache[i] = lettre;
                bonneLettre = true;
            }
        }

        return bonneLettre;
    }
}