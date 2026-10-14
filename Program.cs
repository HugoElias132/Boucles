namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        
        // Etape 1 : faire un compteur qui va de 1 à 10
        int compteur = 0;

        while (compteur < 10)
        {
            compteur++;
            Console.WriteLine(compteur);
        }

        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"
        int decompteur = 6;

        while (decompteur > 1)
        {
            decompteur--;
            Console.WriteLine(decompteur);
        }

        Console.WriteLine("Bonne année!");
        // Etape 3 : faire un compteur qui va de -4 à 2
        int decompte = -5;

        while (decompte < 2)
        {
            decompte++;
            Console.WriteLine(decompte);
        }

        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15
        for (int i = 0; i <= 15; i += 2)
        {
            Console.WriteLine(i);
        }

        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"
        string answer = "";
        do
        {
            Console.WriteLine("voulez-vous sortir de ce programmme?");
            answer = Console.ReadLine();
        } while (answer != "oui");

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}