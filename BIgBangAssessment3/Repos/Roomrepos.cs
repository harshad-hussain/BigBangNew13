using BIgBangAssessment3.models;
using Microsoft.EntityFrameworkCore;

namespace BIgBangAssessment3.Repos
{
    public class Roomrepos:IRoom
    {
        private readonly HotelContext _roomContext;
        public Roomrepos(HotelContext con)
        {
            _roomContext = con;
        }

        public IEnumerable<Room> ListRoom()
        {
            return _roomContext.Rooms.ToList();
        }
        public Room ListRoomById(int Room_Id)
        {
            return _roomContext.Rooms.FirstOrDefault(x => x.Room_Id == Room_Id);
        }

        public Room ListPostRoom(Room room)
        {
            if (room.Hotel != null)
            {
                var r = _roomContext.Hotels.Find(room.Hotel.Hotel_Id);
                room.Hotel = r;
            }
            _roomContext.Add(room);
            _roomContext.SaveChanges();
            return room;
        }

        public Room ListPutRoom(int Room_Id, Room room)
        {
            if (room.Hotel != null)
            {
                var r = _roomContext.Hotels.Find(room.Hotel.Hotel_Id);
                room.Hotel = r;
            }
            _roomContext.Entry(room).State = EntityState.Modified;
            _roomContext.SaveChangesAsync();
            return room;
        }


        public Room ListDeleteRoom(int Room_Id)
        {

            var r = _roomContext.Rooms.Find(Room_Id);


            _roomContext.Rooms.Remove(r);
            _roomContext.SaveChanges();

            return r;
        }

        public IEnumerable<Room> ListSearchRoomsByPriceRange(int minPrice, int maxPrice)
        {
            return _roomContext.Rooms
                .Where(x => x.Price >= minPrice && x.Price <= maxPrice)
                .ToList();
        }

        public int ListGetAvailableRoomCountByHotelId(int hotelId)
        {
            var query = _roomContext.Rooms
                .Where(room => room.Hotel != null && room.Hotel.Hotel_Id == hotelId && room.Availability == "yes");

            int count = query.Count();

            // Increment the count by one if the Availability field is "yes"
            count += query.Count(room => room.Availability == "yes");

            return count;
        }


    }
}

