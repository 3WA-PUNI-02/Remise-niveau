
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

    int choice = 0;
    while (choice != 1 && choice != 2)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1 Facile");
        Console.WriteLine("2 Difficile");
        //choice = ReadNumber();
        if (choice == 1)
        {
            a = new Random().Next(1, 100);
            b = new Random().Next(1, 100);
        }
        else if (choice == 2)
        {
            a = new Random().Next(1, 10000);
            b = new Random().Next(1, 10000);
        }
    }

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

        if (choixJoueur < nbMystere)
        {
            Console.WriteLine("C'est plus");
        }
        else if (choixJoueur > nbMystere)
        {
            Console.WriteLine("C'est moins");
        }

    } while (choixJoueur != nbMystere);

    Console.WriteLine("GG");
    Console.ReadKey();
}
void PlusOuMoinsFtList()
{
    List<int> historique = new List<int>();
    var nbMystere = new Random().Next(1, 100);
    int choixJoueur = 0;
    Console.WriteLine($"Plus ou moins (cheat:{nbMystere}");

    do
    {
        Console.WriteLine("Devine :");
        choixJoueur = ReadNumer();
        historique.Add(choixJoueur);

        if (choixJoueur < nbMystere)
        {
            Console.WriteLine("C'est plus");
        }
        else if (choixJoueur > nbMystere)
        {
            Console.WriteLine("C'est moins");
        }

    } while (choixJoueur != nbMystere);

    Console.WriteLine($"GG tu as fais ça en {historique.Count} coup ! voici ton historique :");

    for (int i = 0; i < historique.Count; i++)
    {
        Console.Write(historique[i] + " ");
    }

    Console.ReadKey();
}
void PlusOuMoinsFtListV2()
{
    bool tryAgain = true;
    List<int> historique = new List<int>();

    do
    {
        var nbMystere = new Random().Next(1, 100);
        int choixJoueur = 0;
        Console.WriteLine($"Plus ou moins (cheat:{nbMystere}");

        do
        {
            Console.WriteLine("Devine :");
            choixJoueur = ReadNumer();
            historique.Add(choixJoueur);

            if (choixJoueur < nbMystere)
            {
                Console.WriteLine("C'est plus");
            }
            else if (choixJoueur > nbMystere)
            {
                Console.WriteLine("C'est moins");
            }

        } while (choixJoueur != nbMystere);

        Console.WriteLine($"GG tu as fais ça en {historique.Count} coup ! voici ton historique :");

        for (int i = 0; i < historique.Count; i++)
        {
            Console.Write(historique[i] + " ");
        }

        Console.WriteLine("Try again ? 1 - OUI / 2 - NON");
        if (ReadNumer() == 2)
        {
            tryAgain = false;
        }
        else
        {
            historique.Clear();
        }

    } while (tryAgain);

    //Console.ReadKey();
}
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
        if (int.TryParse(Console.ReadLine(), out choixJoueur))
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

        IsEven(random);

    }

    Console.WriteLine($"Fini");
    Console.ReadKey();
}
// ========== ========== ========== ========== ==========

void IsEven(int number)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Oh c'est paire");
    }
}
int Power2(int number)
{
    var el = number * number;
    return el;
}
// ========== ========== ========== ========== ==========

int ReadNumer()
{
    bool flag = false;
    while (flag == false)
    {
        string txt = Console.ReadLine();
        if (int.TryParse(txt, out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Erreur, entrez un nombre");
        }
    }
    return -1;
}
void LotoWithList()
{
    List<int> loto = new List<int>();

    for (int i = 0; i < 10; i++)
    {
        var r = new Random().Next(1, 100);
        loto.Add(r);
    }

    foreach (int el in loto)
    {
        Console.WriteLine(el);
    }

    Console.WriteLine("fini");
    Console.ReadKey();
}




//DisplaySecretWord("hello", "eo");       // _ e _ _ o
//DisplaySecretWord("hello", "eohl");       // _ e _ _ o
//DisplaySecretWord("", "eo");       // _ e _ _ o
//DisplaySecretWord("hello", "");       // _ e _ _ o
//Console.ReadKey();

// Écrit dans la console le mot secret uniquement avec les lettres qui sont déjà dévoilées
void DisplaySecretWord(string secretWord, string displayedCharacter)
{
    // on parcourt toutes les lettres du secretWord
    for (int i = 0; i < secretWord.Length; i++)
    {

        // secretWord[i]
        // si le caractère en question existe dans displayedCharacter
        if (displayedCharacter.Contains(secretWord[i]))
        {
            // ON affiche le caractère
            Console.Write(secretWord[i]);
        }
        // sinon 
        else
        {
            // ON affiche _
            Console.Write("_");
        }
    }

    #region version foreach
    //foreach (char c in secretWord)
    //{
    //    // si le caractère en question existe dans displayedCharacter
    //    if (displayedCharacter.Contains(c))
    //    {
    //        // ON affiche le caractère
    //        Console.Write(c);
    //    }
    //    // sinon 
    //    else
    //    {
    //        // ON affiche _
    //        Console.Write("_");
    //    }
    //}
    #endregion
}

// Read a line until the player gives only 1 character
string ReadCharacter()
{
    string saisie = "";
    do
    {
        // Je demande une saisie au joueur, je la garde d'un côté
        saisie = Console.ReadLine();

        // Si le joeur a entré un seul caractère, tout est bon on peut renvoyer ce texte
        if (saisie.Length != 1)
        {
            Console.WriteLine("Erreur, un seul caractère autorisé");
        }
        // Sinon on affiche un message et on remonte à la première étape
        
    } while (saisie.Length != 1);

    return saisie;
}

bool IsWordCompleted(string secretWord, string displayedCharacter)
{
    foreach(var c in secretWord)
    {
        if(displayedCharacter.Contains(c) == false)
        {
            return false;
        }
    }
    return true;
}






















string ReadCharacteraaa()
{
    bool flag = false;
    string t = "";
    while (t.Length != 1)
    {
        t = Console.ReadLine();
        if (t.Length == 1)
        {
            flag = true;
        }
        else
        {
            Console.WriteLine("Erreur");
        }
    }
    return t;
}


//Console.WriteLine("Debut du programme");

////var c = ReadCharacter();
////Console.WriteLine($"Tu as écris : {c}");

//AfficherMot("hello", "eo");

//string hello = "hello";

//Console.WriteLine("Fin du programme");
//Console.ReadKey();


void AfficherMot(string mot, string known)
{
    foreach (var c in mot)
    {
        if (known.Contains(c))
        {
            Console.Write(c);
        }
        else
        {
            Console.Write("_");
        }
    }
    Console.WriteLine("");

}

bool MotComplet(string mot, string known)
{
    foreach (var c in mot)
    {
        if (known.Contains(c) == false) return false;
    }
    return true;
}







void Pendu()
{





}

