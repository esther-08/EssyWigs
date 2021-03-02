using EssyWigs.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Components
{
    public class SupplierMenu: ViewComponent
    {
        private readonly ISupplierRepository _supplierRepository;
        

        public SupplierMenu(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        public IViewComponentResult Invoke()
        {
            var suppliers = _supplierRepository.AllSuppliers.OrderBy(s => s.SupplierName);
            return View(suppliers);
        }
    }
}
