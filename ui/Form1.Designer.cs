namespace Case409_csv
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLoadCsv;

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonLoadCsv = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 397);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // buttonLoadCsv
            // 
            buttonLoadCsv.BackColor = Color.FromArgb(255, 128, 255);
            buttonLoadCsv.Location = new Point(12, 12);
            buttonLoadCsv.Name = "buttonLoadCsv";
            buttonLoadCsv.Size = new Size(75, 25);
            buttonLoadCsv.TabIndex = 1;
            buttonLoadCsv.Text = "LOADING";
            buttonLoadCsv.UseVisualStyleBackColor = false;
            buttonLoadCsv.Click += buttonLoadCsv_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoadCsv);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}
