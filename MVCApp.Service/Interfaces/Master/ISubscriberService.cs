using MVCApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCApp.Service.Interfaces
{
    public interface ISubscriberService : IEntityService<Subscriber>
    {
        IEnumerable<Subscriber> GetAllTrue();
    }
}
