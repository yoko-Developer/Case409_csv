namespace Case409_csv
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLoadCsv;
        private System.Windows.Forms.Button buttonLoadKA11;
        private System.Windows.Forms.Button buttonLoadKA12;
        private System.Windows.Forms.Button buttonLoadKA14;

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonLoadCsv = new Button();
            buttonLoadKA11 = new Button();
            buttonLoadKA12 = new Button();
            buttonLoadKA14 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 388);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // buttonLoadCsv
            // 
            buttonLoadCsv.BackColor = Color.FromArgb(255, 192, 255);
            buttonLoadCsv.Location = new Point(12, 12);
            buttonLoadCsv.Name = "buttonLoadCsv";
            buttonLoadCsv.Size = new Size(75, 30);
            buttonLoadCsv.TabIndex = 1;
            buttonLoadCsv.Text = "Load CSV";
            buttonLoadCsv.UseVisualStyleBackColor = false;
            buttonLoadCsv.Click += buttonLoadCsv_Click;
            // 
            // buttonLoadKA11
            // 
            buttonLoadKA11.BackColor = Color.FromArgb(192, 255, 255);
            buttonLoadKA11.Location = new Point(93, 12);
            buttonLoadKA11.Name = "buttonLoadKA11";
            buttonLoadKA11.Size = new Size(75, 30);
            buttonLoadKA11.TabIndex = 2;
            buttonLoadKA11.Text = "KA11LICH";
            buttonLoadKA11.UseVisualStyleBackColor = false;
            buttonLoadKA11.Click += buttonLoadKA11_Click;
            // 
            // buttonLoadKA12
            // 
            buttonLoadKA12.BackColor = Color.FromArgb(192, 255, 255);
            buttonLoadKA12.Location = new Point(174, 12);
            buttonLoadKA12.Name = "buttonLoadKA12";
            buttonLoadKA12.Size = new Size(75, 30);
            buttonLoadKA12.TabIndex = 3;
            buttonLoadKA12.Text = "KA12LICF";
            buttonLoadKA12.UseVisualStyleBackColor = false;
            buttonLoadKA12.Click += buttonLoadKA12_Click;
            // 
            // buttonLoadKA14
            // 
            buttonLoadKA14.BackColor = Color.FromArgb(192, 255, 255);
            buttonLoadKA14.Location = new Point(255, 12);
            buttonLoadKA14.Name = "buttonLoadKA14";
            buttonLoadKA14.Size = new Size(75, 30);
            buttonLoadKA14.TabIndex = 4;
            buttonLoadKA14.Text = "KA14HFUY";
            buttonLoadKA14.UseVisualStyleBackColor = false;
            buttonLoadKA14.Click += buttonLoadKA14_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(804, 452);
            Controls.Add(buttonLoadKA14);
            Controls.Add(buttonLoadKA12);
            Controls.Add(buttonLoadKA11);
            Controls.Add(buttonLoadCsv);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "CSV creation tool";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}
