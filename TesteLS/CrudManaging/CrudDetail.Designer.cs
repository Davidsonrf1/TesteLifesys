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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lblTitle = new System.Windows.Forms.Label();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tbFields = new System.Windows.Forms.TableLayoutPanel();
			this.pnlControl = new System.Windows.Forms.Panel();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lblTitle);
			this.splitContainer1.Panel1MinSize = 40;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(899, 470);
			this.splitContainer1.SplitterDistance = 40;
			this.splitContainer1.TabIndex = 2;
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.DarkSlateGray;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("Carlito", 16F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(899, 40);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "label1";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.tbFields);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.pnlControl);
			this.splitContainer2.Size = new System.Drawing.Size(899, 426);
			this.splitContainer2.SplitterDistance = 356;
			this.splitContainer2.TabIndex = 0;
			// 
			// tbFields
			// 
			this.tbFields.ColumnCount = 1;
			this.tbFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tbFields.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbFields.Location = new System.Drawing.Point(0, 0);
			this.tbFields.Name = "tbFields";
			this.tbFields.RowCount = 1;
			this.tbFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tbFields.Size = new System.Drawing.Size(899, 356);
			this.tbFields.TabIndex = 2;
			this.tbFields.Paint += new System.Windows.Forms.PaintEventHandler(this.tbFields_Paint);
			// 
			// pnlControl
			// 
			this.pnlControl.Controls.Add(this.btnCancelar);
			this.pnlControl.Controls.Add(this.btnSalvar);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(899, 66);
			this.pnlControl.TabIndex = 1;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = global::TesteLS.Properties.Resources.Apps_CCleaner_Metro_icon;
			this.btnCancelar.Location = new System.Drawing.Point(474, 5);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(78, 58);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSalvar.FlatAppearance.BorderSize = 0;
			this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Image = global::TesteLS.Properties.Resources.Other_Save_Metro_icon;
			this.btnSalvar.Location = new System.Drawing.Point(360, 5);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(78, 58);
			this.btnSalvar.TabIndex = 1;
			this.btnSalvar.Text = "Gravar";
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// CrudDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.splitContainer1);
			this.Name = "CrudDetail";
			this.Size = new System.Drawing.Size(899, 470);
			this.Load += new System.EventHandler(this.CrudDetail_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.pnlControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TableLayoutPanel tbFields;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSalvar;
	}
}
