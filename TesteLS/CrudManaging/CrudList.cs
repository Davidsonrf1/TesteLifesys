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

		List<ModelBase> _modelList = null;
		public List<ModelBase> ModelList
		{
			get
			{
				return _modelList;
			}

			set
			{
				_modelList = value;
				FillList();
			}
		}

		public void AddModel(ModelBase model)
		{
			ListViewItem lvi = null;

			foreach (var p in model.GetType().GetProperties())
			{
				string value = p.GetValue(model)?.ToString();

				if (value == null)
					value = "";

				if (lvi == null)
				{
					lvi = lvModel.Items.Add(value);
					lvi.Tag = model;
				}
				else
				{
					lvi.SubItems.Add(value);
				}				
			}
		}

		public void FillList()
		{
			lvModel.Items.Clear();

			if (_modelList != null)
			{
				foreach (var model in _modelList)
				{
					AddModel(model);
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

			Title = title;
		}

		private void CrudList_Load(object sender, EventArgs e)
		{

		}

		public void ClearColumns()
		{
			lvModel.Columns.Clear();
		}

		public void AddColumn(string label, int width)
		{
			lvModel.Columns.Add(label, width, HorizontalAlignment.Center);
		}

		protected override void OnParentChanged(EventArgs e)
		{
			base.OnParentChanged(e);

			Dock = DockStyle.None;
			Dock = DockStyle.Fill;
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void lsModelList_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnEditar_Click(sender, null);
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			Crud.EditingModel = Crud.CreateModel();
			Crud.Detail.Model = Crud.EditingModel;

			Crud.ShowDetail();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (lvModel.SelectedItems.Count > 0)
			{
				Crud.EditingModel = (ModelBase)lvModel.SelectedItems[0].Tag;
				Crud.ShowDetail();
			}
		}

		ControllerBase GetController() {
			var model = (ModelBase)Activator.CreateInstance(Crud.ModelType);
			return model.GetController();
		}

		public void LoadList()
		{
			if (Visible)
			{
				using (var ctx = Program.CreateContext())
				{
					var ctrl = GetController();
					ModelList = ctrl.LoadList<Empresa>(ctx);
				}
			}

			btnEditar.Enabled = false;
			btnRemover.Enabled = false;
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
		}

		private void lvModel_DoubleClick(object sender, EventArgs e)
		{
			btnEditar_Click(sender, null);
		}

		private void lvModel_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvModel.SelectedItems.Count > 0)
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
