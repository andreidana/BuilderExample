namespace BuilderExample
{
    public class House
    {
        public string Name { get; }
        public bool Foundation { get; private set; }
        public int Walls { get; private set; }
        public int Rooms { get; private set; }
        public bool Roof { get; private set; }

        public House(string name)
        {
            Name = name;
        }

        public void BuildFoundation(bool foundationBuilt)
        {
            Foundation = foundationBuilt;
        }

        public void BuildWalls(int numberOfBuiltWalls)
        {
            Walls = numberOfBuiltWalls;
        }

        public void BuildRooms(int numberOfBuiltRooms)
        {
            Rooms = numberOfBuiltRooms;
        }

        public void BuildRoof(bool roofBuilt)
        {
            Roof = roofBuilt;
        }
    }
}