using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class SupplierRepository: ISupplierRepository
    {
        private readonly WigDbContext _wigDbContext;
        public SupplierRepository(WigDbContext wigDbContext)
        {
            _wigDbContext = wigDbContext;
        }
        public IEnumerable<Supplier> AllSuppliers => _wigDbContext.Suppliers;
    }
}
    

