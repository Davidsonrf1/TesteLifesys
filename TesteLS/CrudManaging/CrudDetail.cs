using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteLS.Models;
using TesteLS.Controllers;

namespace TesteLS.CrudManaging
{
	public partial class CrudDetail: UserControl
	{
		public Crud Crud { get; private set; }
		ModelBase _model = null;

		public ModelBase Model
		{
			get
			{
				return _model;
			}
			
			set
			{
				_model = value;
				CreateView();
			}
		}

		public string Title
		{
			get
			{
				return lblTitle.Text;
			}

			set
			{
				lblTitle.Text = value;
			}
		}

		public CrudDetail(Crud crud, string title)
		{
			Crud = crud;

			InitializeComponent();
			tbFields.AutoSize = true;

			lblTitle.Text = title;
		}

		private void CrudDetail_Load(object sender, EventArgs e)
		{

		}

		void CreateView()
		{
			ClearFields();

			if (_model != null)
			{
				foreach (var dec in Crud.GetDecorators())
				{
					AddField(dec);
				}
			}
		}

		void ClearFields()
		{
			tbFields.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
			tbFields.Controls.Clear();
			_currentRowIndex = 0;
		}

		int _currentRowIndex = 0;

		void AddField(CrudDecoratorAttribute decorator)
		{
			var field = new CrudField(decorator, Model);

			tbFields.Controls.Add(field, 0, _currentRowIndex++);

			field.OnError += Field_OnError;
		}

		private void Field_OnError(object sender, List<ValidateResult> errors)
		{
			
		}

		void BindErrors(List<ValidateResult> errors) 
		{
			if (errors == null)
			{
				foreach (var ctrl in tbFields.Controls)
				{
					if (typeof(CrudField).IsAssignableFrom(ctrl.GetType()))
					{
						var field = (CrudField)ctrl;
						field.Errors = null;
					}
				}

				return;
			}

			Dictionary<string, List<ValidateResult>> el = new Dictionary<string, List<ValidateResult>>();

			foreach (var e in errors)
			{
				if (!el.ContainsKey(e.Field))
					el[e.Field] = new List<ValidateResult>();

				el[e.Field].Add(e);
			}

			foreach (var ctrl in tbFields.Controls)
			{
				if (typeof(CrudField).IsAssignableFrom(ctrl.GetType()))
				{
					var field = (CrudField)ctrl;
					var decorator = (CrudDecoratorAttribute)field.Tag;

					if (el.TryGetValue(decorator.Property.Name, out List<ValidateResult> errorList))
						field.Errors = errorList;
					else
						field.Errors = null;
				}
			}
		}

		void Save()
		{
			var controller = Model.GetController();
			var tmpModel =  Crud.CreateModel();

			foreach (var ctrl in tbFields.Controls)
			{
				if (typeof(CrudField).IsAssignableFrom(ctrl.GetType()))
				{
					var field = (CrudField)ctrl;
					var decorator = (CrudDecoratorAttribute)field.Tag;
					var prop = decorator.Property;

					var value = field.GetEditorValue();
					prop.SetValue(tmpModel, value);
				}
			}

			var errors = controller.OnValidate(tmpModel);

			if (errors.Count == 0)
			{
				foreach (var ctrl in tbFields.Controls)
				{
					if (typeof(CrudField).IsAssignableFrom(ctrl.GetType()))
					{
						var field = (CrudField)ctrl;
						var decorator = (CrudDecoratorAttribute)field.Tag;
						var prop = decorator.Property;

						var value = field.GetEditorValue();
						prop.SetValue(Model, value);
					}
				}

				controller.OnSave(Model);

				Crud.ShowList();
			}
			else
			{
				BindErrors(errors);
			}
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			BindErrors(null);
		}

		protected override void OnParentChanged(EventArgs e)
		{
			base.OnParentChanged(e);
			Dock = DockStyle.Fill;
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void tbFields_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Crud.ShowList();
		}
	}
}
