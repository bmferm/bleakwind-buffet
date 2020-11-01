using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<IOrderItem> entreeList = new List<IOrderItem>();
        public List<IOrderItem> sideList = new List<IOrderItem>();
        public List<IOrderItem> drinkList = new List<IOrderItem>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            entreeList = (List<IOrderItem>)Menu.Entrees();
            sideList = (List<IOrderItem>)Menu.Sides();
            drinkList = (List<IOrderItem>)Menu.Drinks();
        }
    }
}
