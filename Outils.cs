namespace formationCS
{
    static class Outils
    {
        public static int DemanderNbPositif(string question)
        {
            return NbRange(question, 1, int.MaxValue);
        }
        public static int NbRange(string question, int min, int max)
        {
            int longueurMDP = DemanderNombre(question);
            if (longueurMDP >= min && longueurMDP <= max)
            {
                return longueurMDP;
            }
            Console.WriteLine("ERREUR : le nombre doit être compris entre " + min + " et " + max);
            Console.WriteLine();
            return NbRange(question, min, max);
        }
        public static int DemanderNombre(string question)
        {
            int reponse = 0;
            while (true)
            {
                Console.Write(question);
                try
                {
                    reponse = int.Parse(Console.ReadLine());
                    return reponse;
                }
                catch
                {
                    Console.WriteLine("entrez un chiffre valide !");
                    Console.WriteLine();
                }
            }

        }
    }
}
