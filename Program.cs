
#region Bases
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
        choixJoueur = ReadNumber();
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
            choixJoueur = ReadNumber();
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
        if (ReadNumber() == 2)
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
int ReadNumber()
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
#endregion
// ========== ========== ========== ========== ==========
#region Loto
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
void LotoWithList()
{
    List<int> loto = new List<int>();

    for (int i = 0; i < 10; i++)
    {
        var r = new Random().Next(1, 100);
        loto.Add(r);
    }

    for (int i = 0; i < loto.Count; i++)
    {
        Console.WriteLine(loto[i]);
    }

    foreach (int el in loto)
    {
        Console.WriteLine(el);
    }

    Console.WriteLine("fini");
    Console.ReadKey();
}
#endregion
// ========== ========== ========== ========== ==========
#region Maths
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
#endregion
// ========== ========== ========== ========== ==========

#region Pendu

///Pendu();

bool Not(bool input) => !input;
bool Even(int chiffre) => chiffre % 2 == 0;

void Pendu()
{
    List<string> dictionnary = new List<string>()
    {
        "hello",
        "coucou",
        "pomme",
        "poire",
        "orange",
        "paillette",
        "yeux",
        "kevin",
        "calculs",
    };

    int randomIndex = new Random().Next(0, dictionnary.Count);
    string secret = dictionnary[randomIndex];
    string displayedCharacters = "";

    DisplaySecretWord(secret, displayedCharacters);

    // Tant que le mot complet n'a pas été dévoilé
    while (IsWordCompleted(secret, displayedCharacters) == false)
    {
        // On lit un caractère
        var character = ReadCharacter();

        // On cumule les anciens caractères avec ce nouveau caratère
        displayedCharacters += character;

        // On affiche le mot avec ces caractères
        DisplaySecretWord(secret, displayedCharacters);
        Console.WriteLine();
    }

    Console.WriteLine("Veuillez appuyer sur une touche pour fermer");
    Console.ReadKey();
}

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

// Return true if the secret word is displayed with all characters
bool IsWordCompleted(string secretWord, string displayedCharacter)
{
    foreach (var c in secretWord)
    {
        if (displayedCharacter.Contains(c) == false)
        {
            return false;
        }
    }
    return true;
}

#endregion


#region Puissance 4
Puissance4();
void Puissance4()
{
    int[,] tableau = new int[6,7];

    DisplayGrid(tableau);

    // Présenter le plateau

    // TANT que la grille n'est pas pleine ET qu'il n'y a pas de puissance4
    // {
    bool result = false;
    while(true)
    {
        // Demander au joueur 1 la colonne 
        Console.WriteLine("Joueur 1");
        var col = ReadNumber() - 1;
        var newLine = InsertChip(tableau, col, 1);
        // Présenter le plateau
        DisplayGrid(tableau);
        // Est-ce que ya un puissance 4 ?
        //result = HasConnect4(tableau, newLine, col);
        result = HasConnect4Func(tableau, (newLine, col));
        if(result == true)
        {
            break;
        }

        // Demander au joueur 2 la colonne
        Console.WriteLine("Joueur 2");
        col = ReadNumber() - 1;
        newLine = InsertChip(tableau, col, 2);
        // Présenter le plateau
        DisplayGrid(tableau);
        
        //result = HasConnect4(tableau, newLine, col);
        result = HasConnect4Func(tableau, (newLine, col));
        if (result == true)
        {
            break;
        }
    }
    Console.WriteLine("Youpi");
    Console.ReadKey();

    // }
    // Ecran de victoire
}

(int dx, int dy)[] Neighboors() 
    => new[] { (1,0), (0,1), (1,1), (-1,1) };

bool HasConnect4Func(int[,] tab, (int x, int y) pos) 
    => Neighboors().Select(i => CountChipsFrom(tab, pos, i)).Max() >= 4;

int CountChipsFrom(int[,] tab, (int x,int y) pos, (int x,int y) dir)
{
    var chip = tab[pos.x, pos.y];
    return Count(dir) + Count((-dir.x, -dir.y)) - 1;

    bool IsOutOfBounds((int x, int y) pos)
        => pos.x < 0 ||
            pos.y < 0 ||
            pos.x >= tab.GetLength(0) ||
            pos.y >= tab.GetLength(1);

    int Count((int x,int y) dir)
    {
        (int x,int y) cursor = (pos.Item1, pos.Item2);
        int c = 0;
        while (tab[cursor.x, cursor.y] == chip)
        {
            c ++;
            cursor = (cursor.x + dir.x, cursor.y + dir.y);
            if (IsOutOfBounds(cursor)) break;
        }
        return c;
    }
}






bool HasConnect4(int[,] tableau, int newLine, int col)
{
    var chip = tableau[newLine, col];

    // 0 0 X 0 X X 0 0
    int count = 1;
    if (col + 1 >= tableau.GetLength(1) && chip == tableau[newLine, col + 1])
    {
        count++;
        if (col + 2 >= tableau.GetLength(1) && chip == tableau[newLine, col + 2])
        {
            count++;
            if (col + 3 >= tableau.GetLength(1) && chip == tableau[newLine, col + 3]) count++;
        }
    }

    if (chip == tableau[newLine, col - 1])
    {
        count++;
        if (chip == tableau[newLine, col - 2])
        {
            count++;
            if (chip == tableau[newLine, col - 3]) count++;
        }
    }

    if (count >= 4) return true; 

    // droite
    if (col <= 3 &&
        chip == tableau[newLine, col + 1] && 
        chip == tableau[newLine, col + 2] &&
        chip == tableau[newLine, col + 3])
    {
        return true;
    }

    // gauche
    if (col >= 3 &&
        chip == tableau[newLine, col - 1] &&
        chip == tableau[newLine, col - 2] &&
        chip == tableau[newLine, col - 3])
    {
        return true;
    }

    return false;
}

int InsertChip(int[,] grid, int col, int playerCoin)
{
    for (int i = grid.GetLength(0)-1; i >= 0; i--)
    {
        //Console.WriteLine($"reading line {i} : {grid[i, col]}");

        
        if(grid[i, col] == 0)
        {
            grid[i, col] = playerCoin;
            return i;
        }
    }
    return -1;
}

void DisplayGrid(int[,] tableau)
{
    for (int x = 0; x < tableau.GetLength(0); x++)
    {
        for (int y = 0; y < tableau.GetLength(1); y++)
        {
            Console.Write(tableau[x, y] + " ");
        }
        Console.WriteLine();
    }
}

#endregion


