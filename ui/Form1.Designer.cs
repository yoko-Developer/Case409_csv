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
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
  
            // 
            // buttonLoadCsv
            // 
            this.buttonLoadCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLoadCsv.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadCsv.Name = "buttonLoadCsv";
            this.buttonLoadCsv.Size = new System.Drawing.Size(75, 30);
            this.buttonLoadCsv.TabIndex = 1;
            this.buttonLoadCsv.Text = "Load CSV";
            this.buttonLoadCsv.UseVisualStyleBackColor = false;
            this.buttonLoadCsv.Click += new System.EventHandler(this.buttonLoadCsv_Click);

            // 
            // buttonLoadKA11
            // 
            this.buttonLoadKA11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLoadKA11.Location = new System.Drawing.Point(93, 12);
            this.buttonLoadKA11.Name = "buttonLoadKA11";
            this.buttonLoadKA11.Size = new System.Drawing.Size(75, 30);
            this.buttonLoadKA11.TabIndex = 2;
            this.buttonLoadKA11.Text = "Load KA11";
            this.buttonLoadKA11.UseVisualStyleBackColor = false;
            this.buttonLoadKA11.Click += new System.EventHandler(this.buttonLoadKA11_Click);

            // 
            // buttonLoadKA12
            // 
            this.buttonLoadKA12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLoadKA12.Location = new System.Drawing.Point(174, 12);
            this.buttonLoadKA12.Name = "buttonLoadKA12";
            this.buttonLoadKA12.Size = new System.Drawing.Size(75, 30);
            this.buttonLoadKA12.TabIndex = 3;
            this.buttonLoadKA12.Text = "Load KA12";
            this.buttonLoadKA12.UseVisualStyleBackColor = false;
            this.buttonLoadKA12.Click += new System.EventHandler(this.buttonLoadKA12_Click);
            // 
            // buttonLoadKA14
            // 
            this.buttonLoadKA14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonLoadKA14.Location = new System.Drawing.Point(255, 12);
            this.buttonLoadKA14.Name = "buttonLoadKA14";
            this.buttonLoadKA14.Size = new System.Drawing.Size(75, 30);
            this.buttonLoadKA14.TabIndex = 4;
            this.buttonLoadKA14.Text = "Load KA14";
            this.buttonLoadKA14.UseVisualStyleBackColor = false;
            this.buttonLoadKA14.Click += new System.EventHandler(this.buttonLoadKA14_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoadKA14);
            this.Controls.Add(this.buttonLoadKA12);
            this.Controls.Add(this.buttonLoadKA11);
            this.Controls.Add(this.buttonLoadCsv);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "CSV and DB Loader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
