using BIgBangAssessment3.models;
using Microsoft.EntityFrameworkCore;

namespace BIgBangAssessment3.Repos
{
    public class Hotelrepos:IHotel
    {
        private readonly HotelContext _hotelContext;
        public Hotelrepos(HotelContext con)
        {
            _hotelContext = con;
        }
        public IEnumerable<Hotel> ListHotel()
        {
            return _hotelContext.Hotels.Include(x => x.Rooms).ToList();
        }
        public Hotel ListHotelById(int Hotel_Id)
        {
            return _hotelContext.Hotels.FirstOrDefault(x => x.Hotel_Id == Hotel_Id);
        }

        public Hotel ListPostHotel(Hotel hotel)
        {
            _hotelContext.Hotels.Add(hotel);
            _hotelContext.SaveChanges();
            return hotel;
        }

        public Hotel ListPutHotel(int Hotel_Id, Hotel hotel)
        {

            _hotelContext.Entry(hotel).State = EntityState.Modified;
            _hotelContext.SaveChangesAsync();
            return hotel;
        }

        public Hotel ListDeleteHotel(int Hotel_Id)
        {

            var hot = _hotelContext.Hotels.Find(Hotel_Id);


            _hotelContext.Hotels.Remove(hot);
            _hotelContext.SaveChanges();

            return hot;
        }

        public IEnumerable<Hotel> ListSearchHotels(string location)
        {
            IQueryable<Hotel> query = _hotelContext.Hotels.Include(x => x.Rooms);

            // Apply filter based on location
            if (!string.IsNullOrEmpty(location))
            {
                query = query.Where(x => x.Hotel_Location.Contains(location));
            }

            return query.ToList();
        }
    }
}


 