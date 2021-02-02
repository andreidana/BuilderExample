using System;

namespace BuilderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the type of house you want to build(S - Small house, M - Mansion, P - Palace)");
            var inputCharacter = Convert.ToChar(Console.Read());

            IHouseBuilder builder = BuildHouse(inputCharacter);
            builder.CreateHouse();
            builder.CreateFoundation();
            builder.CreateWalls();
            builder.CreateRooms();
            builder.CreateRoof();
            var builtHouse = builder.GetHouse();
            PrintBuiltHouseDetails(builtHouse);
        }

        private static IHouseBuilder BuildHouse(char inputCharacter)
        {
            IHouseBuilder builder;
            if (inputCharacter == 'S')
                builder = new SmallHouseBuilder();
            else if (inputCharacter == 'M')
                builder = new MansionBuilder();
            else if (inputCharacter == 'P')
                builder = new PalaceBuilder();
            else
                builder = new SmallHouseBuilder();
            return builder;
        }

        private static void PrintBuiltHouseDetails(House builtHouse)
        {
            Console.WriteLine($"Foundation is built - {builtHouse.Foundation}");
            Console.WriteLine($"Number of walls - {builtHouse.Walls}");
            Console.WriteLine($"Number of rooms - {builtHouse.Rooms}");
            Console.WriteLine($"Roof is built - {builtHouse.Roof}");
            Console.ReadKey();
        }
    }
}
