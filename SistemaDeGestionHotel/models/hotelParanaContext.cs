using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionHotel.models
{
    internal class HotelParanaContext : DbContext
    {
        public HotelParanaContext(DbContextOptions<HotelParanaContext> options)
            : base(options)
        {

        }
    }
}
