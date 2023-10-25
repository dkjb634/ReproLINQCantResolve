namespace ConsoleApp17.Tbls;

public class Tbl_Master_Board
{
    public Tbl_Master_Board(string idxData, string usedCode, string boardType, string title, string readCheckOk, int boardTypeBrief, int serviceDetailCode, int clickDattCount, int clickGoodCount, string publicPermit)
    {
        Idx_data = idxData;
        UsedCode = usedCode;
        BoardType = boardType;
        Title = title;
        Read_CheckOk = readCheckOk;
        BoardType_Brief = boardTypeBrief;
        Service_DetailCode = serviceDetailCode;
        Click_DattCount = clickDattCount;
        Click_GoodCount = clickGoodCount;
        Public_Permit = publicPermit;
    }

    public string Idx_data { get; set; }
    public string UsedCode { get; set; }
    public string BoardType { get; set; }
    public string Title { get; set; }
    public string Read_CheckOk { get; set; }
    public int BoardType_Brief { get; set; }
    public int Service_DetailCode { get; set; }
    //public int DattDepth { get; set; }
    //public int ContextDepth { get; set; }
    public int Click_DattCount  { get; set; }
    public int Click_GoodCount { get; set; }
    public string Public_Permit { get; set; }
}