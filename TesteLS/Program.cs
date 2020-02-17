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
			try
			{
				MainContext = new DataContext();

				var migrator = new DbMigrator(new Configuration());
				migrator.Update();
			}
			catch (Exception ex)
			{
				var cs = System.Configuration.ConfigurationManager.ConnectionStrings["DataContext"];

				MessageBox.Show($"Falaha ao conectar no banco de dados\nMensagem: {ex.Message}\nString de conexão: {cs}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmMain());
		}
	}
}
