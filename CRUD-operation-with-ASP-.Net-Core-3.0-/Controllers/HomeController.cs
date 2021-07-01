using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPWebAPI.Model;
using ASPWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASPWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        private ILogger _logger;
        private IHotelsList _hotelService;


        public HomeController(ILogger<HomeController> logger, IHotelsList hotelService)
        {
            _logger = logger;
            _hotelService = hotelService;

        }

        [HttpGet("/api/hotels")]
        public ActionResult<List<Hotels>> GetHotels()
        {
            return _hotelService.GetHotels();
        }

        [HttpPost("/api/hotels")]
        public ActionResult<Hotels> AddHotels(Hotels hotels)
        {
            _hotelService.AddHotel(hotels);
            return hotels;
        }

        [HttpPut("/api/hotels/{id}")]
        public ActionResult<Hotels> UpdateHotels(string id, Hotels hotels)
        {
            _hotelService.UpdateHotel(id, hotels);
            return hotels;
        }

        [HttpDelete("/api/hotels/{id}")]
        public ActionResult<string> DeleteHotels(string id)
        {
            _hotelService.DeleteHotel(id);
            //_logger.LogInformation("products", _products);
            return id;
        }
    }
}