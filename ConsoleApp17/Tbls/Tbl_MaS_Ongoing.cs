namespace ConsoleApp17.Tbls;

public class Tbl_MaS_Ongoing
{
    public Tbl_MaS_Ongoing(string usedCode, string missionType, string missionStep, long missionIdx, int goodValue, long endIdx, string reviewSpecialist, string mentoUsedCode, int missionCost, int mentoGood, string missionCode)
    {
        UsedCode = usedCode;
        Mission_Type = missionType;
        Mission_Step = missionStep;
        Mission_idx = missionIdx;
        Good_value = goodValue;
        End_Idx = endIdx;
        Review_Specialist = reviewSpecialist;
        Mento_UsedCode = mentoUsedCode;
        Mission_Cost = missionCost;
        Mento_Good = mentoGood;
        Mission_Code = missionCode;
    }

    public string UsedCode { get; set; }
    
    public string Mission_Type { get; set; }
    
    public string Mission_Step { get; set; }
    
    public long Mission_idx { get; set; }
    
    public Int32 Good_value{ get; set; }
    
    public long End_Idx { get; set; }
    
    public string Review_Specialist { get; set; }
    
    public string Mento_UsedCode { get; set; }
    
    public int Mission_Cost { get; set; }
    
    public int Mento_Good { get; set; }
    
    public string Mission_Code { get; set; }
}