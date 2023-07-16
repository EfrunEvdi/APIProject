using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {

        }

        public void BookingStatusChangeApproved(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı.";
            context.SaveChanges();
        }

        public int GetBookingCount()
        {
            using var context = new Context();
            var value = context.Bookings.Count();
            return value;
        }

        public List<Booking> Last6Bookings()
        {
            using var context = new Context();
            var values = context.Bookings.OrderByDescending(x => x.BookingID).Take(6).ToList();
            return values;
        }

        public void BookingStatusChangeCancel(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "İptal edildi.";
            context.SaveChanges();
        }

        public void BookingStatusChangeWait(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Müşteri aranacak.";
            context.SaveChanges();
        }
    }
}