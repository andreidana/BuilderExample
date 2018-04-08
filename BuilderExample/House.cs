namespace BuilderExample
{
    public class House
    {
        private string _name;
        private bool _foundation;
        private int _walls;
        private int _rooms;
        private bool _roof;

        public string Name => _name;
        public bool Foundation => _foundation;
        public int Walls => _walls;
        public int Rooms => _rooms;
        public bool Roof => _roof;

        public House(string name)
        {
            _name = name;
        }

        public void BuildFoundation(bool foundationBuilt)
        {
            _foundation = foundationBuilt;
        }

        public void BuildWalls(int numberOfBuiltWalls)
        {
            _walls = numberOfBuiltWalls;
        }

        public void BuildRooms(int numberOfBuiltRooms)
        {
            _rooms = numberOfBuiltRooms;
        }

        public void BuildRoof(bool roofBuilt)
        {
            _roof = roofBuilt;
        }
    }
}