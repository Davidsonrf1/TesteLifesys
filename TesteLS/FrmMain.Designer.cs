namespace TesteLS
{
	partial class FrmMain
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.mainContainer = new System.Windows.Forms.SplitContainer();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnFornecedores = new System.Windows.Forms.Button();
			this.btnEmpresa = new System.Windows.Forms.Button();
			this.pnlMainContainer = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
			this.mainContainer.Panel1.SuspendLayout();
			this.mainContainer.Panel2.SuspendLayout();
			this.mainContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainContainer
			// 
			this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.mainContainer.Location = new System.Drawing.Point(0, 0);
			this.mainContainer.Name = "mainContainer";
			// 
			// mainContainer.Panel1
			// 
			this.mainContainer.Panel1.Controls.Add(this.btnSair);
			this.mainContainer.Panel1.Controls.Add(this.btnFornecedores);
			this.mainContainer.Panel1.Controls.Add(this.btnEmpresa);
			// 
			// mainContainer.Panel2
			// 
			this.mainContainer.Panel2.Controls.Add(this.pnlMainContainer);
			this.mainContainer.Size = new System.Drawing.Size(1096, 674);
			this.mainContainer.SplitterDistance = 139;
			this.mainContainer.TabIndex = 0;
			// 
			// btnSair
			// 
			this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.FlatAppearance.BorderSize = 0;
			this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Image = global::TesteLS.Properties.Resources.exit;
			this.btnSair.Location = new System.Drawing.Point(8, 532);
			this.btnSair.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(123, 130);
			this.btnSair.TabIndex = 2;
			this.btnSair.Text = "Sair";
			this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnFornecedores
			// 
			this.btnFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFornecedores.FlatAppearance.BorderSize = 0;
			this.btnFornecedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFornecedores.Image = global::TesteLS.Properties.Resources.Fornecedor;
			this.btnFornecedores.Location = new System.Drawing.Point(8, 160);
			this.btnFornecedores.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
			this.btnFornecedores.Name = "btnFornecedores";
			this.btnFornecedores.Size = new System.Drawing.Size(123, 130);
			this.btnFornecedores.TabIndex = 1;
			this.btnFornecedores.Text = "Fornecedores";
			this.btnFornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnFornecedores.UseVisualStyleBackColor = true;
			this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
			// 
			// btnEmpresa
			// 
			this.btnEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEmpresa.FlatAppearance.BorderSize = 0;
			this.btnEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEmpresa.Image = global::TesteLS.Properties.Resources.Empresa;
			this.btnEmpresa.Location = new System.Drawing.Point(8, 12);
			this.btnEmpresa.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
			this.btnEmpresa.Name = "btnEmpresa";
			this.btnEmpresa.Size = new System.Drawing.Size(123, 130);
			this.btnEmpresa.TabIndex = 0;
			this.btnEmpresa.Text = "Empresas";
			this.btnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEmpresa.UseVisualStyleBackColor = true;
			this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
			// 
			// pnlMainContainer
			// 
			this.pnlMainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMainContainer.Location = new System.Drawing.Point(0, 0);
			this.pnlMainContainer.Name = "pnlMainContainer";
			this.pnlMainContainer.Size = new System.Drawing.Size(953, 674);
			this.pnlMainContainer.TabIndex = 0;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1096, 674);
			this.Controls.Add(this.mainContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmMain";
			this.Text = "Teste";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.mainContainer.Panel1.ResumeLayout(false);
			this.mainContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
			this.mainContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer mainContainer;
		private System.Windows.Forms.Button btnEmpresa;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnFornecedores;
		private System.Windows.Forms.Panel pnlMainContainer;
	}
}

