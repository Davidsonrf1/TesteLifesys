using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLS.Models;

namespace TesteLS
{
	public class DataContext: DbContext
	{
		public DbSet<Empresa> Empresas { get; set; }
		public DbSet<Fornecedor> Fornecedores { get; set; }
	}
}
