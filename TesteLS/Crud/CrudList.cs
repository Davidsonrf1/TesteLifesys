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
		public Crud Crud { get; private set; }

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

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void lsModelList_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			Crud.EditingModel = Crud.CreateModel();
			Crud.Detail.Model = Crud.EditingModel;

			Crud.ShowDetail();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{

		}
	}
}
