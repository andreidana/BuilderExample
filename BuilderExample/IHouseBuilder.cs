namespace BuilderExample
{
    public interface IHouseBuilder
    {
        void CreateHouse();
        void CreateFoundation();
        void CreateWalls();
        void CreateRooms();
        void CreateRoof();
        House GetHouse();
    }
}