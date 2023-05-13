using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using For_Employers.Context;
using For_Employers.Model;

namespace For_Employers.Pages
{
    public class showlistModel : PageModel
    {
        private readonly For_Employers.Context.APPDBContext _context;

        public showlistModel(For_Employers.Context.APPDBContext context)
        {
            _context = context;
        }

        public IList<CompanyDStructure> CompanyDStructure { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CompanyDStructure != null)
            {
                var struDcname = await _context.CompanyDStructure.ToListAsync();
                var dpco = await _context.cservicedepartment!.ToListAsync();
                var pdep = await _context.pdepartment!.ToListAsync();
                var acc = await _context.accounting!.ToListAsync();
                await _context.submenu!.ToListAsync();
                await  _context.submenu2!.ToListAsync();
                await  _context.employes!.ToListAsync();

                CompanyDStructure = new List<CompanyDStructure>
                {
                   new CompanyDStructure
                   {
                        Id = Convert.ToInt32(struDcname[0].Id),
                        Name = struDcname[0].Name,
                        CServiceDepartments = dpco,
                        Accounting = acc,
                        PDepartment = pdep
                   }
                };
            }
        }
        
    }
   
}
