
Loto();





// ========== ========== ========== ========== ==========
void TVA()
{
    Console.WriteLine("Prix HT");
    string htText = Console.ReadLine();
    float ht = float.Parse(htText);
    float ttc = ht * 1.2f;

    //var result = float.Parse(Console.ReadLine()) * 1.2f;

    Console.WriteLine($"Prix TTC : {ttc.ToString("F2")} euros");
    //Console.WriteLine($"Prix TTC : {ttc.ToString("F2")} euros");
    Console.ReadKey();
}
// ========== ========== ========== ========== ==========
void Formulaire()
{
    Console.WriteLine("Nom");
    string nom = Console.ReadLine();
    Console.WriteLine("Prénom");
    string prenom = Console.ReadLine();
    Console.WriteLine("Age");
    string age = Console.ReadLine();

    Console.WriteLine($"Tu es {prenom} {nom} et tu as {age} ans !");
}
// ========== ========== ========== ========== ==========
void ChiFouMi()
{
    Console.WriteLine("Chi-Fou-Mi");

    Console.WriteLine("1 - Pierre");
    Console.WriteLine("2 - Feuille");
    Console.WriteLine("3 - Ciseaux");

    int randomChoice = new Random().Next(1, 4);
    Console.WriteLine($"({randomChoice} sera mon choix)");

    string reponse = Console.ReadLine();


    if ((reponse == "1" && randomChoice == 3) ||
        (reponse == "2" && randomChoice == 1) ||
        (reponse == "3" && randomChoice == 2))
    {
        Console.WriteLine("Trop fort pour moi");
    }

    if (reponse == "1" && randomChoice == 3)
    {
        Console.WriteLine("Trop fort pour moi");
    }
    else if (reponse == "2" && randomChoice == 1)
    {
        Console.WriteLine("Trop fort pour moi");
    }
    else if (reponse == "3" && randomChoice == 2)
    {
        Console.WriteLine("Trop fort pour moi");
    }
    else
    {
        Console.WriteLine("Perdu !");
    }

    Console.ReadKey();
}
// ========== ========== ========== ========== ==========
void Calculator2000()
{
    Console.WriteLine("Calculator 2000");

    int a = 0;
    int b = 0;

    int choice = 1;

    while(choice != 1 && choice != 2)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1 Facile");
        Console.WriteLine("2 Difficile");
        choice = int.Parse(Console.ReadLine());
        if(choice == 1)
        {
            a = new Random().Next(1, 100);
            b = new Random().Next(1, 100);
        }
        else if(choice == 2)
        {
            a = new Random().Next(1, 10000);
            b = new Random().Next(1, 10000);
        }
    }

    do
    {

        Console.WriteLine("");

    } while(choice == 1);


    #region Game
    Console.WriteLine($"Combien fait {a} + {b} ?");
    var reponse = int.Parse(Console.ReadLine());

    if (reponse == a + b)
    {
        Console.WriteLine("Bien joué");
    }
    else
    {
        Console.WriteLine($"Perdu ! C'était {a + b}");
    }
    Console.ReadKey();
    #endregion



}
// ========== ========== ========== ========== ==========
void PlusOuMoins()
{
    var nbMystere = new Random().Next(1, 100);
    int choixJoueur = 0;
    Console.WriteLine($"Plus ou moins (cheat:{nbMystere}");

    do
    {
        Console.WriteLine("Devine :");
        choixJoueur = int.Parse(Console.ReadLine());

        if(choixJoueur < nbMystere)
        {
            Console.WriteLine("C'est plus");
        }
        else if(choixJoueur > nbMystere)
        {
            Console.WriteLine("C'est moins");
        }

    } while (choixJoueur != nbMystere);

    Console.WriteLine("GG");
    Console.ReadKey();
}
// ========== ========== ========== ========== ==========
void PlusOuMoinsV2()
{
    var nbMystere = new Random().Next(1, 100);
    int choixJoueur = 0;
    int nbTentative = 0;

    DateTime old = DateTime.Now;
    Console.WriteLine($"Plus ou moins (cheat:{nbMystere})");
    do
    {
        nbTentative++;
        Console.WriteLine("Devine :");
        if(int.TryParse(Console.ReadLine(), out choixJoueur))
        {
            if (choixJoueur < nbMystere)
            {
                Console.WriteLine("C'est plus");
            }
            else if (choixJoueur > nbMystere)
            {
                Console.WriteLine("C'est moins");
            }
        }
        else
        {
            Console.WriteLine("écrit un nombre stp");
        }
    } while (choixJoueur != nbMystere);


    DateTime now = DateTime.Now;
    var elapsed = (now - old).TotalSeconds;
    Console.WriteLine($"GG tu as réussis en {nbTentative} fois et en {elapsed.ToString("F2")} secondes chrono!");
    Console.ReadKey();
}
// ========== ========== ========== ========== ==========
void Loto()
{
    int random = 0;
    for (int j = 0; j < 10; j++)
    {
        random = new Random().Next(1, 100);
        Console.WriteLine($"{random}");
    }

    Console.WriteLine($"Fini");
    Console.ReadKey();
}




