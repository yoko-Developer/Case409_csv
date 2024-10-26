using Case409_csv.service.databaseservice;
using Case409_csv.Service;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;

namespace Case409_csv
{
	public partial class Form1 : Form
	{
		private BindingSource bindingSource1 = new BindingSource();
		private SqlConnectionService _dbService;

		private String inputCsvFilePath = @"C:\Users\y-morioka\Documents\myWork\develop\C#\file\FI_JRK_0004.csv";
		private String outputCsvFilePath = @"C:\Users\y-morioka\Documents\myWork\develop\C#\file\KENPO31.csv";



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

			buttonLoadKA11.Text = "KA11LICH";
			buttonLoadKA12.Text = "KA12LICF";
			buttonLoadKA14.Text = "KA14HFUY";
			buttonLoadCsv.Text = "Load CSV";
			buttonSaveCsv.Text = "Save CSV";

			buttonLoadKA11.Click += buttonLoadKA11_Click;
			buttonLoadKA12.Click += buttonLoadKA12_Click;
			buttonLoadKA14.Click += buttonLoadKA14_Click;
			buttonLoadCsv.Click += buttonLoadCsv_Click;
			buttonSaveCsv.Click += buttonSaveCsv_Click;

			// ボタンをフォームに追加
			Controls.Add(buttonLoadKA11);
			Controls.Add(buttonLoadKA12);
			Controls.Add(buttonLoadKA14);
			Controls.Add(buttonLoadCsv);
			Controls.Add(buttonSaveCsv);
			Controls.Add(dataGridView1);
		}

		private void Form1_Resize(object? sender, EventArgs e)
		{
			// ボタンの位置とサイズの調整
			int buttonWidth = 100;
			int buttonHeight = 40;
			int buttonMargin = 10;
			int initialTop = 10;

			// tableボタンを左側に設定
			buttonLoadKA11.Location = new Point(buttonMargin, initialTop);
			buttonLoadKA11.Size = new Size(buttonWidth, buttonHeight);

			buttonLoadKA12.Location = new Point(buttonLoadKA11.Right + buttonMargin, initialTop);
			buttonLoadKA12.Size = new Size(buttonWidth, buttonHeight);

			buttonLoadKA14.Location = new Point(buttonLoadKA12.Right + buttonMargin, initialTop);
			buttonLoadKA14.Size = new Size(buttonWidth, buttonHeight);

			// CSVボタンを右端に設定
			int formWidth = ClientSize.Width;
			buttonLoadCsv.Location = new Point(formWidth - buttonWidth - buttonMargin, initialTop);
			buttonLoadCsv.Size = new Size(buttonWidth, buttonHeight);

			// CSV保存ボタンの位置調整
			buttonSaveCsv.Location = new Point(formWidth - 2 * buttonWidth - 2 * buttonMargin, initialTop);
			buttonSaveCsv.Size = new Size(buttonWidth, buttonHeight);


			// DataGridViewの配置とサイズ調整
			dataGridView1.Location = new Point(buttonMargin, buttonLoadKA11.Bottom + buttonMargin);
			dataGridView1.Size = new Size(ClientSize.Width - 2 * buttonMargin, ClientSize.Height - buttonLoadKA11.Bottom - 2 * buttonMargin);

			// サイズ調整に合わせてフォントサイズを調整
			dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 10);
			dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 13);
		}


		private void buttonLoadCsv_Click(object? sender, EventArgs e)
		{
			// CSVファイルを読み込み、DataGridViewに表示する処理
			try
			{
				var csvService = new GetCsvService(); // GetCsvService のインスタンスを作成
				var records = csvService.ReadCsv(inputCsvFilePath);

				// DataGridViewにデータを表示
				bindingSource1.DataSource = records;
				dataGridView1.DataSource = bindingSource1;
			}

			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "CSV loading error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonSaveCsv_Click(object? sender, EventArgs e)
		{
			// CSVファイルを保存する処理
			try
			{
				var records = bindingSource1.DataSource as IEnumerable<dynamic>;
				if (records == null)
				{
					MessageBox.Show("No data to save.", "Save CSV error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}


				// ファイルに書き込み
				using (var writer = new StreamWriter(outputCsvFilePath, false, System.Text.Encoding.GetEncoding("Shift_JIS")))
				using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))

				{
					csv.WriteRecords(records);
				}

				MessageBox.Show($"CSV file saved to {outputCsvFilePath}", "Save CSV success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// KENPO31.csv を再度読み込んでDataGridViewに表示
				LoadKenpo31CsvToGrid();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "CSV saving error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadKenpo31CsvToGrid()
		{
			// 保存時にKENPO31.csvを読み込んで表示する処理
			try
			{
				// KENPO31.csvを読み込む
				var csvService = new GetCsvService();
				var records = csvService.ReadCsv(outputCsvFilePath);

				// DataGridViewにKENPO31.csvのデータを表示
				bindingSource1.DataSource = records;
				dataGridView1.DataSource = bindingSource1;
			}
			catch(Exception ex)
			{
				MessageBox.Show($"Error:{ex.Message}", "CSV read error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void buttonLoadKA11_Click(object? sender, EventArgs e)
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
				MessageBox.Show($"DB connection error: {ex.Message}", "DB connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonLoadKA12_Click(object? sender, EventArgs e)
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
				MessageBox.Show($"DB connection error: {ex.Message}", "DB connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonLoadKA14_Click(object? sender, EventArgs e)
		{
			// KA14HFUY テーブルからデータ取得
			try
			{
				String query = "SELECT * FROM KA14HFUY";
				var dataTable = _dbService.GetData(query);
				bindingSource1.DataSource = dataTable;
				dataGridView1.DataSource = bindingSource1;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"DB connection error: {ex.Message}", "DB connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
		private IEnumerable<dynamic> TransformData(IEnumerable<dynamic> records)
		{
			return records;
		}
	}
}
		