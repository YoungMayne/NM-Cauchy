namespace RandomValue
{
    partial class Form1
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
            this.Graph = new ZedGraph.ZedGraphControl();
            this.Table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpectationLabel = new System.Windows.Forms.Label();
            this.asdfg = new System.Windows.Forms.Label();
            this.DispersionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SampleRangeValueLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FacionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MedianLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            this.Graph.IsShowPointValues = false;
            this.Graph.Location = new System.Drawing.Point(12, 306);
            this.Graph.Name = "Graph";
            this.Graph.PointValueFormat = "G";
            this.Graph.Size = new System.Drawing.Size(512, 371);
            this.Graph.TabIndex = 0;
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Table.Location = new System.Drawing.Point(252, 12);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.Size = new System.Drawing.Size(272, 288);
            this.Table.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "i";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Xi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Pi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Число разбиений";
            // 
            // nUpDown
            // 
            this.nUpDown.Location = new System.Drawing.Point(111, 20);
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.Size = new System.Drawing.Size(120, 20);
            this.nUpDown.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Мат ожидание";
            // 
            // ExpectationLabel
            // 
            this.ExpectationLabel.AutoSize = true;
            this.ExpectationLabel.Location = new System.Drawing.Point(108, 80);
            this.ExpectationLabel.Name = "ExpectationLabel";
            this.ExpectationLabel.Size = new System.Drawing.Size(13, 13);
            this.ExpectationLabel.TabIndex = 5;
            this.ExpectationLabel.Text = "0";
            // 
            // asdfg
            // 
            this.asdfg.AutoSize = true;
            this.asdfg.Location = new System.Drawing.Point(9, 107);
            this.asdfg.Name = "asdfg";
            this.asdfg.Size = new System.Drawing.Size(64, 13);
            this.asdfg.TabIndex = 6;
            this.asdfg.Text = "Дисперсия";
            // 
            // DispersionLabel
            // 
            this.DispersionLabel.AutoSize = true;
            this.DispersionLabel.Location = new System.Drawing.Point(108, 107);
            this.DispersionLabel.Name = "DispersionLabel";
            this.DispersionLabel.Size = new System.Drawing.Size(13, 13);
            this.DispersionLabel.TabIndex = 7;
            this.DispersionLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Размах выборки";
            // 
            // SampleRangeValueLabel
            // 
            this.SampleRangeValueLabel.AutoSize = true;
            this.SampleRangeValueLabel.Location = new System.Drawing.Point(108, 53);
            this.SampleRangeValueLabel.Name = "SampleRangeValueLabel";
            this.SampleRangeValueLabel.Size = new System.Drawing.Size(13, 13);
            this.SampleRangeValueLabel.TabIndex = 9;
            this.SampleRangeValueLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Мода";
            // 
            // FacionLabel
            // 
            this.FacionLabel.AutoSize = true;
            this.FacionLabel.Location = new System.Drawing.Point(108, 134);
            this.FacionLabel.Name = "FacionLabel";
            this.FacionLabel.Size = new System.Drawing.Size(13, 13);
            this.FacionLabel.TabIndex = 11;
            this.FacionLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Медиана";
            // 
            // MedianLabel
            // 
            this.MedianLabel.AutoSize = true;
            this.MedianLabel.Location = new System.Drawing.Point(108, 161);
            this.MedianLabel.Name = "MedianLabel";
            this.MedianLabel.Size = new System.Drawing.Size(13, 13);
            this.MedianLabel.TabIndex = 13;
            this.MedianLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MedianLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FacionLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SampleRangeValueLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DispersionLabel);
            this.Controls.Add(this.asdfg);
            this.Controls.Add(this.ExpectationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Graph);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl Graph;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ExpectationLabel;
        private System.Windows.Forms.Label asdfg;
        private System.Windows.Forms.Label DispersionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SampleRangeValueLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FacionLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MedianLabel;
        private System.Windows.Forms.Button button1;
    }
}