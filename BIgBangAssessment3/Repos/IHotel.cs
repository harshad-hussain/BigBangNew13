using BIgBangAssessment3.models;

namespace BIgBangAssessment3.Repos
{
    public interface IHotel
    {
        public IEnumerable<Hotel> ListHotel();
        public Hotel ListHotelById(int Hotel_Id);
        public Hotel ListPostHotel(Hotel hotel);
        public Hotel ListPutHotel(int Hotel_Id, Hotel hotel);
        public Hotel ListDeleteHotel(int Hotel_Id);

        IEnumerable<Hotel> ListSearchHotels(string location);
    }
}
