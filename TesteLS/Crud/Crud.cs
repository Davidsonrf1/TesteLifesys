using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteLS.Models;

namespace TesteLS.CrudManaging
{
	public class Crud
	{
		public CrudDetail Detail { get; private set; }
		public CrudList List { get; private set; }
		public Type ModelType { get; private set; }
		public List<ModelBase> Dataset { get; private set; }
		public ModelBase EditingModel { get; private set; }

		IEnumerable<CrudDecoratorAttribute> GetDecorators()
		{
			foreach (var p in GetModelFields())
			{
				var a = p.GetCustomAttribute<CrudDecoratorAttribute>();

				if (a == null) // Se o decorador não foi definido, criamos um com base no campo da classe de modelo
				{
					a = new CrudDecoratorAttribute();
					a.Label = p.Name;
					a.Control = typeof(TextBox);
				}

				a.Property = p;
				yield return a;
			}
		}

		IEnumerable<PropertyInfo> GetModelFields()
		{
			foreach (var p in ModelType.GetProperties())
			{
				yield return p;
			}
		}

		void InitListColumns()
		{
			List.ClearColumns();

			foreach (var d in GetDecorators())
			{
				List.AddColumn(d.Label, d.Width);
			}
		}

		void CreateEditForm()
		{
			Detail.ClearFields();

			foreach (var d in GetDecorators())
			{
				if (!d.AllowEdit)
					continue;

				Type editor = d.Control;

				if (editor == null)
					editor = typeof(TextBox);

				Detail.AddField(d.Label, editor, d.Width);
			}
		}

		void Init()
		{
			InitListColumns();
			CreateEditForm();
		}

		public static Crud CreateCrud<T>(string listTitle, string detailTitle) where T: ModelBase, new()
		{
			var crud = new Crud();

			crud.Detail = new CrudDetail();
			crud.List = new CrudList();
			crud.ModelType = typeof(T);
			crud.Init();

			crud.List.lblTitle.Text = listTitle;

			return crud;
		}

		public void SetContainer(Control container)
		{
			container.Controls.Clear();
			container.Controls.Add(List);

			List.Visible = true;
		}
	}
}
