namespace OpenClosedPrinciple.Correct
{
    public class PdfReportGenerator : ReportGenerator
    {
        public override string GenerateReport(ReportInfo report)
        {
            return "PDFReport";
        }
    }
}
