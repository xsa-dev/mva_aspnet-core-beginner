﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db) { _db = db; }

        public IList<Customer> Customers { get; private set; }

        [TempData]
        public string Message { get; set; }

        public async Task OnGetAsync()
        {
            Customers = await _db.Costomers.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var customer = await _db.Costomers.FindAsync(id);

            if (customer != null)
            {
                _db.Costomers.Remove(customer);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
