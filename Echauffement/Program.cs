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
        string? stringUserAge = Console.ReadLine();
        int intUserAge = Convert.ToInt32(stringUserAge);

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur

        if (intUserAge >= 18)
        {
            Console.WriteLine("\nTu es majeur !");
        }
        else if (intUserAge < 18)
        {
            Console.WriteLine("\nTu es mineur !");
        }
        else
        {
            Console.WriteLine("\nVeuillez indiquer une valeur correspondante");
        }

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre entier)

        Console.WriteLine("\nCombien d'euros possédez-vous ?");
        string? stringUserMoney = Console.ReadLine();
        int intUserMoney = Convert.ToInt32(stringUserMoney);

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix

        Console.WriteLine("\nAvec " + intUserMoney + " euros, vous pouvez acheter ces 4 armes :");

        string weaponChoice1 = "1. Katana";
        int weaponPrice1 = 1500;
        Console.WriteLine(weaponChoice1 + " :\t\t" + weaponPrice1 + " euros");

        string weaponChoice2 = "2. Sabre long";
        int weaponPrice2 = 1500;
        Console.WriteLine(weaponChoice2 + " :\t\t" + weaponPrice2 + " euros");

        string weaponChoice3 = "3. Revolver";
        int weaponPrice3 = 2000;
        Console.WriteLine(weaponChoice3 + " :\t\t" + weaponPrice3 + " euros");

        string weaponChoice4 = "4. Double hachette";
        int weaponPrice4 = 1000;
        Console.WriteLine(weaponChoice4 + " :\t" + weaponPrice4 + " euros");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4

        Console.WriteLine("\nVeuillez entrer le chiffre correspondant à l'arme que vous souhaitez acheter (1 - 4");
        string? stringUserChoice = Console.ReadLine();
        int intUserChoice = Convert.ToInt32(stringUserChoice);

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4



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