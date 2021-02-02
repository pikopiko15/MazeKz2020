using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebMaze.DbStuff;
using WebMaze.DbStuff.Model.Energy;
using WebMaze.DbStuff.Repository;
using WebMaze.Models.Energy;

namespace WebMaze.Controllers
{
    public class EnergyController : Controller
    {
        private EnergyUserRepository energyUserRepository;
        private IMapper mapper;

        public EnergyController(EnergyUserRepository energyUserRepository, IMapper mapper)
        {
            this.energyUserRepository = energyUserRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult EnergyConsumer()
        {
            var viewModel = new EnergyViewModel()
            {
                FirstName = "Test",
                LastName = "Test",
                Address = "Test",
                PhoneNumber = "Test",
                IsDebtor = false,
                AmountOfDebt = 0
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult EnergyConsumer(EnergyViewModel viewModel)
        {
            var user = mapper.Map<EnergyUser>(viewModel);
            energyUserRepository.Save(user);
            return View();
        }

        public IActionResult ConsumerProfile(long id)
        {
            var consumer = energyUserRepository.Get(id);
            var viewModel = mapper.Map<ConsumerProfileViewModel>(consumer);
            return View(viewModel);
        }
    }
}