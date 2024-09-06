using CsvHelper;
using System.Globalization;
using System.Text;
using Case409_csv.model;
using CsvHelper.Configuration;

namespace Case409_csv.Service
{

    // CSVファイルを取得するクラス
    public class GetCsvService
    {
        public List<GetCsv> ReadCsv(string filePath)
        {
            try
            {
                // エンコーディングプロバイダを登録
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                // Shift-JIS エンコーディングで CSV ファイルを読み込む
                using (var reader = new StreamReader(filePath, Encoding.GetEncoding("Shift-JIS")))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                    // CSVファイルの区切り文字がカンマの場合
                    Delimiter = ",",
                }))
                { 

                    var records = csv.GetRecords<GetCsv>().ToList();
                    return records;
                }
            }
            catch (Exception)
            {
                // エラーハンドリング
                throw new ApplicationException("CSV loading error");
            }
        }
    }
}
