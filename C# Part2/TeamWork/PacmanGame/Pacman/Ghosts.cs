namespace PacmanGame
{
    using System;
    using System.Threading;

    public class Ghosts
    {
        private const int StartingPosX = 11;
        private const int StartingPosY = 15;
        private int posX;
        private int posY;
        private char symbol = '☻';
        private string direct = "Down";
        private ConsoleColor color;

        public Ghosts(int posX, int posY, ConsoleColor color)
        {
            this.posX = posX;
            this.posY = posY;
            this.color = color;
            this.DrawAtPosition();
        }

        public int PosX
        {
            get 
            {
                return this.posX; 
            }
        }

        public int PosY
        {
            get
            {
                return this.posY;
            }
        }

        public string Direction
        {
            get
            {
                return this.direct;
            }
        }        

        public bool IsThereGhost(int objectCoordX, int objectCoordY)
        {
            bool isThereCollission = new bool();
            if (this.posX == objectCoordX && this.posY == objectCoordY)
            {
                isThereCollission = true;
            }

            return isThereCollission;
        }
        
        public void Move(string direction)
        {
            switch (direction)
            {
                case "Down":
                    this.RemoveFromPreviousPosition();
                    this.posY -= 1;
                    this.DrawAtPosition();
                    this.direct = direction;
                    break;
                case "Up":
                    this.RemoveFromPreviousPosition();
                    this.posY += 1;
                    this.DrawAtPosition();
                    this.direct = direction;
                    break;
                case "Right":
                    this.RemoveFromPreviousPosition();
                    this.posX += 1;
                    this.DrawAtPosition();
                    this.direct = direction;
                    break;
                case "Left":
                    this.RemoveFromPreviousPosition();
                    this.posX -= 1;
                    this.DrawAtPosition();
                    this.direct = direction;
                    break;
                default:
                    break;
            }
        }

        public void DrawAtPosition()
        {
            Console.SetCursorPosition(this.posX, this.posY);
            Console.ForegroundColor = this.color;
            Console.Write(this.symbol);
            Console.ResetColor();
        }

        public void RemoveFromPreviousPosition()
        {
            Console.SetCursorPosition(this.posX, this.posY);
            Console.Write(' ');
        }

        public void ResetPosition()
        {
            this.RemoveFromPreviousPosition();
            this.posX = StartingPosX;
            this.posY = StartingPosY;
            this.DrawAtPosition();
        }
    }
}