using BIgBangAssessment3.models;

namespace BIgBangAssessment3.Repos
{
    public interface IRoom
    {
        public IEnumerable<Room> ListRoom();
        public Room ListRoomById(int Room_Id);
        public Room ListPostRoom(Room room);
        public Room ListPutRoom(int Room_Id, Room room);
        public Room ListDeleteRoom(int Room_Id);
        IEnumerable<Room> ListSearchRoomsByPriceRange(int minPrice, int maxPrice);

        int ListGetAvailableRoomCountByHotelId(int hotelId);
    }
}
