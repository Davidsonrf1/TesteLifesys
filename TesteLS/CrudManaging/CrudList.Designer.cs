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
			this.lvModel = new System.Windows.Forms.ListView();
			this.pnlControl = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.pnlControl.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvModel
			// 
			this.lvModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvModel.FullRowSelect = true;
			this.lvModel.GridLines = true;
			this.lvModel.HideSelection = false;
			this.lvModel.Location = new System.Drawing.Point(3, 46);
			this.lvModel.MultiSelect = false;
			this.lvModel.Name = "lvModel";
			this.lvModel.Size = new System.Drawing.Size(866, 363);
			this.lvModel.TabIndex = 0;
			this.lvModel.UseCompatibleStateImageBehavior = false;
			this.lvModel.View = System.Windows.Forms.View.Details;
			this.lvModel.SelectedIndexChanged += new System.EventHandler(this.lvModel_SelectedIndexChanged);
			this.lvModel.DoubleClick += new System.EventHandler(this.lvModel_DoubleClick);
			// 
			// pnlControl
			// 
			this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlControl.BackColor = System.Drawing.Color.White;
			this.pnlControl.Controls.Add(this.btnRemover);
			this.pnlControl.Controls.Add(this.btnEditar);
			this.pnlControl.Controls.Add(this.btnNovo);
			this.pnlControl.Location = new System.Drawing.Point(3, 415);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(866, 64);
			this.pnlControl.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel1.Controls.Add(this.lblTitle);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(872, 40);
			this.panel1.TabIndex = 3;
			// 
			// lblTitle
			// 
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("Carlito", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(872, 40);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "label1";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnRemover
			// 
			this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnRemover.FlatAppearance.BorderSize = 0;
			this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemover.Image = global::TesteLS.Properties.Resources.Apps_Disk_Cleanup_Metro_icon;
			this.btnRemover.Location = new System.Drawing.Point(476, 3);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(78, 58);
			this.btnRemover.TabIndex = 2;
			this.btnRemover.Text = "Remover";
			this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Image = global::TesteLS.Properties.Resources.Apps_Notepad_Metro_icon;
			this.btnEditar.Location = new System.Drawing.Point(392, 3);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(78, 58);
			this.btnEditar.TabIndex = 1;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnNovo
			// 
			this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnNovo.FlatAppearance.BorderSize = 0;
			this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovo.Image = global::TesteLS.Properties.Resources.Web_Google_Docs_Metro_icon;
			this.btnNovo.Location = new System.Drawing.Point(308, 3);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(78, 58);
			this.btnNovo.TabIndex = 0;
			this.btnNovo.Text = "Novo";
			this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnNovo.UseVisualStyleBackColor = true;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// CrudList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlControl);
			this.Controls.Add(this.lvModel);
			this.Name = "CrudList";
			this.Size = new System.Drawing.Size(872, 479);
			this.Load += new System.EventHandler(this.CrudList_Load);
			this.pnlControl.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlControl;
		public System.Windows.Forms.ListView lvModel;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Button btnEditar;
	}
}
