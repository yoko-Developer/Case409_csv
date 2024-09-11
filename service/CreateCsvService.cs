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
        public void SaveKenpo31Csv(string outputPath, List<dynamic> records)
        {
            try
            {
                // Shift-JIS エンコーディングでファイルを書き込む
                using (var writer = new StreamWriter(outputPath, false, Encoding.GetEncoding("Shift_JIS")))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                    Delimiter = ",",
                }))
                {
                    // 照会結果住所だけを抽出して新しい CSV に書き込む
                    var kenpo31Records = records.Select(record => new Kenpo31Record
                    {
                        InquiryResultAddress = record.照会結果住所
                    }).ToList();

                    csv.WriteRecords(kenpo31Records);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"CSV saving error: {ex.Message}");
            }
        }
    }
}
