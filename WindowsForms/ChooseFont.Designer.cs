namespace WindowsForms
{
	partial class ChooseFont
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFont));
			this.lblChooseFont = new System.Windows.Forms.Label();
			this.comboBoxChooseFont = new System.Windows.Forms.ComboBox();
			this.lblExample = new System.Windows.Forms.Label();
			this.lblFilename = new System.Windows.Forms.Label();
			this.nudFontSize = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
			this.SuspendLayout();
			// 
			// lblChooseFont
			// 
			this.lblChooseFont.AutoSize = true;
			this.lblChooseFont.Location = new System.Drawing.Point(13, 13);
			this.lblChooseFont.Name = "lblChooseFont";
			this.lblChooseFont.Size = new System.Drawing.Size(118, 16);
			this.lblChooseFont.TabIndex = 0;
			this.lblChooseFont.Text = "Выберите шрифт";
			// 
			// comboBoxChooseFont
			// 
			this.comboBoxChooseFont.FormattingEnabled = true;
			this.comboBoxChooseFont.Location = new System.Drawing.Point(16, 54);
			this.comboBoxChooseFont.Name = "comboBoxChooseFont";
			this.comboBoxChooseFont.Size = new System.Drawing.Size(392, 24);
			this.comboBoxChooseFont.TabIndex = 1;
			// 
			// lblExample
			// 
			this.lblExample.AutoSize = true;
			this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblExample.Location = new System.Drawing.Point(12, 240);
			this.lblExample.Name = "lblExample";
			this.lblExample.Size = new System.Drawing.Size(238, 63);
			this.lblExample.TabIndex = 2;
			this.lblExample.Text = "Example";
			// 
			// lblFilename
			// 
			this.lblFilename.AutoSize = true;
			this.lblFilename.Location = new System.Drawing.Point(13, 115);
			this.lblFilename.Name = "lblFilename";
			this.lblFilename.Size = new System.Drawing.Size(66, 16);
			this.lblFilename.TabIndex = 3;
			this.lblFilename.Text = "Filename:";
			// 
			// nudFontSize
			// 
			this.nudFontSize.Location = new System.Drawing.Point(427, 55);
			this.nudFontSize.Name = "nudFontSize";
			this.nudFontSize.Size = new System.Drawing.Size(85, 22);
			this.nudFontSize.TabIndex = 4;
			// 
			// ChooseFont
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 312);
			this.Controls.Add(this.nudFontSize);
			this.Controls.Add(this.lblFilename);
			this.Controls.Add(this.lblExample);
			this.Controls.Add(this.comboBoxChooseFont);
			this.Controls.Add(this.lblChooseFont);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ChooseFont";
			this.Text = "ChooseFont";
			((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblChooseFont;
		private System.Windows.Forms.ComboBox comboBoxChooseFont;
		private System.Windows.Forms.Label lblExample;
		private System.Windows.Forms.Label lblFilename;
		private System.Windows.Forms.NumericUpDown nudFontSize;
	}
}