using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ten_minutes_aspnetcore.Domain.Models;

namespace ten_minutes_aspnetcore.Domain.Repositories
{
    public interface ISeatingRepository
    {
        IEnumerable<Seating> GetAll();
    }
}
