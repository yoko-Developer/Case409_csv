namespace Case409_csv.model
{
    public class Kenpo31Record
    {
        [CsvHelper.Configuration.Attributes.Name("照会結果住所")]
        public String InquiryResultAddress { get; set; }
    }
}
