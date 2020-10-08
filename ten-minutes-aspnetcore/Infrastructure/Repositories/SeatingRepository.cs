using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ten_minutes_aspnetcore.Domain.Models;
using ten_minutes_aspnetcore.Domain.Repositories;

namespace ten_minutes_aspnetcore.Infrastructure.Repositories
{
    public class SeatingRepository : ISeatingRepository
    {
        public IEnumerable<Seating> GetAll()
        {
            var seatings = new List<Seating>
            {
                new Seating { User = "Alice", Extension = "3333", CellPhone = "0911222333", Position = "1-1" },
                new Seating { User = "Bob", Extension = "3111", CellPhone = "0922222333", Position = "1-2" }
            };

            return seatings;
        }
    }
}
