using CsvHelper.Configuration.Attributes;

namespace YourNamespace
{
    public class GetCsv
    {

        [Name("要求レコード番号")]
        public String RecordNumber { get; set; }

        [Name("個人番号")]
        public String PersonalNumber { get; set; }

        [Name("照会結果氏名")]
        public String InquiryResultName { get; set; }

        [Name("照会結果氏名かな")]
        public String InquiryResultNameKana { get; set; }

        [Name("照会結果生年月日")]
        public String InquiryResultBirth { get; set; }

        [Name("照会結果性別コード")]
        public String InquiryResultGenderCode { get; set; }

        [Name("照会結果性別")]
        public String QueryResultGender { get; set; }

        [Name("照会結果住所")]
        public String InquiryResultAddress { get; set; }

        [Name("市町村コード")]
        public String MunicipalCode { get; set; }

        [Name("対象者識別情報")]
        public String IdentifierInfo { get; set; }

        [Name("照会処理結果コード")]
        public String InquiryResultCode { get; set; }

        [Name("照会処理結果")]
        public String InquiryProcessResult { get; set; }

        [Name("照会結果レコード数")]
        public String QueryResultRecord { get; set; }

        [Name("照会結果レコード連番")]
        public String RecordSequenceNumber { get; set; }

        [Name("異動有無コード")]
        public String TransferStatusCode { get; set; }

        [Name("異動有無")]
        public String TransferStatus { get; set; }

        [Name("生存状況コード")]
        public String SurvivalStatusCode { get; set; }

        [Name("生存状況")]
        public string SurvivalStatus { get; set; }

        [Name("変更状況コード")]
        public String ChangeStatusCode { get; set; }

        [Name("変更状況")]
        public String ChangeStatus { get; set; }

        [Name("異動事由コード")]
        public String ChangeTransferCode { get; set; }

        [Name("異動事由")]
        public String ReasonTransfer { get; set; }

        [Name("異動年月日")]
        public String DateOfTransfer { get; set; }

        [Name("照会結果氏名外字数")]
        public String InquirycharOutsideName { get; set; }

        [Name("照会結果住所外字数")]
        public String InquirycharOutsideAddress { get; set; }

        [Name("不参加団体対象フラグ")]
        public String NonParticipantFlag { get; set; }

        [Name("不参加団体対象要因")]
        public String NonParticipantReason { get; set; }
    }
}
