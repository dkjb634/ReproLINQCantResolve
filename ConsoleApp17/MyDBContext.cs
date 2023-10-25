using ConsoleApp17.Tbls;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace ConsoleApp17;

public class MyDBContext : DbContext
{
    public MyDBContext()
    {
        
    }
    protected MyDBContext(DbSet<Tbl_Sleeve_Board> tblSleeveBoard, DbSet<Tbl2_Member> tblMember, DbSet<Tbl_MaS_Ongoing> tblMaSOngoing, DbSet<Tbl_MyPoint> tblMyPoint, DbSet<Tbl_Master_Board> tblMasterBoard, DbSet<Tbl2_ContextBlocking> tbl2ContextBlocking, DbSet<Tbl_UsedAddReg> tblUsedAddReg)
    {
        Tbl_Sleeve_Board = tblSleeveBoard;
        Tbl_Member = tblMember;
        Tbl_MaS_Ongoing = tblMaSOngoing;
        Tbl_MyPoint = tblMyPoint;
        Tbl_Master_Board = tblMasterBoard;
        Tbl2_ContextBlocking = tbl2ContextBlocking;
        Tbl_UsedAddReg = tblUsedAddReg;
    }

    public MyDBContext(DbContextOptions options, DbSet<Tbl_Sleeve_Board> tblSleeveBoard, DbSet<Tbl2_Member> tblMember, DbSet<Tbl_MaS_Ongoing> tblMaSOngoing, DbSet<Tbl_MyPoint> tblMyPoint, DbSet<Tbl_Master_Board> tblMasterBoard, DbSet<Tbl2_ContextBlocking> tbl2ContextBlocking, DbSet<Tbl_UsedAddReg> tblUsedAddReg) : base(options)
    {
        Tbl_Sleeve_Board = tblSleeveBoard;
        Tbl_Member = tblMember;
        Tbl_MaS_Ongoing = tblMaSOngoing;
        Tbl_MyPoint = tblMyPoint;
        Tbl_Master_Board = tblMasterBoard;
        Tbl2_ContextBlocking = tbl2ContextBlocking;
        Tbl_UsedAddReg = tblUsedAddReg;
    }

    private const int arrSize = 50;
    
    // public Tbl_Sleeve_Board[] Tbl_Sleeve_Board { get; set; } = new Tbl_Sleeve_Board[arrSize];
    // public Tbl2_Member[] Tbl_Member { get; set; } = new Tbl2_Member[arrSize];
    // public Tbl_MaS_Ongoing[] Tbl_MaS_Ongoing { get; set; } = new Tbl_MaS_Ongoing[arrSize];
    // public Tbl_MyPoint[] Tbl_MyPoint { get; set; } = new Tbl_MyPoint[arrSize];
    // public Tbl_Master_Board[] Tbl_Master_Board { get; set; } = new Tbl_Master_Board[arrSize];
    //
    // public Tbl2_ContextBlocking[] Tbl2_ContextBlocking { get; set; } = new Tbl2_ContextBlocking[arrSize];
    // public Tbl_UsedAddReg[] Tbl_UsedAddReg { get; set; } = new Tbl_UsedAddReg[arrSize];
    
    public DbSet<Tbl_Sleeve_Board> Tbl_Sleeve_Board { get; set; }
    public DbSet<Tbl2_Member> Tbl_Member { get; set; }
    public DbSet<Tbl_MaS_Ongoing> Tbl_MaS_Ongoing { get; set; }
    public DbSet<Tbl_MyPoint> Tbl_MyPoint { get; set; }
    public DbSet<Tbl_Master_Board> Tbl_Master_Board { get; set; }

    public DbSet<Tbl2_ContextBlocking> Tbl2_ContextBlocking { get; set; }
    public DbSet<Tbl_UsedAddReg> Tbl_UsedAddReg { get; set; }
}