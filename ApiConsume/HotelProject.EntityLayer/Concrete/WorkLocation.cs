using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class WorkLocation
    {
        public int WorkLocationID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public List<AppUser> AppUsers { get; set; }
    }
}
