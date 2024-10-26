using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using Case409_csv.model;
using System.Text;

namespace Case409_csv.Service
{
    // KENPO31.csv を作成するクラス
    public class CreateCsvService
    {
        // 照会結果住所だけを保存
        public void SaveKenpo31Csv(string outputPath, List<GetCsv> records)
        {
            // 文字コードを指定
            Encoding enc = Encoding.GetEncoding("Shift_JIS");
            try
            {
                // Shift-JIS エンコーディングでファイルを書き込む
                //                using (var writer = new StreamWriter(outputPath, false, Encoding.GetEncoding("Shift_JIS")))
                using (var writer = new StreamWriter(outputPath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                    Delimiter = ",",
                }))
                {
                    // 全プロパティをCSVに書き込む
                    csv.WriteRecords(records);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"CSV saving error: {ex.Message}");
            }
        }
    }
}
