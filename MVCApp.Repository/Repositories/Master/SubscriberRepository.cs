using MVCApp.Data.Models;
using MVCApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCApp.Repository.Repositories
{
    public class SubscriberRepository : GenericRepository<Subscriber>, ISubscriberRepository
    {
        public SubscriberRepository(IndigoCollegeDbFirstContext context) : base(context)
        {
        }

        public IEnumerable<Subscriber> GetAllTrue()
        {
            var data = Context.Subscribers.ToList();
            return data;
        }
    }
}
