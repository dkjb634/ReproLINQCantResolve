namespace ConsoleApp17.Tbls;

public class ReturnTbl_Member
{
    public ReturnTbl_Member()
    {
        UsedCode = "usedCode";
        Email = "email";
        Name = "name";
        Password = "password";
        Nickname = "nickname";
        MobilePhone = "mobilePhone";
        Gender = "gender";
        BirthDay = "birthDay";
        ServiceUsingAgreeCheck = "serviceUsingAgreeCheck";
        MemberType = "memberType";
        P_Code = "pCode";
        Mission_Status = "missionStatus";
    }

    public ReturnTbl_Member(string usedCode, string email, string name, string password, string nickname, string mobilePhone, string gender, string birthDay, string serviceUsingAgreeCheck, string memberType, string pCode, string missionStatus)
    {
        UsedCode = usedCode;
        Email = email;
        Name = name;
        Password = password;
        Nickname = nickname;
        MobilePhone = mobilePhone;
        Gender = gender;
        BirthDay = birthDay;
        ServiceUsingAgreeCheck = serviceUsingAgreeCheck;
        MemberType = memberType;
        P_Code = pCode;
        Mission_Status = missionStatus;
    }

    public string UsedCode { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Nickname { get; set; }
    public string MobilePhone { get; set; }
    public string Gender { get; set; }
    public string BirthDay { get; set; }
    public string ServiceUsingAgreeCheck { get; set; }
    public string MemberType { get; set; }
    public string P_Code { get; set; }
    public string Mission_Status { get; set; }
}