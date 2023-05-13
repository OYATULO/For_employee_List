using For_Employers.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace For_Employers.Context
{
	public class APPDBContext : DbContext
	{
		public static  string connectionString = "Server=localhost; User ID=root; Password=; Database=cdstructure";
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			try
			{
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}


		/*protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CServiceDepartment>().HasData(
				new List<CServiceDepartment> {
							new CServiceDepartment
							{
								Id = 1,
								Name = "Отдел по обслуживанию клиентов",
								subMenus = new List<SubMenu>
								{
									new SubMenu{
										id = 1,
										Title = "Отдел оптовых продаж",
										Sotrudnik = new List<Employes>{
											new Employes
											{
												Id=2,
												Name = "ja23"
											}
										}
									}
								}
							}
				}
				);

			modelBuilder.Entity<PDepartment>().HasData(
				new List<PDepartment>{
								new PDepartment
								{
									Id = 1,
									Name = "Склад ",
									Sotrudnik = new List<Employes>
									{
									   new Employes
									   {
										   Id=1,
										   Name = "jak1"
									   }
									}

								}
							}
				);

			modelBuilder.Entity<Accounting>().HasData(new List<Accounting> {
						   new Accounting {
						   Id = 1,
						   Name = "Бухгалтерия ",
							   Sotrudnik = new List<Employes>
							   {
								   new Employes { Id=3,Name = "Бухгалтерия2"}
							   }
						   }
			});
		} */

		public DbSet<CompanyDStructure>? CompanyDStructure { get; set; }
		public DbSet<CServiceDepartment>? cservicedepartment { get; set; }
		public DbSet<PDepartment>? pdepartment { get; set; }
		public DbSet<Accounting>? accounting { get; set; }
		public DbSet<SubMenu>? submenu { get; set; }
		public	DbSet<Submenu2>? submenu2 { get; set; }
		public DbSet<Employes>? employes { get; set;}

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CServiceDepartment>().HasData(
				new List<CServiceDepartment> {
							new CServiceDepartment
							{
								Id = 1,
								Name = "Отдел по обслуживанию клиентов",
								subMenus = new List<SubMenu>
								{
									new SubMenu{
										id = 1,
										Title = "Отдел оптовых продаж",
										Sotrudnik = new List<Employes>{
											new Employes
											{
												Id=2,
												Name = "ja23"
											}
										}
									}
								}
							}
				}
				);

			modelBuilder.Entity<PDepartment>().HasData(
				new List<PDepartment>{
								new PDepartment
								{
									Id = 1,
									Name = "Склад ",
									Sotrudnik = new List<Employes>
									{
									   new Employes
									   {
										   Id=1,
										   Name = "jak1"
									   }
									}

								}
							}
				);

			modelBuilder.Entity<Accounting>().HasData(new List<Accounting> {
						   new Accounting {
						   Id = 1,
						   Name = "Бухгалтерия ",
							   Sotrudnik = new List<Employes>
							   {
								   new Employes { Id=3,Name = "Бухгалтерия2"}
							   }
						   }
			});
		} */

        /*	public DbSet<PDepartment>? PDepartment { get; set; }
			public DbSet<Accounting>? Accounting { get; set; }*/
    }
}
