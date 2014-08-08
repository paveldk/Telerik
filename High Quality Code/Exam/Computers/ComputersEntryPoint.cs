namespace ComputerParts
{
    using System;
    using ComputerParts.ComputerFactory;

    public class ComputersEntryPoint
    {
        public static void Main()
        {        
            Factory factory;
            IComputer pc = new Computer();
            IServer server = new Server();
            ILaptop laptop = new Laptop();

            // Hot spot, can't remove it :) I need to read the line
            var manufacturer = Console.ReadLine();

            if (manufacturer == "HP")
            {
                factory = new HpFactory();
                CreateDevices(factory, ref pc, ref server, ref laptop);  
            }
            else if (manufacturer == "Dell")
            {
                factory = new DellFactory();
                CreateDevices(factory, ref pc, ref server, ref laptop); 
            }
            else if (manufacturer == "Lenovo")
            {
                factory = new LenovoFactory();
                CreateDevices(factory, ref pc, ref server, ref laptop);
            }
            else
            {
                throw new ArgumentException("Invalid manufacturer!");
            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command != null && !command.StartsWith("Exit"))
                {
                    var commandParts = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (commandParts.Length != 2)
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                
                    var commandName = commandParts[0];
                    var commandAtribute = int.Parse(commandParts[1]);

                    if (commandName == "Charge")
                    {
                        laptop.ChargeBattery(commandAtribute);
                    }
                    else if (commandName == "Process")
                    {
                        server.Process(commandAtribute);
                    }
                    else if (commandName == "Play")
                    {
                        pc.Play(commandAtribute);
                    }
                    else
                    {
                        Console.WriteLine("Invalid command!");
                    }
                }
                else
                {
                    break;
                }           
            }
        }

        private static void CreateDevices(Factory factory, ref IComputer pc, ref IServer server, ref ILaptop laptop)
        {
            pc = factory.CreateComputer();
            laptop = factory.CreateLaptop();
            server = factory.CreateServer();
        }
    }
}