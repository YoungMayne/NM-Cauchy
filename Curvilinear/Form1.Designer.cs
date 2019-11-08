namespace Curvilinear
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
            this.Table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bxTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.axTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.byTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ayTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bzTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.azTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.stepsTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NColumn,
            this.Column1,
            this.Column2,
            this.Column3});
            this.Table.Location = new System.Drawing.Point(-42, 306);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.Size = new System.Drawing.Size(443, 356);
            this.Table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "N = ";
            // 
            // NTextBox
            // 
            this.NTextBox.Location = new System.Drawing.Point(284, 26);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(100, 20);
            this.NTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "a = ";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(283, 87);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 20);
            this.aTextBox.TabIndex = 4;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(283, 116);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 20);
            this.bTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "b = ";
            // 
            // bxTextBox
            // 
            this.bxTextBox.Location = new System.Drawing.Point(73, 193);
            this.bxTextBox.Name = "bxTextBox";
            this.bxTextBox.Size = new System.Drawing.Size(45, 20);
            this.bxTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "bx = ";
            // 
            // axTextBox
            // 
            this.axTextBox.Location = new System.Drawing.Point(73, 159);
            this.axTextBox.Name = "axTextBox";
            this.axTextBox.Size = new System.Drawing.Size(45, 20);
            this.axTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "ax = ";
            // 
            // byTextBox
            // 
            this.byTextBox.Location = new System.Drawing.Point(207, 194);
            this.byTextBox.Name = "byTextBox";
            this.byTextBox.Size = new System.Drawing.Size(45, 20);
            this.byTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "by = ";
            // 
            // ayTextBox
            // 
            this.ayTextBox.Location = new System.Drawing.Point(207, 160);
            this.ayTextBox.Name = "ayTextBox";
            this.ayTextBox.Size = new System.Drawing.Size(45, 20);
            this.ayTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "ay = ";
            // 
            // bzTextBox
            // 
            this.bzTextBox.Location = new System.Drawing.Point(338, 192);
            this.bzTextBox.Name = "bzTextBox";
            this.bzTextBox.Size = new System.Drawing.Size(45, 20);
            this.bzTextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "bz = ";
            // 
            // azTextBox
            // 
            this.azTextBox.Location = new System.Drawing.Point(338, 158);
            this.azTextBox.Name = "azTextBox";
            this.azTextBox.Size = new System.Drawing.Size(45, 20);
            this.azTextBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "az = ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Curvilinear.Properties.Resources.Formula2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(12, 220);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(371, 80);
            this.CalculateButton.TabIndex = 20;
            this.CalculateButton.Text = "CALCULATE";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // stepsTextBox
            // 
            this.stepsTextBox.Location = new System.Drawing.Point(284, 57);
            this.stepsTextBox.Name = "stepsTextBox";
            this.stepsTextBox.Size = new System.Drawing.Size(100, 20);
            this.stepsTextBox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(196, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "steps = ";
            // 
            // NColumn
            // 
            this.NColumn.HeaderText = "Ni";
            this.NColumn.Name = "NColumn";
            this.NColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NM";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MK1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MK2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 530);
            this.Controls.Add(this.stepsTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bzTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.azTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.byTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ayTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bxTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.axTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Title";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bxTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox axTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox byTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ayTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bzTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox azTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox stepsTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn NColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

