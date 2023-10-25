namespace ConsoleApp17.Tbls;

public class ReturnTbl_Master_Board
{
    public ReturnTbl_Master_Board()
    {
        Idx_data = "idxData";
        UsedCode = "usedCode";
        BoardType = "boardType";
        Title = "title";
        Read_CheckOk = "readCheckOk";
        BoardType_Brief = "boardTypeBrief";
        Service_DetailCode = "serviceDetailCode";
        Datt_Depth = 1;
        Content_Depth = 1;
        Click_DattCount = 1;
        Click_GoodCount = 1;
        Datt_Txt = "dattTxt";
        Media_Content = "mediaContent";
        Nickname = "nickname";
        P_Code = "pCode";
        MemberType = "memberType";
        EncodeBoard = "encodeBoard";
        Public_Permit = "publicPermit";
        Photo = "photo";
        IsDeletable = false;
        IsMemberInComments = 1;
        IntReproField = 1;
    }

    public ReturnTbl_Master_Board(string idxData, string usedCode, string boardType, string title, string readCheckOk, string boardTypeBrief, string serviceDetailCode, int dattDepth, int contentDepth, int clickDattCount, int clickGoodCount, string dattTxt, string mediaContent, string nickname, string pCode, string memberType, string encodeBoard, string publicPermit, string photo, bool isDeletable, int isMemberInComments, int intReproField)
    {
        Idx_data = idxData;
        UsedCode = usedCode;
        BoardType = boardType;
        Title = title;
        Read_CheckOk = readCheckOk;
        BoardType_Brief = boardTypeBrief;
        Service_DetailCode = serviceDetailCode;
        Datt_Depth = dattDepth;
        Content_Depth = contentDepth;
        Click_DattCount = clickDattCount;
        Click_GoodCount = clickGoodCount;
        Datt_Txt = dattTxt;
        Media_Content = mediaContent;
        Nickname = nickname;
        P_Code = pCode;
        MemberType = memberType;
        EncodeBoard = encodeBoard;
        Public_Permit = publicPermit;
        Photo = photo;
        IsDeletable = isDeletable;
        IsMemberInComments = isMemberInComments;
        IntReproField = intReproField;
    }

    public string Idx_data { get; set; }
    public string UsedCode { get; set; }
    public string BoardType { get; set; }
    public string Title { get; set; }
    public string Read_CheckOk { get; set; }
    public string BoardType_Brief { get; set; }
    public string Service_DetailCode { get; set; }
    public int Datt_Depth { get; set; }
    public int Content_Depth { get; set; }
    public int Click_DattCount  { get; set; }
    public int Click_GoodCount { get; set; }
    public string Datt_Txt { get; set; }
    public string Media_Content { get; set; }
    public string Nickname { get; set; }
    public string P_Code { get; set; }
    public string MemberType { get; set; }
    public string EncodeBoard { get; set; }
    public string Public_Permit { get; set; }
    public string Photo { get; set; }
    public bool IsDeletable { get; set; }
    public int IsMemberInComments { get; set; }
    
    public int IntReproField { get; set; }
}