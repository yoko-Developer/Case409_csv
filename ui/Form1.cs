using Case409_csv.Service; // GetCsvService �N���X�̖��O��Ԃ�ǉ�

namespace Case409_csv
{
    public partial class Form1 : Form
    {
        // �t�B�[���h�̒�`��ǉ�
        private BindingSource bindingSource1 = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            // BindingSource ��������
            dataGridView1.DataSource = bindingSource1;

            // �t�H�[���̏����T�C�Y��ݒ�
            this.ClientSize = new System.Drawing.Size(800, 600);

            // DataGridView�̔z�u�ƃT�C�Y�ݒ�i�t�H�[���T�C�Y�ɘA���j
            dataGridView1.Location = new System.Drawing.Point(10, buttonLoadCsv.Bottom + 10);
            dataGridView1.Size = new System.Drawing.Size(this.ClientSize.Width - 20, this.ClientSize.Height - buttonLoadCsv.Height - 40);
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 13);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 13);

            // �{�^���̔z�u�ƃT�C�Y�ݒ�i�t�H�[���T�C�Y�ɘA���j
            buttonLoadCsv.Location = new System.Drawing.Point(10, 10);
            buttonLoadCsv.Size = new System.Drawing.Size(100, 30);
            buttonLoadCsv.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            buttonLoadCsv.Font = new Font(buttonLoadCsv.Font.FontFamily, 13);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // �t�H�[�������[�h���ꂽ�Ƃ��̏������L�q����
        }

        private void buttonLoadCsv_Click(object sender, EventArgs e)
        {
            // �{�^���N���b�N���ACSV�t�@�C����ǂݍ���
            try
            {
                var csvService = new GetCsvService(); // GetCsvService �̃C���X�^���X���쐬
                var records = csvService.ReadCsv(@"C:\Users\y-morioka\Documents\FI_JRK_0004.csv");

                // �擾�����f�[�^�� DataGridView �Ƀo�C���h����
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
