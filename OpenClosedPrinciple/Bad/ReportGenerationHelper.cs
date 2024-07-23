namespace OpenClosedPrinciple.Incorrect
{
    public class ReportGenerationHelper
    {
        public string GenerateReport(ReportInfo report)
        {
            string generatedPath = string.Empty;

            if (report.ReportType == "EXCEL")
            {
                generatedPath = "ExcelReport";
            }
            else if (report.ReportType == "PDF")
            {
                generatedPath = "PDFReport";
            }
            else if (report.ReportType == "WORD")
            {
                generatedPath = "WordReport";
            }

            // What If we need to handle XML report as well ???
            else if (report.ReportType == "XML")
            {
                generatedPath = "XMLReport";
            }

            return generatedPath;
        }
    }
}
