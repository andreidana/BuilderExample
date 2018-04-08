namespace BuilderExample
{
    public class MansionBuilder: IHouseBuilder
    {
        private House _house;

        public void CreateHouse()
        {
            _house = new House("Mansion");
        }

        public void CreateFoundation()
        {
            _house.BuildFoundation(true);
        }

        public void CreateWalls()
        {
            _house.BuildWalls(8);
        }

        public void CreateRooms()
        {
            _house.BuildRooms(4);
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