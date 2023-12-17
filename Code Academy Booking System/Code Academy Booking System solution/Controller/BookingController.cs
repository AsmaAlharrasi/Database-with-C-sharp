using Code_Academy_Booking_System.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Academy_Booking_System.Controller
{
    internal class BookingController
    {
        private readonly ApplicationDbContext Context;

        public BookingController(ApplicationDbContext Context)
        {
            this.Context = Context;
        }

        public void BookSpace()
        {
            
        }

        public void ViewBookings()
        {
            
        }
    }

}
