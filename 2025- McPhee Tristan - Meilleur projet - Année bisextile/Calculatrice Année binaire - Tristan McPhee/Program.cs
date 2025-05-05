using System;

class Program
{
    static void Main()
    {
        Console.Write("Entrez une année au prochain 10 secondes sinon l'ordi explose! : ");
        if (int.TryParse(Console.ReadLine(), out int annee))
        {
            if ((annee % 4 == 0 && annee % 100 != 0) || (annee % 400 == 0))
            {
                Console.WriteLine($"Bravooo! L'année {annee} est une année bissextile.T'a juste devinée n'est-ce pas ? ;)");
            }
            else
            {
                Console.WriteLine($"Heille! l'année {annee} n'est pas une année bissextile. Pourquoi tu fait pas juste le calcul toi même!");
            }
        }
        else
        {
            Console.WriteLine("Allez... ce n'est pas une année valide ça.");
        }
    }
}
