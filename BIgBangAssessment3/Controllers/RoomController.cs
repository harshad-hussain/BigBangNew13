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
    public class RoomController : ControllerBase
    {
        private readonly IRoom r;
        public RoomController(IRoom r)
        {
            this.r = r;
        }
        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return r.ListRoom();
        }

        [HttpGet("{Room_Id}")]
        public Room GetById(int Room_Id)
        {
            return r.ListRoomById(Room_Id);
        }

        [HttpPost]
        public Room PostRoom(Room room)
        {
            return r.ListPostRoom(room);
        }
        [HttpPut("{Room_Id}")]
        public Room PutRoom(int Room_Id, Room room)
        {
            return r.ListPutRoom(Room_Id, room);
        }
        [HttpDelete("{Room_Id}")]
        public Room DeleteRoom(int Room_Id)
        {
            return r.ListDeleteRoom(Room_Id);
        }

        [HttpGet("search")]
        public IEnumerable<Room> SearchRoomsByPriceRange(int minPrice, int maxPrice)
        {
            return r.ListSearchRoomsByPriceRange(minPrice, maxPrice);
        }

        [HttpGet("roomcount/{hotelId}")]
        public IActionResult GetAvailableRoomCount(int hotelId)
        {
            int count = r.ListGetAvailableRoomCountByHotelId(hotelId);

            return Ok(count);
        }


    }
}

