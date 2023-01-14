using CSVApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System;
using CsvHelper;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CSVApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        /*public IActionResult Index()
        {
            return View();
        }*/

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.DataUsers.ToListAsync());
        }


        [HttpPost]
        public ActionResult archivo(IFormFile file)
        {
            using (var fileStream = file.OpenReadStream())
            using (var reader = new StreamReader(fileStream))
            {
                string row;
                string[] data;
                List<DataUser> dataCsvlist = new List<DataUser>();
                List<DataUser> dataCsvlistdb = _context.DataUsers.ToList();
                DataUser dataCsv = new DataUser();

                try
                {
                    reader.ReadLine();
                    while ((row = reader.ReadLine()) != null)
                    {
                        data = row.Split(",");
                        dataCsv = new DataUser
                        {
                            Name = data[1],
                            LastName = data[2],
                            Age = int.Parse(data[3]),
                            City = data[4]
                        };
                        

                        if (dataCsvlistdb.Where(x => x.Name == dataCsv.Name).Count() > 0)
                        {
                            DataUser datamodficada = dataCsvlistdb.Where(x => x.Name == dataCsv.Name).First();
                            datamodficada.LastName = dataCsv.LastName;  
                            datamodficada.Age = dataCsv.Age;
                            datamodficada.City = dataCsv.City;
                            _context.DataUsers.Update(datamodficada);

                        }
                        else
                        {
                            dataCsvlist.Add(dataCsv);
                        }
                    }
                    _context.DataUsers.AddRange(dataCsvlist);
                    _context.SaveChanges();
                    
                    
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
            return null;
        } 

    }
}