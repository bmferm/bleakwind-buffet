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
    /// <summary>
    /// Class representing the model for the index page.
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<IOrderItem> entreeList = new List<IOrderItem>();
        public List<IOrderItem> sideList = new List<IOrderItem>();
        public List<IOrderItem> drinkList = new List<IOrderItem>();

        /// <summary>
        /// Log for the IndexModel class.
        /// </summary>
        /// <param name="logger"></param>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets requested lists of entrees, sides, and drinks from the Menu class.
        /// </summary>
        public void OnGet()
        {
            entreeList = (List<IOrderItem>)Menu.Entrees();
            sideList = (List<IOrderItem>)Menu.Sides();
            drinkList = (List<IOrderItem>)Menu.Drinks();
        }
    }
}
