using ASPWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPWebAPI.Services
{
    public class HotelService : IHotelsList
    {
        private List<Hotels> _hotelItems;

        public HotelService()
        {
            _hotelItems = new List<Hotels>();
        }

        public List<Hotels> GetHotels()
        {
            return _hotelItems;
        }

        public Hotels AddHotel(Hotels hotels)
        {
            _hotelItems.Add(hotels);
            return hotels;
        }

        public Hotels UpdateHotel(string id, Hotels hotels)
        {
            for (var index = _hotelItems.Count - 1; index >= 0; index--)
            {
                if (_hotelItems[index].HotelID == id)
                {
                    _hotelItems[index] = hotels;
                }
            }
            return hotels;
        }

        public string DeleteHotel(string id)
        {
            for (var index = _hotelItems.Count - 1; index >= 0; index--)
            {
                if (_hotelItems[index].HotelID == id)
                {
                    _hotelItems.RemoveAt(index);
                }
            }

            return id;
        }

        public Hotels UpdateProduct(string id, Hotels hotel)
        {
            throw new NotImplementedException();
        }
    }
}
