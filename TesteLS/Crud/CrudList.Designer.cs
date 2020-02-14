namespace TesteLS.CrudManaging
{
	partial class CrudList
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
			this.lsModelList = new System.Windows.Forms.ListView();
			this.pnlControl = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lsModelList
			// 
			this.lsModelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lsModelList.HideSelection = false;
			this.lsModelList.Location = new System.Drawing.Point(3, 46);
			this.lsModelList.Name = "lsModelList";
			this.lsModelList.Size = new System.Drawing.Size(915, 243);
			this.lsModelList.TabIndex = 0;
			this.lsModelList.UseCompatibleStateImageBehavior = false;
			this.lsModelList.View = System.Windows.Forms.View.Details;
			// 
			// pnlControl
			// 
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlControl.Location = new System.Drawing.Point(0, 295);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(921, 64);
			this.pnlControl.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel1.Controls.Add(this.lblTitle);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(921, 40);
			this.panel1.TabIndex = 3;
			// 
			// lblTitle
			// 
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("Carlito", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(921, 40);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "label1";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CrudList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlControl);
			this.Controls.Add(this.lsModelList);
			this.Name = "CrudList";
			this.Size = new System.Drawing.Size(921, 359);
			this.Load += new System.EventHandler(this.CrudList_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlControl;
		public System.Windows.Forms.ListView lsModelList;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Label lblTitle;
	}
}
