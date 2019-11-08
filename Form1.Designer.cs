namespace Couchy
{
	partial class MainForm
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
            this.MainGraph = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MK1Label = new System.Windows.Forms.Label();
            this.MK2Label = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.NMLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGraph
            // 
            this.MainGraph.IsShowPointValues = false;
            this.MainGraph.Location = new System.Drawing.Point(230, 12);
            this.MainGraph.Name = "MainGraph";
            this.MainGraph.PointValueFormat = "G";
            this.MainGraph.Size = new System.Drawing.Size(719, 526);
            this.MainGraph.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "N = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "a  = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "b  = ";
            // 
            // NTextBox
            // 
            this.NTextBox.Location = new System.Drawing.Point(65, 64);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(100, 20);
            this.NTextBox.TabIndex = 4;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(65, 87);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 20);
            this.aTextBox.TabIndex = 5;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(65, 110);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 20);
            this.bTextBox.TabIndex = 6;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.Window;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(26, 500);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(139, 38);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Calculate";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Couchy.Properties.Resources.Formula;
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "MK1";
            // 
            // MK1Label
            // 
            this.MK1Label.AutoSize = true;
            this.MK1Label.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MK1Label.Location = new System.Drawing.Point(62, 371);
            this.MK1Label.Name = "MK1Label";
            this.MK1Label.Size = new System.Drawing.Size(0, 17);
            this.MK1Label.TabIndex = 10;
            // 
            // MK2Label
            // 
            this.MK2Label.AutoSize = true;
            this.MK2Label.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MK2Label.Location = new System.Drawing.Point(62, 397);
            this.MK2Label.Name = "MK2Label";
            this.MK2Label.Size = new System.Drawing.Size(0, 17);
            this.MK2Label.TabIndex = 12;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(14, 397);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(43, 17);
            this.label.TabIndex = 11;
            this.label.Text = "MK2";
            // 
            // NMLabel
            // 
            this.NMLabel.AutoSize = true;
            this.NMLabel.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NMLabel.Location = new System.Drawing.Point(62, 424);
            this.NMLabel.Name = "NMLabel";
            this.NMLabel.Size = new System.Drawing.Size(0, 17);
            this.NMLabel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "NM";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 550);
            this.Controls.Add(this.NMLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MK2Label);
            this.Controls.Add(this.label);
            this.Controls.Add(this.MK1Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.NTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Caushy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private ZedGraph.ZedGraphControl MainGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MK1Label;
        private System.Windows.Forms.Label MK2Label;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label NMLabel;
        private System.Windows.Forms.Label label6;
    }
}

