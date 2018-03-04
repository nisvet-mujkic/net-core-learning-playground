using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiControllers.Models
{
    public interface IRepository
    {
        Reservation this[int id] { get; }
        IEnumerable<Reservation> Reservations { get; }
        Reservation Add(Reservation reservation);
        Reservation Update(Reservation reservation);
        void Delete(int id);
    }
}
