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

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			MainContext = new DataContext();

			var migrator = new DbMigrator(new Configuration());
			migrator.Update();

			var l = MainContext.Empresas.ToList();

			foreach (var e in l)
			{
				MainContext.Empresas.Remove(e);
			}

			MainContext.SaveChanges();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmMain());
		}
	}
}
