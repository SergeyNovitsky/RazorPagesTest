using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesTest.Data;
using RazorPagesTest.Data.Models;

namespace RazorPagesTest.Pages
{
    public class InventoryModel : PageModel
    {
        private readonly RazorPagesTest.Data.ApplicationDbContext _context;

        public InventoryModel(RazorPagesTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Inventory> Inventory { get; set; }

        public void OnGet()
        {
            Inventory = _context.Inventory.ToList();
        }
    }
}
