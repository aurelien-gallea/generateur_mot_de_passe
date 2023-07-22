using formationCS;

namespace generateur_mot_de_passe
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int longueur = Outils.DemanderNbPositif("Longueur du mot de passe : ");
            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caracteresSpeciaux = "#&+-@^_";
            string alphabet = "";
            int choix = 0;


            while (choix < 1 || choix > 4)
            {
                choix = Outils.NbRange("Vous voulez un mot de passe avec : " +
                    "\n1 - Uniquement des caractères en minuscules" +
                    "\n2 - Des caractères minuscules et majuscules" +
                    "\n3 - Des caractères et des chiffres" +
                    "\n4 - Caractères, chiffres et caractères spéciaux" +
                    "\nVotre choix : ", 1, 4);
            }

            switch (choix)
            {
                case 1:
                    alphabet = minuscules;
                    break;
                case 2:
                    alphabet = minuscules + majuscules;
                    break;
                case 3:
                    alphabet = minuscules + majuscules + chiffres;
                    break;
                case 4:
                    alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;
                    break;
                default:
                    break;
            }

            Random rand = new Random();
            const int NB_MDP = 10;

            for (int i = 0; i < NB_MDP; i++)
            {
                string motDePasse = "";


                for (int j = 0; j < longueur; j++)
                {
                    int indexAleatoire = rand.Next(0, alphabet.Length);
                    char lettreAleatoire = alphabet[indexAleatoire];
                    motDePasse += lettreAleatoire;
                }
                Console.WriteLine("mot de passe : " + motDePasse);
            }
        }
    }
}