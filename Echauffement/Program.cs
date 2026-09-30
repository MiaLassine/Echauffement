using System;

namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
        Consigne générale : faites un commit entre chaque étape !
        */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré

        Console.WriteLine("Heyy ! Moi, c'est Mia ! Mes jeux préférés sont Minecraft, Genshin Impact et Brawl Stars");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge

        Console.WriteLine("\nComment dois-je t'appeler ?");
        string? stringUserName = Console.ReadLine(); // le "?" après le string = Prévenir que la valeur peut être nulle (je ne comprenais pas le warn alors je me suis renseignée)

        Console.WriteLine("\nQuel âge as-Tu " + stringUserName + " ?");
        string? stringUserAge = Console.ReadLine(); // le "?" après le string = Prévenir que la valeur peut être nulle
        int intUserAge = Convert.ToInt32(stringUserAge);

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur

        if (intUserAge >= 18)
        {
            Console.WriteLine("\nSi tu as " + intUserAge + " ans, tu es majeur !");
        }
        else if (intUserAge < 18)
        {
            Console.WriteLine("\nSi tu as " + intUserAge + " ans, tu es mineur !");
        }
        else
        {
            Console.WriteLine("\nVeuillez indiquer une valeur correspondante"); //J'ai essayé de faire du blindage mais ça n'a pas trop marché...
                                                                                //Mais ça ne cause pas de problème donc je laisse ça là
        }

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre entier)

        Console.WriteLine("\nCombien d'euros possédez-vous ?");
        string? stringUserMoney = Console.ReadLine(); // le "?" après le string = Prévenir que la valeur peut être nulle
        int intUserMoney = Convert.ToInt32(stringUserMoney);

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix

        Console.WriteLine("\nAvec " + intUserMoney + " euros, vous pouvez acheter ces 4 armes :");

        string weaponChoice1 = "Katana";
        int weaponPrice1 = 1500;
        Console.WriteLine("1. " + weaponChoice1 + " :\t\t" + weaponPrice1 + " euros");

        string weaponChoice2 = "Sabre long";
        int weaponPrice2 = 1500;
        Console.WriteLine("2. " + weaponChoice2 + " :\t\t" + weaponPrice2 + " euros");

        string weaponChoice3 = "Revolver";
        int weaponPrice3 = 2000;
        Console.WriteLine("3. " + weaponChoice3 + " :\t\t" + weaponPrice3 + " euros");

        string weaponChoice4 = "Double hachette";
        int weaponPrice4 = 1000;
        Console.WriteLine("4. " + weaponChoice4 + " :\t" + weaponPrice4 + " euros");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4

        Console.WriteLine("\nVeuillez entrer le chiffre correspondant à l'arme que vous souhaitez acheter (1 - 4)");
        string? stringUserChoice = Console.ReadLine();
        int intUserChoice = Convert.ToInt32(stringUserChoice);

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

        int weaponPrice0 = 0; //Initialisation de la variable weaponPrice0
        string weaponChosen = "Shhh"; //Initialisation de la variable weaponChosen (j'ai essayé de mettre "null" sans guillemets et de mettre un "?" après le string,
                                      //mais ça ne faisait pas ce que je voulais).

        if (intUserChoice == 1)
        {
            weaponPrice0 = weaponPrice1; //Prix de l'arme choisie
            weaponChosen = weaponChoice1; //Nom de l'arme choisie
        }
        else if(intUserChoice == 2)
        {
            weaponPrice0 = weaponPrice2;
            weaponChosen = weaponChoice2;
        }
        else if(intUserChoice == 3)
        {
            weaponPrice0 = weaponPrice3;
            weaponChosen = weaponChoice3;
        }
        else if(intUserChoice == 4)
        {
            weaponPrice0 = weaponPrice4;
            weaponChosen = weaponChoice4;
        }
        else
        {
            Console.WriteLine("\nVeuillez indiquer un chiffre entre 1 et 4.");
        }


        if(intUserMoney >= weaponPrice0) //vérification que le prix soit suffisant
        {
            Console.WriteLine("\nAchat confirmé.");
            Console.WriteLine("Vous possédez désormais " + "\"" + weaponChosen + "\".");
        }
        else
        {
            Console.WriteLine("\nTransaction échouée, vous n'avez pas assez d'argent !");
        }

            // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
            // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
            // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible



            /*
            Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
            */

            return; //Cela affiche une erreur dans la console parce que je ne peux pas mettre de "return 0;" dans un void main.
                  //Mais j'avais pour habitude de le mettre et ça ne pose pas trop de problème... Donc voilà..
                  //Finalement j'ai enlevé le "0", le message d'erreur me faisait chier
    }
}