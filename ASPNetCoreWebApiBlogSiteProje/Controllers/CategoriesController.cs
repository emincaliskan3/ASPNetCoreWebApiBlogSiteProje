﻿using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace ASPNetCoreWebApiBlogSiteProje.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DatabaseContext _context;

        public CategoriesController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return BadRequest();

            }
            var categories = _context.Categories.Include(p => p.Posts).FirstOrDefault(k => k.Id == id);
            if (categories == null)
                return NotFound();

            return View(categories);
        }
    }
}
