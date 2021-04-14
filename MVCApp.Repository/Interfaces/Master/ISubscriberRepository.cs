using MVCApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCApp.Repository.Interfaces
{
    public interface ISubscriberRepository : IGenericRepository<Subscriber>
    {
        IEnumerable<Subscriber> GetAllTrue();
    }
}
