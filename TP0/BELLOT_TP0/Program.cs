using System;
using System.Linq;

namespace BELLOT_TP0
{
    internal class Program
    {
        public static string FormatageNomPrenom(string nom, string prenom)
        {
            return nom.ToUpper() + " " + prenom.Substring(0,1).ToUpper() + prenom.Substring(1);
        }

        public static float CalculImc(float poids, int taille)
        {
            float tailleEnMetres = (float)taille / 100;
            float imc = poids / (tailleEnMetres * tailleEnMetres);
            return imc;
        }

        public static void CommenteImc(float imc)
        {
            const string msgImcA = "Attention à l'anorexie !";
            const string msgImcB = "Vous êtes un peu maigrichon";
            const string msgImcC = "Vous êtes de corpulence normale";
            const string msgImcD = "Vous êtes en surpoids !";
            const string msgImcE = "Obésité modérée !";
            const string msgImcF = "Obésité sévère !";
            const string msgImcG = "Obésité morbide";
            
            if (imc < 16.5)
                Console.WriteLine(msgImcA);
            else if (imc >= 16.5 && imc < 18.5)
                Console.WriteLine(msgImcB);
            else if (imc >= 18.5 && imc < 25)
                Console.WriteLine(msgImcC);
            else if (imc >= 25 && imc < 30)
                Console.WriteLine(msgImcD);
            else if (imc >= 30 && imc < 35)
                Console.WriteLine(msgImcE);
            else if (imc >= 35 && imc < 40)
                Console.WriteLine(msgImcF);
            else if (imc >= 40)
                Console.WriteLine(msgImcG);
            else
                Console.WriteLine("Erreur");
        }

        public static void CompteJusquaDix()
        {
            for (int compt = 1; compt <= 10; compt++)
            {
                Console.WriteLine(compt);
                System.Threading.Thread.Sleep(1000);
            }
        }

        public static void AppelTataJacqueline()
        {
            Console.WriteLine("Bonjour, je n'ai pas envie de vous répondre. Vous pouvez toujours laisser un message, avec un peu de chance je l'écouterais si je n'ai pas la flemme.");
            System.Threading.Thread.Sleep(5000);
        }
        
        public static void Main(string[] args)
        {
            string prenomUtilisateur;
            string nomUtilisateur;
            int tailleUtilisateur;
            float poidsUtilisateur;
            int ageUtilisateur;

            bool stopProgramme = false;
            int choixUtilisateur;
            bool stopMenu;
            
            while (!stopProgramme)
            {
                stopMenu = false;
                
                Console.WriteLine("Bienvenue sur le programme de BEllOT Ian");

                do
                {
                    Console.WriteLine("Donnez votre prenom : ");
                    prenomUtilisateur = Console.ReadLine();
                } while (prenomUtilisateur != null && prenomUtilisateur.Any(char.IsDigit));

                do
                {
                    Console.WriteLine("Donnez votre nom : ");
                    nomUtilisateur = Console.ReadLine();
                } while (prenomUtilisateur != null && prenomUtilisateur.Any(char.IsDigit));

                do
                {
                    Console.WriteLine("Donnez votre taille (en cm) : ");
                    tailleUtilisateur = int.Parse(Console.ReadLine());
                } while (tailleUtilisateur < 0);

                do
                {
                    Console.WriteLine("Donnez votre poids (en kg) : ");
                    poidsUtilisateur = float.Parse(Console.ReadLine());
                } while (poidsUtilisateur < 0);

                do
                {
                    Console.WriteLine("Donnez votre age : ");
                    ageUtilisateur = int.Parse(Console.ReadLine());
                } while (ageUtilisateur < 0);

                Console.WriteLine("Bonjour " + nomUtilisateur + " " + prenomUtilisateur);
                Console.WriteLine("Vous mesurez " + tailleUtilisateur + " cm, vous pesez " + poidsUtilisateur +
                                  " kg et vous avez " + ageUtilisateur + " an(s)");

                if (ageUtilisateur >= 18)
                    Console.WriteLine("Vous êtes majeur, super !");
                else
                    Console.WriteLine("Vous êtes mineur :(");

                Console.WriteLine(FormatageNomPrenom(nomUtilisateur, prenomUtilisateur) + " Votre IMC est de : " +
                                  CalculImc(poidsUtilisateur, tailleUtilisateur).ToString("0.0"));
                CommenteImc(CalculImc(poidsUtilisateur, tailleUtilisateur));

                int nombreCheveuxUtilisateur;

                do
                {
                    Console.WriteLine("Estimez votre nombre de cheveux (Entier entre 100k et 150k) : ");
                    string saisie = Console.ReadLine();

                    if (int.TryParse(saisie, out nombreCheveuxUtilisateur))
                        Console.WriteLine("Merci, bonne saisie !");
                    else
                        Console.WriteLine("J'ai demandé un entier ...");

                } while (nombreCheveuxUtilisateur < 100000 || nombreCheveuxUtilisateur > 150000);
                
                while (!stopMenu)
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Menu principale - Choisissez une option (1,2,3 ou 4) : ");
                    Console.WriteLine("   - 1 - Quitter le programme ");
                    Console.WriteLine("   - 2 - Recommencer le programme ");
                    Console.WriteLine("   - 3 - Compter jusqu'a 10 ");
                    Console.WriteLine("   - 4 - Téléphoner à tata Jacqueline ");
                    choixUtilisateur = Convert.ToInt32(Console.ReadLine());

                    switch (choixUtilisateur)
                    {
                        case 1:
                            stopProgramme = true;
                            stopMenu = true;
                            break;
                        case 2:
                            stopMenu = true;
                            break;
                        case 3:
                            CompteJusquaDix();
                            stopProgramme = true;
                            stopMenu = true;
                            break;
                        case 4:
                            AppelTataJacqueline();
                            stopProgramme = true;
                            stopMenu = true;
                            break;
                        default:
                            Console.WriteLine("Valeur incorrecte");
                            break;
                    }
                }
            }
            
            Console.WriteLine("Au revoir... !");
            System.Threading.Thread.Sleep(3000);
            
        }
    }
}