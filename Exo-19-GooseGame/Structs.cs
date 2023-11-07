using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_19_GooseGame
{
    public struct GooseGame
    {
        public Dictionary<string, int> players;
        public int lastSquare;
        /// <summary>
        /// Ajoute un joueur.
        /// </summary>
        /// <param name="playerName">Nom du joueur</param>
        /// <returns>true si joueur ajouté, false dans le cas contraire</returns>
        public bool AddPlayer(string playerName)
        {
            //if (players is null)
            //{
            //    players = new Dictionary<string, int>();
            //}

            //OU

            //players = players ?? new Dictionary<string, int>();

            //OU

            players ??= new Dictionary<string, int>();

            if (players.ContainsKey(playerName)) return false;
            players.Add(playerName, 0);
            return true;
        }
        /// <summary>
        /// Déplace un joueur.
        /// </summary>
        /// <param name="playerName">Nom du joueur</param>
        /// <param name="steps">Nombre de case à avancer</param>
        /// <returns>Le numéro de la case finale au déplacement, ou -1 si le joueur n'existe pas</returns>
        public int MovePlayer(string playerName, int steps)
        {
            if (!players.ContainsKey(playerName)) return -1;
            int currentSquare = players[playerName];
            currentSquare += steps;
            //if(currentSquare > lastSquare)
            //{
            //    int delta = currentSquare - lastSquare;
            //    currentSquare = lastSquare - delta ;
            //}

            currentSquare = (currentSquare > lastSquare) ? lastSquare - (currentSquare - lastSquare) : currentSquare;

            players[playerName] = currentSquare;

            return currentSquare;
        }
        /// <summary>
        /// Permet de jouer à GooseGame.
        /// </summary>
        public void Play()
        {
            const int MIN_JOUEUR = 2;
            const int MAX_JOUEUR = 6;
            Console.WriteLine($"Introduisez le nombre de joueur : ({MIN_JOUEUR} à {MAX_JOUEUR})");
            int nbJoueur;
            bool isConverted;
            do
            {
                string input = Console.ReadLine();
                isConverted = int.TryParse(input, out nbJoueur);
            } while (!isConverted || (nbJoueur < MIN_JOUEUR || nbJoueur > MAX_JOUEUR));

            int nbRegisteredPlayer = 0;
            while (nbRegisteredPlayer < nbJoueur)
            {
                Console.WriteLine($"Veuillez indtroduire le nom du joueur {nbRegisteredPlayer + 1} :");
                string playerName = Console.ReadLine();
                if (playerName != null && playerName.Length > 0 && AddPlayer(playerName))
                {
                    nbRegisteredPlayer++;
                }
            }

            int currentPlayerSquare;
            //List<string> playerNames = players.Keys.ToList();
            string[] playerNames = players.Keys.ToArray();
            int turn = 0;
            do
            {
                //string playerName = players.ElementAt(turn % playerNames.Length).Key;
                string playerName = playerNames[turn % playerNames.Length];
                Dice dice;
                dice.min = 1;
                dice.max = 6;
                int resultRoll = dice.Roll(2);
                Console.WriteLine($"Tour de {playerName} : a obtenu {resultRoll} aux dés.");
                currentPlayerSquare = MovePlayer(playerName, resultRoll);
                Console.WriteLine($"a atteint la case {currentPlayerSquare}.");
                turn++;
            } while (currentPlayerSquare != lastSquare);
            Console.WriteLine("Bravo, vous avez gagné!");
        }
    }

    public struct Dice
    {
        public int min;
        public int max;

        public int Roll(int nbRoll = 1)
        {
            if (nbRoll < 1) nbRoll = 1;
            Random RNG = new Random();
            int result = 0;
            for (int i = 0; i < nbRoll; i++)
            {
                //result += RNG.Next(max+1-min)+min;
                result += RNG.Next(min, max + 1);
            }
            return result;
        }
    }
}
