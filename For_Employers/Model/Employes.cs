using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace For_Employers.Model
{

	public class CompanyDStructure
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(128)]
		public string? Name { get; set; }
		public List<CServiceDepartment>? CServiceDepartments { get; set; }
		public List<PDepartment>? PDepartment { get; set; }
		public List<Accounting>? Accounting { get; set; }
	}

	
	public class CServiceDepartment {

		[Key]
		public int Id { get; set; }
		[MaxLength(128)]
		public string? Name { get; set; }
		public List<SubMenu>? subMenus { get; set; }
	}

	public class SubMenu 
	{
		[Key]
		public int id { get; set; }
		[MaxLength(128)]
		public string? Name { get; set; }
		public List<Employes>? Sotrudnik { get; set; } = null;
		public	List<Submenu2>? submenu2s { get; set; }

	}
	public class Submenu2
	{
		[Key]
		public int id { get; set; }
		[MaxLength(128)]
		public string? Name { get; set; }
		public List<Employes>? Sotrudnik { get; set; } = null;

    }


	public class PDepartment
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(128)]
		public string? Name { get; set; }
		public List<SubMenu>? subMenus { get; set; }
	}

	public class Accounting
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(128)] 
		public string? Name { get; set; }
		public List<Employes>? Sotrudnik { get; set; } = null;

    }
	public class Employes
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(128)]
		public string? Name { get; set; }

	}

}


