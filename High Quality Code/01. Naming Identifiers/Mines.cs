/* Refactor and improve the naming in the C# source project “3. 
 * Naming-Identifiers-Homework.zip”. You are allowed to make other improvements in the
 * code as well (not only naming) as well as to fix bugs.
 * */

namespace Mines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Mines
    {     
        static void Main(string[] arguments)
        {
            const int Max = 35;
            string command = string.Empty;
            char[,] field = CreateField();
            char[,] bombs = PlaceBombs();
            int counter = 0;
            bool boom = false;
            List<Points> champions = new List<Points>(6);
            int row = 0;
            int column = 0;
            bool flag = true;        
            bool secondFlag = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Let's play mines! Test your luck to find the fields without mines." +
                                      " command 'top' shows the Rating, 'restart' begin new game, 'exit' quits the game!");
                    Dump(field);
                    flag = false;
                }

                Console.Write("Input row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) && row <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Rating(champions);
                        break;
                    case "restart":
                        field = CreateField();
                        bombs = PlaceBombs();
                        Dump(field);
                        boom = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye, bye!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                PlayerMove(field, bombs, row, column);
                                counter++;
                            }

                            if (Max == counter)
                            {
                                secondFlag = true;
                            }
                            else
                            {
                                Dump(field);
                            }
                        }
                        else
                        {
                            boom = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid column\n");
                        break;
                }

                if (boom)
                {
                    Dump(bombs);
                    Console.Write("\nHlengthlength! Dies heroic with {0} points. " + "Input nickname: ", counter);
                    string nickName = Console.ReadLine();
                    Points t = new Points(nickName, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Point < t.Point)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Points r1, Points r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Points r1, Points r2) => r2.Point.CompareTo(r1.Point));
                    Rating(champions);

                    field = CreateField();
                    bombs = PlaceBombs();
                    counter = 0;
                    boom = false;
                    flag = true;
                }

                if (secondFlag)
                {
                    Console.WriteLine("\nWell doneee! You opened 35 cells without a single drop of blood!");
                    Dump(bombs);
                    Console.WriteLine("Input your name brave hero: ");
                    string name = Console.ReadLine();
                    Points points = new Points(name, counter);
                    champions.Add(points);
                    Rating(champions);
                    field = CreateField();
                    bombs = PlaceBombs();
                    counter = 0;
                    secondFlag = false;
                    flag = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("COOOMEEE OOON.");
            Console.Read();
        }

        private static void Rating(List<Points> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, points[i].Name, points[i].Point);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Ratings!\n");
            }
        }

        private static void PlayerMove(char[,] field, char[,] bombs, int row, int column)
        {
            char numberOfMines = MineNumbers(bombs, row, column);
            bombs[row, column] = numberOfMines;
            field[row, column] = numberOfMines;
        }

        private static void Dump(char[,] board)
        {
            int length = board.GetLength(0);
            int width = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < width; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceBombs()
        {
            int rows = 5;
            int columns = 10;
            char[,] playingField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playingField[i, j] = '-';
                }
            }

            List<int> bombList = new List<int>();
            while (bombList.Count < 15)
            {
                Random random = new Random();
                int number = random.Next(50);
                if (!bombList.Contains(number))
                {
                    bombList.Add(number);
                }
            }

            foreach (int number in bombList)
            {
                int col = number / columns;
                int row = number % columns;
                if (row == 0 && number != 0)
                {
                    col--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playingField[col, row - 1] = '*';
            }

            return playingField;
        }

        private static void Calculations(char[,] field)
        {
            int cols = field.GetLength(0);
            int rows = field.GetLength(1);

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char numberOfMines = MineNumbers(field, i, j);
                        field[i, j] = numberOfMines;
                    }
                }
            }
        }

        private static char MineNumbers(char[,] field, int width, int length)
        {
            int count = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (width - 1 >= 0)
            {
                if (field[width - 1, length] == '*')
                {
                    count++;
                }
            }

            if (width + 1 < rows)
            {
                if (field[width + 1, length] == '*')
                {
                    count++;
                }
            }

            if (length - 1 >= 0)
            {
                if (field[width, length - 1] == '*')
                {
                    count++;
                }
            }

            if (length + 1 < cols)
            {
                if (field[width, length + 1] == '*')
                {
                    count++;
                }
            }

            if ((width - 1 >= 0) && (length - 1 >= 0))
            {
                if (field[width - 1, length - 1] == '*')
                {
                    count++;
                }
            }

            if ((width - 1 >= 0) && (length + 1 < cols))
            {
                if (field[width - 1, length + 1] == '*')
                {
                    count++;
                }
            }

            if ((width + 1 < rows) && (length - 1 >= 0))
            {
                if (field[width + 1, length - 1] == '*')
                {
                    count++;
                }
            }

            if ((width + 1 < rows) && (length + 1 < cols))
            {
                if (field[width + 1, length + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }

        public class Points
        {
            private string name;
            private int point;

            public Points()
            {
            }

            public Points(string name, int points)
            {
                this.name = name;
                this.point = points;
            }

            public string Name
            {
                get
                {
                    return this.name;
                }

                set
                {
                    this.name = value;
                }
            }

            public int Point
            {
                get
                {
                    return this.point;
                }

                set
                {
                    this.point = value;
                }
            }
        }
    }
}