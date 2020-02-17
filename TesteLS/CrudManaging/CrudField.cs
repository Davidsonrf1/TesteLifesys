using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteLS.Controllers;

namespace TesteLS.CrudManaging
{
	public partial class CrudField : UserControl
	{
		public delegate void OnErrorClickDelegate(object sender, List<ValidateResult> errors);

		public event OnErrorClickDelegate OnError;

		void RaiseOnErrorsClick() => OnError?.Invoke(this, Errors);

		List<ValidateResult> _errors = null;
		public List<ValidateResult> Errors
		{
			get
			{
				return _errors;
			}
			set
			{
				_errors = value;
				pbErrors.Visible = _errors != null;

				if (pbErrors.Visible)
				{
					lbFieldLabel.ForeColor = Color.OrangeRed;

					StringBuilder sb = new StringBuilder();

					foreach (var e in _errors)
					{
						if (sb.Length > 0)
							sb.Append('\n');

						sb.Append(e.Message);
					}

					tip.SetToolTip(pbErrors, sb.ToString());
				}
				else
				{
					tip.SetToolTip(pbErrors, null);
					lbFieldLabel.ForeColor = Color.Black;
				}
			}
		}

		public Control EditControl { get; private set; }
		public string Value
		{
			get
			{
				return EditControl.Text;
			}

			set
			{
				EditControl.Text = value;
			}
		}

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

		public object GetEditorValue()
		{
			if (EditControl.GetType().Equals(typeof(DateTimePicker)))
			{
				var picker = (DateTimePicker)EditControl;
				return picker.Value;
			}

			return EditControl.Text;
		}

		private void lbFieldLabel_Click(object sender, EventArgs e)
		{

		}

		private void pbErrors_Click(object sender, EventArgs e)
		{
			RaiseOnErrorsClick();
		}
	}
}
