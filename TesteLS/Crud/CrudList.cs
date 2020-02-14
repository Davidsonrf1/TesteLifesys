using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteLS.CrudManaging
{
	public partial class CrudList : UserControl
	{
		public CrudList()
		{
			InitializeComponent();
		}

		private void CrudList_Load(object sender, EventArgs e)
		{

		}

		public void ClearColumns()
		{
			lsModelList.Columns.Clear();
		}

		public void AddColumn(string label, int width)
		{
			lsModelList.Columns.Add(label, width, HorizontalAlignment.Center);
		}

		protected override void OnParentChanged(EventArgs e)
		{
			base.OnParentChanged(e);

			Dock = DockStyle.None;
			Dock = DockStyle.Fill;
		}
	}
}
