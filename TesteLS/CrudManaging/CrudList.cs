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
	public partial class CrudList : UserControl
	{
		public Crud Crud { get; private set; }

		public object ModelList
		{
			get
			{
				return grid.DataSource;
			}

			set
			{
				grid.DataSource = value;
				SetupColumns();
			}
		}

		CrudDecoratorAttribute FindDecorator(string name)
		{
			foreach (var i in Crud.GetDecorators())
			{
				if (i.Property.Name.Equals(name))
					return i;
			}

			return null;
		}

		void SetupColumns()
		{
			foreach (DataGridViewColumn c in grid.Columns)
			{
				var dec = FindDecorator(c.DataPropertyName);

				if (dec != null)
				{
					c.HeaderText = dec.Label;
				}
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

		public CrudList(Crud crud, string title)
		{
			Crud = crud;
			InitializeComponent();

			grid.EditMode = DataGridViewEditMode.EditProgrammatically;
			grid.MultiSelect = false;
			grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			Title = title;
		}

		protected override void OnParentChanged(EventArgs e)
		{
			base.OnParentChanged(e);

			Dock = DockStyle.None;
			Dock = DockStyle.Fill;
		}

		private void lsModelList_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnEditar_Click(sender, null);
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			Crud.EditingModel = Crud.CreateModel();
			Crud.ShowDetail();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (grid.SelectedRows.Count > 0)
			{
				Crud.EditingModel = (ModelBase)grid.SelectedRows[0].DataBoundItem;
				Crud.ShowDetail();
			}
		}

		ControllerBase GetController()
		{
			var model = (ModelBase)Activator.CreateInstance(Crud.ModelType);
			return model.GetController();
		}

		public void LoadList()
		{
			btnEditar.Enabled = false;
			btnRemover.Enabled = false;

			if (Visible)
			{
				using (var ctx = new DataContext())
				{
					var ctrl = GetController();
					ModelList = ctrl.GetList();
				}
			}
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
		}

		private void lvModel_DoubleClick(object sender, EventArgs e)
		{
			btnEditar_Click(sender, null);
		}

		private void grid_SelectionChanged(object sender, EventArgs e)
		{
			if (grid.SelectedRows.Count > 0)
			{
				btnEditar.Enabled = true;
				btnRemover.Enabled = true;
			}
			else
			{
				btnEditar.Enabled = false;
				btnRemover.Enabled = false;
			}
		}
	}
}
