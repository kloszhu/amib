using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace amiba.Web.Areas.api.Data
{
    public class BudgetContext: DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options)
           : base(options)
        { }

        public DbSet<M_Subject> Subjects { get; set; }
        public DbSet<Orgination> Orginations { get; set; }
        public DbSet<M_Region> Regions { get; set; }
        public DbSet<M_Amiba> Amibas { get; set; }
        public DbSet<M_Project> Projects { get; set; }
        public DbSet<M_Reserve_Main> ReserveMains { get; set; }
        public DbSet<M_Reserve_Detail> ReserveDetails { get; set; }

        
    }
    [Table("M_Budget_Subject")]
    public class M_Subject
    {
        [Key]
        public int M_Subject_id { get; set; }
        public Guid? M_Subject_code { get; set; }
        public Guid? M_Subject_number { get; set; }
        public bool? M_Subject_isShow { get; set; }
        public bool? M_Subject_isReadOnly { get; set; }
        public string M_Subject_name { get; set; }
        public bool? isDelete { get; set; }
    }
    [Table("M_Budget_Orgination")]
    public class Orgination
    {
        [Key]
        public int M_Organization_id { get; set; }
        public Guid? M_Organization_code { get; set; }
        public Guid? M_Organization_parent { get; set; }
        public string M_Organization_name { get; set; }
        public string M_Organization_number { get; set; }
        public bool? M_Organization_isvaitual { get; set; }
        public Guid? M_Amiba_code { get; set; }
        public Guid? M_Region_code { get; set; }
        public DateTime? M_Organization_effectdate { get; set; }
        public bool? IsDelete { get; set; }
    }
    [Table("M_Budget_Region")]
    public class M_Region
    {
        [Key]
        public int M_Region_id { get; set; }
        public Guid? M_Region_code { get; set; }
        public string M_Region_name { get; set; }
        public bool M_Region_isvirtual { get; set; }
        public DateTime? M_Region_createdate { get; set; }
        public bool? IsDelete { get; set; }

    }

    [Table("M_Budget_Amiba")]
    public class M_Amiba
    {
        [Key]
        public int M_Amiba_id { get; set; }
        public Guid? M_Amiba_code { get; set; }
        public string M_Amiba_name { get; set; }
        public string M_Amiba_number { get; set; }
        public bool? M_Amiba_isvaitual { get; set; }
        public DateTime? M_Amiba_effectdate { get; set; }
        public bool? IsDelete { get; set; }


    }
    [Table("M_Budget_Project")]
    public class M_Project
    {
        [Key]
        public int M_Project_id { get; set; }
        public Guid? M_Project_code { get; set; }
        public Guid? M_Project_parent { get; set; }
        public string M_Project_name { get; set; }
        public Guid? M_Region_code { get; set; }
        public Guid? M_Amiba_code { get; set; }
        public int? M_Project_IndustryCode { get; set; }
        public string M_Project_IndustryName { get; set; }
        public int? M_Project_ProjectType { get; set; }
        public bool? M_Project_isvirtual { get; set; }
        public Guid? M_Subject_code { get; set; }
        public DateTime? M_Project_CreateDate { get; set; }

    }
    [Table("M_Budget_ReserveMain")]
    public class M_Reserve_Main
    {
        [Key]
        public int M_Reserve_Main_id { get; set; }
        public Guid? M_Reserve_Main_code { get; set; }
        public Guid? P_Business_Flow_Form_code { get; set; }
        public Guid? M_Project_code { get; set; }
        public int? M_Reserve_Main_year { get; set; }
        public int? M_Reserve_Main_month { get; set; }
        public int? M_Reserve_Main_day { get; set; }
        public Guid? M_Amiba_code { get; set; }
        public DateTime? M_Reserve_Main_registerdate { get; set; }
        public int? M_Reserve_Main_state { get; set; }
        public DateTime? M_Reserve_Main_createdate { get; set; }

    }
    [Table("M_Budget_ReserveDetail")]
    public class M_Reserve_Detail
    {
        [Key]
        public int M_Reserve_Detail_id { get; set; }
        public Guid? M_Reserve_Detail_code { get; set; }
        public Guid? M_Reserve_Main_code { get; set; }
        public Guid? M_Subject_code { get; set; }
        public string M_Subject_number { get; set; }
        public string M_Subject_name { get; set; }
        public decimal? M1 { get; set; }
        public decimal? M2 { get; set; }
        public decimal? M3 { get; set; }
        public decimal? M4 { get; set; }
        public decimal? M5 { get; set; }
        public decimal? M6 { get; set; }
        public decimal? M7 { get; set; }
        public decimal? M8 { get; set; }
        public decimal? M9 { get; set; }
        public decimal? M10 { get; set; }
        public decimal? M11 { get; set; }
        public decimal? M12 { get; set; }
        public DateTime? M_Reserve_Detail_createdat { get; set; }

    }

}
