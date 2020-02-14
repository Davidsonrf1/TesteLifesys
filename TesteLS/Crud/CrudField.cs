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
	public partial class CrudField : UserControl
	{
		public Control EditControl { get; private set; }

		public CrudField(string label, int width, Type editControl)
		{
			InitializeComponent();

			if (typeof(Control).IsAssignableFrom(editControl))
			{
				EditControl = (Control)Activator.CreateInstance(editControl);
			}
			else
			{
				throw new InvalidCastException($"Não é possível converter um objeto do tipo {editControl.FullName} em um objeto do tipo {typeof(Control).FullName}");
			}

			lbFieldLabel.Text = label;
			pnlEdit.Controls.Add(EditControl);

			EditControl.Font = lbFieldLabel.Font;

			EditControl.Width = width;
			EditControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Top;
			EditControl.Top = (pnlEdit.Height - EditControl.Height) >> 1;			
		}

		private void CrudField_Load(object sender, EventArgs e)
		{

		}

		protected override void OnParentChanged(EventArgs e)
		{
			base.OnParentChanged(e);

			//Width = Parent.Width - (Margin.Left + Margin.Right);
			//Left = Margin.Left;
			//Anchor = AnchorStyles.Left | AnchorStyles.Right;
		}
	}
}
