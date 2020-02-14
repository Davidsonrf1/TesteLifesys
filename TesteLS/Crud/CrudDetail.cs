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
	public partial class CrudDetail : UserControl
	{
		public CrudDetail()
		{
			InitializeComponent();
			tbFields.AutoSize = true;
		}

		private void CrudDetail_Load(object sender, EventArgs e)
		{

		}

		public void ClearFields()
		{
			tbFields.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
			tbFields.Controls.Clear();
			_currentRowIndex = 0;
		}

		int _currentRowIndex = 0;

		public void AddField(string label, Type editor, int width)
		{
			var field = new CrudField(label, width, editor);
			tbFields.Controls.Add(field, 0, _currentRowIndex++);
		}

		protected override void OnParentChanged(EventArgs e)
		{
			base.OnParentChanged(e);
			Dock = DockStyle.Fill;
		}
	}
}
