using Case409_csv.service.databaseservice;
using Case409_csv.Service;

namespace Case409_csv
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlConnectionService _dbService;

        public Form1()
        {
          InitializeComponent();
            InitializeAdditionalComponents();

            // SqlConnectionService初期化
            String connectionString = "Server=DUE-N112;Database=kw21;User Id=sa;Password=sa;";
            _dbService = new SqlConnectionService(connectionString);


            // Formのリサイズに応じて自動的にサイズ調整する
            this.Resize += new EventHandler(Form1_Resize);
            Form1_Resize(this, EventArgs.Empty);
        }

       
        private void InitializeAdditionalComponents()
        {
        
            buttonLoadKA11.Click += buttonLoadKA11_Click;
            buttonLoadKA12.Click += buttonLoadKA12_Click;
            buttonLoadKA14.Click += buttonLoadKA14_Click;
            buttonLoadDb.Click += buttonLoadDb_Click;
            buttonLoadCsv.Click += buttonLoadCsv_Click;

            // ボタンをフォームに追加
            Controls.Add(buttonLoadKA11);
            Controls.Add(buttonLoadKA12);
            Controls.Add(buttonLoadKA14);
            Controls.Add(buttonLoadDb);
            Controls.Add(buttonLoadCsv);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // ボタンの位置とサイズの調整
            int buttonWidth = 100;
            int buttonHeight = 30;
            int buttonMargin  = 10;
            int initialTop = 10;

            buttonLoadKA11.Location = new Point(buttonMargin, initialTop);
            buttonLoadKA11.Size = new Size(buttonWidth, buttonHeight);

            buttonLoadKA12.Location = new Point(buttonLoadKA11.Right + buttonMargin, initialTop);
            buttonLoadKA12.Size = new Size(buttonWidth, buttonHeight);

            buttonLoadKA14.Location = new Point(buttonLoadKA12.Right + buttonMargin, initialTop);
            buttonLoadKA14.Size = new Size(buttonWidth, buttonHeight);

            buttonLoadDb.Location = new Point(buttonLoadKA14.Right + buttonMargin, initialTop);
            buttonLoadDb.Size = new Size(buttonWidth, buttonHeight);

            buttonLoadCsv.Location = new Point(buttonLoadDb.Right + buttonMargin, initialTop);
            buttonLoadCsv.Size = new Size(buttonWidth, buttonHeight);

            // DataGridViewの配置とサイズ調整
            dataGridView1.Location = new Point(buttonMargin, buttonLoadKA11.Bottom + buttonMargin);
            dataGridView1.Size = new Size(ClientSize.Width - 2 * buttonMargin, ClientSize.Height - buttonLoadKA11.Bottom - 2 * buttonMargin);

            // サイズ調整に合わせてフォントサイズを調整
            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 13);
        }


        private void buttonLoadCsv_Click(object sender, EventArgs e)
        {
            // CSVファイルを読み込み、DataGridViewに表示する処理
            try
            {
                var csvService = new GetCsvService(); // GetCsvService のインスタンスを作成
                var records = csvService.ReadCsv(@"C:\Users\y-morioka\Documents\myWork\開発\案件409\c#\file\FI_JRK_0004.csv");

                bindingSource1.DataSource = records;
                dataGridView1.DataSource = bindingSource1;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonLoadKA11_Click(object sender, EventArgs e)
        {
            // KA11LICH テーブルからデータ取得
            try
            {
                String query = "SELECT * FROM KA11LICH";
                var dataTable = _dbService.GetData(query);

                bindingSource1.DataSource = dataTable;
                    dataGridView1.DataSource = bindingSource1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonLoadKA12_Click(object sender, EventArgs e)
        {
            // KA12LICF テーブルからデータ取得
            try
            {
                String query = "SELECT * FROM KA12LICF";
                var dataTable = _dbService.GetData(query);

                bindingSource1.DataSource = dataTable;
                dataGridView1.DataSource = bindingSource1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonLoadKA14_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "SELECT * FROM KA14HFUY";
                var dataTable = _dbService.GetData(query);
                bindingSource1.DataSource = dataTable;
                dataGridView1.DataSource = bindingSource1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonLoadDb_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Load DB button clicked.");
            
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // ヘッダーセルのクリックを防ぐ
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // クリックされたセルの値を取得
                var cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // セルの値を表示する
                MessageBox.Show($"クリックされたセルの内容: {cellValue}");

            }
        }
    }

}
