using ConsoleApp17.Tbls;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp17;

public class MyDBContext : DbContext
{
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