namespace TesteLS.CrudManaging
{
	partial class CrudField
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
			this.components = new System.ComponentModel.Container();
			this.pnlLabel = new System.Windows.Forms.Panel();
			this.lbFieldLabel = new System.Windows.Forms.Label();
			this.pnlEdit = new System.Windows.Forms.Panel();
			this.pbErrors = new System.Windows.Forms.PictureBox();
			this.tip = new System.Windows.Forms.ToolTip(this.components);
			this.pnlLabel.SuspendLayout();
			this.pnlEdit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbErrors)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlLabel
			// 
			this.pnlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlLabel.Controls.Add(this.lbFieldLabel);
			this.pnlLabel.Location = new System.Drawing.Point(3, 3);
			this.pnlLabel.Name = "pnlLabel";
			this.pnlLabel.Size = new System.Drawing.Size(242, 25);
			this.pnlLabel.TabIndex = 0;
			// 
			// lbFieldLabel
			// 
			this.lbFieldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFieldLabel.Location = new System.Drawing.Point(0, 0);
			this.lbFieldLabel.Name = "lbFieldLabel";
			this.lbFieldLabel.Size = new System.Drawing.Size(242, 25);
			this.lbFieldLabel.TabIndex = 0;
			this.lbFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbFieldLabel.Click += new System.EventHandler(this.lbFieldLabel_Click);
			// 
			// pnlEdit
			// 
			this.pnlEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlEdit.Controls.Add(this.pbErrors);
			this.pnlEdit.Location = new System.Drawing.Point(251, 3);
			this.pnlEdit.Name = "pnlEdit";
			this.pnlEdit.Size = new System.Drawing.Size(553, 25);
			this.pnlEdit.TabIndex = 1;
			// 
			// pbErrors
			// 
			this.pbErrors.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbErrors.Image = global::TesteLS.Properties.Resources.Button_Warning_icon;
			this.pbErrors.Location = new System.Drawing.Point(526, 0);
			this.pbErrors.Name = "pbErrors";
			this.pbErrors.Size = new System.Drawing.Size(27, 25);
			this.pbErrors.TabIndex = 0;
			this.pbErrors.TabStop = false;
			this.pbErrors.Visible = false;
			this.pbErrors.Click += new System.EventHandler(this.pbErrors_Click);
			// 
			// CrudField
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pnlEdit);
			this.Controls.Add(this.pnlLabel);
			this.Name = "CrudField";
			this.Size = new System.Drawing.Size(807, 31);
			this.Load += new System.EventHandler(this.CrudField_Load);
			this.pnlLabel.ResumeLayout(false);
			this.pnlEdit.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbErrors)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlLabel;
		private System.Windows.Forms.Label lbFieldLabel;
		private System.Windows.Forms.Panel pnlEdit;
		private System.Windows.Forms.PictureBox pbErrors;
		private System.Windows.Forms.ToolTip tip;
	}
}
