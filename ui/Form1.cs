using Case409_csv.Service; // GetCsvService クラスの名前空間を追加
using Case409_csv.service.databaseservice;

namespace Case409_csv
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlConnectionService _dbService;
 
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = bindingSource1;

            // SqlConnectionService初期化
            String connectionString = "Server=DUE-N112;Database=kw21;User Id=sa;Password=sa;";
            _dbService = new SqlConnectionService(connectionString);

            // CSV読み込みボタンの配置とサイズ設定
            buttonLoadCsv.Location = new System.Drawing.Point(10, 10);
            buttonLoadCsv.Size = new System.Drawing.Size(100,30);
            buttonLoadCsv.Text = "LoadCSV";
            buttonLoadCsv.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            buttonLoadCsv.Font = new Font(buttonLoadCsv.Font.FontFamily, 10);
            buttonLoadCsv.TextAlign = ContentAlignment.MiddleCenter;
            buttonLoadCsv.Padding = new Padding(0);
            buttonLoadCsv.Click += buttonLoadCsv_Click;

            // データベースからデータ取得ボタンの配置とサイズ設定
            buttonLoadDb.Location = new System.Drawing.Point(buttonLoadCsv.Right + 10, 10);
            buttonLoadDb.Size = new System.Drawing.Size(100, 30);
            buttonLoadDb.Text = "DBConnect";
            buttonLoadDb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            buttonLoadDb.Font = new Font(buttonLoadDb.Font.FontFamily, 10);
            buttonLoadDb.TextAlign = ContentAlignment.MiddleCenter;
            buttonLoadCsv.Padding = new Padding(0);
            buttonLoadDb.Click += buttonLoadDb_Click;
            Controls.Add(buttonLoadDb);

            // DataGridViewの配置とサイズ設定（フォームサイズに連動）
            dataGridView1.Location = new System.Drawing.Point(10, buttonLoadCsv.Bottom + 10);
            dataGridView1.Size = new System.Drawing.Size(this.ClientSize.Width - 20, this.ClientSize.Height - buttonLoadCsv.Height - 40);
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 13);
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void buttonLoadCsv_Click(object sender, EventArgs e)
        {
            // CSVファイルを読み込み、DataGridViewに表示する処理
            try
            {
                var csvService = new GetCsvService(); // GetCsvService のインスタンスを作成
                var records = csvService.ReadCsv(@"C:\Users\y-morioka\Documents\FI_JRK_0004.csv");

                bindingSource1.DataSource = records;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonLoadDb_Click(object sender, EventArgs e)
        {
            // SQL Server からデータを取得し、DataGridViewに表示する処理
            try
            {
                String query = "SELECT * FROM KA11LICH";
                var dataTable = _dbService.GetData(query);

                bindingSource1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
