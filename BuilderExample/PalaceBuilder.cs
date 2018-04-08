namespace BuilderExample
{
    public class PalaceBuilder: IHouseBuilder
    {
        private House _house;

        public void CreateHouse()
        {
            _house = new House("Palace");
        }

        public void CreateFoundation()
        {
            _house.BuildFoundation(true);
        }

        public void CreateWalls()
        {
            _house.BuildWalls(44);
        }

        public void CreateRooms()
        {
            _house.BuildRooms(123);
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