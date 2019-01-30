using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PcParts.Data;
using PcParts.Services;
using PcParts.ViewModels;

namespace PcParts.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IPcPartsRepository _repository;

        public AppController(IMailService mailService, IPcPartsRepository repository)
        {
            this._mailService = mailService;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")] // Tag helper
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send the email
                this._mailService.SendMessage("Matthew.Mews@Outlook.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }

            return View();
        }

        public IActionResult Shop()
        {
            var results = _repository.GetAllProducts();

            //var results = _repository.GetAllProducts().Where(p => p.Category == "Graphics Card");

            return View(results);

        }
    }
}