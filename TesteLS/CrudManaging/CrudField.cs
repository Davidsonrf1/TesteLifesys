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
using TesteLS.Models;

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

		public CrudField(CrudDecoratorAttribute decorator, ModelBase model)
		{
			InitializeComponent();

			EditControl = EditorFactory.CreateEditor(decorator, model);

			lbFieldLabel.Text = decorator.Label;
			pnlEdit.Controls.Add(EditControl);

			EditControl.Font = lbFieldLabel.Font;

			EditControl.Width = decorator.Width;
			EditControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Top;
			EditControl.Top = (pnlEdit.Height - EditControl.Height) >> 1;

			if (!decorator.AllowEdit)
				EditControl.Enabled = false;

			Tag = decorator;
		}

		private void CrudField_Load(object sender, EventArgs e)
		{

		}

		protected override void OnParentChanged(EventArgs e)
		{
			base.OnParentChanged(e);
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
