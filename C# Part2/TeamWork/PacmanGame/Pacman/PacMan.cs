namespace PacmanGame
{
    using System;

    public class PacMan
    {
        private const char symbol = '☺';
        private int posX;
        private int posY;
        private string direct = "Up";
        private ConsoleColor color;

        public PacMan(int posX = 13, int posY = 5, ConsoleColor color = ConsoleColor.Yellow)
        {
            this.posX = posX;
            this.posY = posY;
            this.color = color;
            this.DrawAtPosition();
        }

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
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

        public string GetDirection
        {
            get
            {
                return this.direct;
            }
        }

        public void Move(string direction)
        {
            switch (direction)
            {
                case "Up":
                    this.RemoveFromPreviousPosition();
                    this.posY -= 1;
                    this.DrawAtPosition();
                    break;
                case "Down":
                    this.RemoveFromPreviousPosition();
                    this.posY += 1;
                    this.DrawAtPosition();
                    break;
                case "Left":
                    this.RemoveFromPreviousPosition();
                    this.posX -= 1;
                    this.DrawAtPosition();
                    break;
                case "Right":
                    this.RemoveFromPreviousPosition();
                    this.posX += 1;
                    this.DrawAtPosition();
                    break;
                default:
                    break;
            }

            this.direct = direction;
        }

        public void SetGhostEater()
        {
            this.color = ConsoleColor.Red;
            DrawAtPosition();
        }

        public void SetNormal()
        {
            this.color = ConsoleColor.Yellow;
            DrawAtPosition();
        }

        public bool IsTherePacMan(int objectCoordX, int objectCoordY)
        {
            bool isThereCollission = new bool();
            if (this.posX == objectCoordX && this.posY == objectCoordY)
            {
                isThereCollission = true;
            }

            return isThereCollission;
        }

        private void DrawAtPosition()
        {
            Console.SetCursorPosition(this.posX, this.posY);
            Console.ForegroundColor = this.color;
            Console.Write(symbol);
            Console.ResetColor();
        }

        private void RemoveFromPreviousPosition()
        {
            Console.SetCursorPosition(this.posX, this.posY);
            Console.Write(' ');
        }
    }
}