namespace TesteLS.CrudManaging
{
	partial class CrudDetail
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlControl = new System.Windows.Forms.Panel();
			this.tbFields = new System.Windows.Forms.TableLayoutPanel();
			this.SuspendLayout();
			// 
			// pnlControl
			// 
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlControl.Location = new System.Drawing.Point(0, 247);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(654, 67);
			this.pnlControl.TabIndex = 0;
			// 
			// tbFields
			// 
			this.tbFields.ColumnCount = 1;
			this.tbFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tbFields.Location = new System.Drawing.Point(3, 3);
			this.tbFields.Name = "tbFields";
			this.tbFields.RowCount = 1;
			this.tbFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tbFields.Size = new System.Drawing.Size(650, 240);
			this.tbFields.TabIndex = 1;
			// 
			// CrudDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.tbFields);
			this.Controls.Add(this.pnlControl);
			this.Name = "CrudDetail";
			this.Size = new System.Drawing.Size(654, 314);
			this.Load += new System.EventHandler(this.CrudDetail_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.TableLayoutPanel tbFields;
	}
}
