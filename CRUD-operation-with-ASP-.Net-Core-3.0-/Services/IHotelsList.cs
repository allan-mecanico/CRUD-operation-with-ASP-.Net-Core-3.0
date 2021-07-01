using ASPWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPWebAPI.Services
{
    public interface IHotelsList
    {
        public List<Hotels> GetHotels();

        public Hotels AddHotel(Hotels hotels);

        public Hotels UpdateHotel(string id, Hotels hotels);

        public string DeleteHotel(string id);
    }
}
