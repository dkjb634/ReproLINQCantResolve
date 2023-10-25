namespace ConsoleApp17.Tbls;

public class Tbl_Sleeve_Board
{
    public Tbl_Sleeve_Board()
    {
        UsedCode = "q";
        Encode_Board = "encodeBoard";
        Idx_Board = "idxBoard";
        Datt_Depth = 4;
        Datt_Txt = "dattTxt";
        Report = 1;
        Deleteok = 3;
        Media_Contend = "mediaContend";
        Notify_Report = "notifyReport";
        WasModified = 2;
        Fback_Specialist = "fbackSpecialist";
        Content_Depth = 1;
        MemberUsedCode = "memberUsedCode";
    }
    public Tbl_Sleeve_Board(string usedCode, string encodeBoard, string idxBoard, int dattDepth, string dattTxt, int report, int deleteok, string mediaContend, string notifyReport, int wasModified, string fbackSpecialist, int contentDepth, string memberUsedCode)
    {
        UsedCode = usedCode;
        Encode_Board = encodeBoard;
        Idx_Board = idxBoard;
        Datt_Depth = dattDepth;
        Datt_Txt = dattTxt;
        Report = report;
        Deleteok = deleteok;
        Media_Contend = mediaContend;
        Notify_Report = notifyReport;
        WasModified = wasModified;
        Fback_Specialist = fbackSpecialist;
        Content_Depth = contentDepth;
        MemberUsedCode = memberUsedCode;
    }

    public string UsedCode { get; set; }
    public string Encode_Board { get; set; }
    public string Idx_Board { get; set; }
    public int Datt_Depth { get; set; }
    public string Datt_Txt { get; set; }
    public int Report { get; set; }
    public int Deleteok { get; set; }
    public string Media_Contend { get; set; }
    public string Notify_Report { get; set; }
    public int WasModified { get; set; }
    public string Fback_Specialist { get; set; }
    public int Content_Depth { get; set; }
    
    public string MemberUsedCode { get; set; }
}