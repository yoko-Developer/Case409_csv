using Case409_csv.Service; // GetCsvService クラスの名前空間を追加

namespace Case409_csv
{
    public partial class Form1 : Form
    {
        // フィールドの定義を追加
        private BindingSource bindingSource1 = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            // BindingSource を初期化
            dataGridView1.DataSource = bindingSource1;

            // フォームの初期サイズを設定
            this.ClientSize = new System.Drawing.Size(800, 600);

            // DataGridViewの配置とサイズ設定（フォームサイズに連動）
            dataGridView1.Location = new System.Drawing.Point(10, buttonLoadCsv.Bottom + 10);
            dataGridView1.Size = new System.Drawing.Size(this.ClientSize.Width - 20, this.ClientSize.Height - buttonLoadCsv.Height - 40);
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 13);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 13);

            // ボタンの配置とサイズ設定（フォームサイズに連動）
            buttonLoadCsv.Location = new System.Drawing.Point(10, 10);
            buttonLoadCsv.Size = new System.Drawing.Size(100, 30);
            buttonLoadCsv.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            buttonLoadCsv.Font = new Font(buttonLoadCsv.Font.FontFamily, 13);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // フォームがロードされたときの処理を記述する
        }

        private void buttonLoadCsv_Click(object sender, EventArgs e)
        {
            // ボタンクリック時、CSVファイルを読み込む
            try
            {
                var csvService = new GetCsvService(); // GetCsvService のインスタンスを作成
                var records = csvService.ReadCsv(@"C:\Users\y-morioka\Documents\FI_JRK_0004.csv");

                // 取得したデータを DataGridView にバインドする
                bindingSource1.DataSource = records;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
