using Microsoft.AspNetCore.Mvc;
using MVCApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.WebApi.Controllers.Master
{
    public class SubscriberController : Controller
    {
        private readonly ISubscriberService _subscriberService;
        public SubscriberController(ISubscriberService subscriberService)
        {
            _subscriberService = subscriberService;
        }
        public IActionResult Index()
        {
            var data = _subscriberService.GetAllTrue();
            return View(data);
        }
    }
}
