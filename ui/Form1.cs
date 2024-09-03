using Case409_csv.Service; // GetCsvService �N���X�̖��O��Ԃ�ǉ�
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

            // SqlConnectionService������
            String connectionString = "Server=DUE-N112;Database=kw21;User Id=sa;Password=sa;";
            _dbService = new SqlConnectionService(connectionString);

            // CSV�ǂݍ��݃{�^���̔z�u�ƃT�C�Y�ݒ�
            buttonLoadCsv.Location = new System.Drawing.Point(10, 10);
            buttonLoadCsv.Size = new System.Drawing.Size(100,30);
            buttonLoadCsv.Text = "LoadCSV";
            buttonLoadCsv.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            buttonLoadCsv.Font = new Font(buttonLoadCsv.Font.FontFamily, 10);
            buttonLoadCsv.TextAlign = ContentAlignment.MiddleCenter;
            buttonLoadCsv.Padding = new Padding(0);
            buttonLoadCsv.Click += buttonLoadCsv_Click;

            // �f�[�^�x�[�X����f�[�^�擾�{�^���̔z�u�ƃT�C�Y�ݒ�
            buttonLoadDb.Location = new System.Drawing.Point(buttonLoadCsv.Right + 10, 10);
            buttonLoadDb.Size = new System.Drawing.Size(100, 30);
            buttonLoadDb.Text = "DBConnect";
            buttonLoadDb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            buttonLoadDb.Font = new Font(buttonLoadDb.Font.FontFamily, 10);
            buttonLoadDb.TextAlign = ContentAlignment.MiddleCenter;
            buttonLoadCsv.Padding = new Padding(0);
            buttonLoadDb.Click += buttonLoadDb_Click;
            Controls.Add(buttonLoadDb);

            // DataGridView�̔z�u�ƃT�C�Y�ݒ�i�t�H�[���T�C�Y�ɘA���j
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
            // CSV�t�@�C����ǂݍ��݁ADataGridView�ɕ\�����鏈��
            try
            {
                var csvService = new GetCsvService(); // GetCsvService �̃C���X�^���X���쐬
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
            // SQL Server ����f�[�^���擾���ADataGridView�ɕ\�����鏈��
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
