using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteLS.Migrations;

namespace TesteLS
{
	static class Program
	{
		public static DataContext MainContext { get; private set; }

		public static DataContext CreateContext()
		{
			return new DataContext(); // TODO: Criar conexão de forma adequada
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			MainContext = new DataContext();

			var migrator = new DbMigrator(new Configuration());
			migrator.Update();

			MainContext.Empresas.Load();

			foreach (var e in MainContext.Empresas)
			{

			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmMain());
		}
	}
}
