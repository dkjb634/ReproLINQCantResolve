namespace ConsoleApp17.Tbls;

public class Repros
{
    public void Repro1(Tbl_Sleeve_Board param)
    {
        MyDBContext _context = new MyDBContext();

var m = _context.Tbl_Member.ToList();
var key = _context.Tbl_Master_Board.ToList();
var bl = _context.Tbl2_ContextBlocking.ToList();
var sl = _context.Tbl_Sleeve_Board.ToList();

var rlst =
    (from x in key
        from b in bl
        join c2 in m on x.UsedCode equals Security.EncryptSHA512(c2.Email)
        join st in sl on Security.EncryptSHA512(x.UsedCode + x.Idx_data).ToString() equals st.Encode_Board into sj
        from c1 in sj.DefaultIfEmpty()
        where c1 == null || c1.Content_Depth == param.Content_Depth
        select new ReturnTbl_Master_Board()
        {
            Idx_data = x.Idx_data,
            UsedCode = x.UsedCode,
            BoardType = x.BoardType,
            Title = x.Title,
            Read_CheckOk = x.Read_CheckOk,
            BoardType_Brief = x.BoardType_Brief.ToString(),
            Service_DetailCode = x.Service_DetailCode.ToString(),
            Datt_Depth = c1 == null ? 0 : c1.Datt_Depth,
            Content_Depth = c1 == null ? 0 : c1.Content_Depth,
            Click_DattCount = x.Click_DattCount,
            Click_GoodCount = x.Click_GoodCount,
            Datt_Txt = c1 == null ? "" : c1.Datt_Txt,
            Media_Content = "QWE",
            Nickname = c2.Nickname,
            P_Code = c2.P_Code,
            MemberType = c2.MemberType,
            EncodeBoard = c1 == null ? "" : c1.Encode_Board,
            Public_Permit = x.Public_Permit,
            Photo = "photoUrl",
            IsDeletable = string.IsNullOrEmpty(x.UsedCode) ? false : c2.UsedCode.Equals(long.Parse(param.MemberUsedCode)),
            IsMemberInComments = c1 == null ? 0 : 
                 (_context.Tbl_Sleeve_Board.Where(x=>x.Datt_Depth >= 1 && x.Encode_Board.Contains(c1.Encode_Board) 
                                                                       && x.UsedCode == param.MemberUsedCode).ToList().Count()),
            IntReproField = _context.Tbl_Sleeve_Board.Where(x=> x.Datt_Depth >=1 &&
                                                                       x.Encode_Board.Contains(c1.Encode_Board)&&
                                                                       x.UsedCode == param.UsedCode).ToList().Count()
            
        }).OrderByDescending(x=>x.Idx_data).ToList();
    }

    public void Repro2()
    {
        MyDBContext _context = new MyDBContext();

        var key = _context.Tbl_Member.ToList();
        var sl = _context.Tbl_UsedAddReg.ToList();

        var rlst = (
            from x in key
            join c in sl on Security.EncryptSHA512(x.Email) equals c.UsedCode into _c1
            from c1 in _c1.DefaultIfEmpty()
            select new ReturnTbl_Member
            {
                Mission_Status = _context.Tbl_MaS_Ongoing.Where(x=>x.UsedCode =="" && x.End_Idx == 0 )
                    .Count() > 0 ? _context.Tbl_MaS_Ongoing.Where(x=> x.UsedCode == "" && x.End_Idx == 0)
                    .FirstOrDefault().Mission_Type + ":" + _context.Tbl_MaS_Ongoing
                    .Where(x=> x.UsedCode == "" && x.End_Idx == 0)
                    .FirstOrDefault().Mission_Step : "Finish"
            }).ToList();

    }
}