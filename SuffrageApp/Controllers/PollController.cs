using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using SuffrageApp.Models;

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

        [HttpGet]
        public IActionResult View(int id)
        {
            var poll = _pollService.GetPoll(id);

            return View(poll);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var pollView = new CreatePollViewModel()
            {
                PollDto = new PollDto() { },
                IsEdit = false
            };

            return View(pollView);
        }

        [HttpPost]
        public IActionResult Create(PollDto dto)
        {
            _pollService.CreatePoll(dto);

            var pollView = _pollService.GetPoll(dto.Id);
   

            return View("View", pollView);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var poll = new CreatePollViewModel()
            {
                PollDto = _pollService.GetPoll(id),
                IsEdit = true
            };
            return View("Create", poll);
        }

        [HttpPost]
        public IActionResult Edit(PollDto dto)
        {
            _pollService.UpdatePoll(dto);

            return RedirectToAction("View", new { id = dto.Id });
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _pollService.DeletePoll(id);

            return RedirectToAction("Index");
        }
    }
}
