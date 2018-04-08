namespace BuilderExample
{
    public class SmallHouseBuilder: IHouseBuilder
    {
        private House _house;

        public void CreateHouse()
        {
            _house = new House("Small House");
        }

        public void CreateFoundation()
        {
            _house.BuildFoundation(true);
        }

        public void CreateWalls()
        {
            _house.BuildWalls(4);
        }

        public void CreateRooms()
        {
            _house.BuildRooms(2);
        }

        public void CreateRoof()
        {
            _house.BuildRoof(true);
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}