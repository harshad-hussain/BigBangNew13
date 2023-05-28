using BIgBangAssessment3.models;
using BIgBangAssessment3.Repos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BIgBangAssessment3.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotel ht;
        public HotelController(IHotel hot)
        {
            this.ht = hot;
        }
        [HttpGet]
        public IEnumerable<Hotel> Get()
        {
            return ht.ListHotel();
        }

        [HttpGet("{HotelId}")]
        public Hotel GetById(int HotelId)
        {
            return ht.ListHotelById(HotelId);
        }

        [HttpPost]
        public Hotel PostHotel(Hotel hotel)
        {
            return ht.ListPostHotel(hotel);
        }
        [HttpPut("{HotelId}")]
        public Hotel PutHotel(int HotelId, Hotel hotel)
        {
            return ht.ListPutHotel(HotelId, hotel);
        }
        [HttpDelete("{HotelId}")]
        public Hotel DeleteHotel(int HotelId)
        {
            return ht.ListDeleteHotel(HotelId);
        }
        [HttpGet("search")]
        public IEnumerable<Hotel> SearchHotels(string location)
        {
            return ht.ListSearchHotels(location);
        }

    }
}
