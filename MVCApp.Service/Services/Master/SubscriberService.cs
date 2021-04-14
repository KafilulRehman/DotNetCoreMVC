using MVCApp.Data.Models;
using MVCApp.Repository.Interfaces;
using MVCApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCApp.Service.Services
{
    public class SubscriberService : EntityService<Subscriber>,ISubscriberService
    {
        private readonly ISubscriberRepository _subscriberRepository;
        public SubscriberService(IUnitOfWork unitOfWork, ISubscriberRepository repository) :
            base(unitOfWork, repository)
        {
            UnitOfWork = unitOfWork;
            _subscriberRepository = repository;
        }
        public IEnumerable<Subscriber> GetAllTrue()
        {
            return _subscriberRepository.GetAllTrue();
        }
    }
}
