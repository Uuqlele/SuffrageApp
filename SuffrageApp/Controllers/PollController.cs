using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace SuffrageApp.Controllers
{
    public class PollController : Controller
    {
        private readonly IPollService _pollService;

        public PollController(IPollService pollService)
        {
            _pollService = pollService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var polls = _pollService.GetAllPolls();

            return View(polls);
        }
    }
}
