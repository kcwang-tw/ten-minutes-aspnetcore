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
            throw new NotImplementedException();
        }
    }
}
