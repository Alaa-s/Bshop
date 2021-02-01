using bakaryshop.Data;
using bakaryshop.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace bakaryshop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BakeryShopContext _db;
        public IndexModel(BakeryShopContext db) => this._db = db;
        public List<Product> pro { get; set; }
        public Product Feauredproduct { get; set; }
        public async Task OnGetAsync()
        {
            pro = await _db.products.ToListAsync();
            Feauredproduct = pro.ElementAt(new Random().Next(pro.Count));
        }

    }
}
