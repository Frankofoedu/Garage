using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garage.Common;
using Garage.Common.Interfaces;
using Garage.Data.Contexts;
using Garage.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Garage.Web.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly UnitOfWork _unitOfWork;
        public IndexModel(IUnitOfWork unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        [BindProperty]
        public List<Product> Products { get; set; }
        public async Task OnGet()
        {
            var prodResult = await _unitOfWork.ProductRepository.GetAll();

            Products = prodResult.ToList();
        }

    }
}