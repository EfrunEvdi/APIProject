using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialID { get; init; }
        public string Name { get; init; }
        public string Title { get; init; }
        public string Description { get; init; }
        public string Image { get; init; }
    }
}
