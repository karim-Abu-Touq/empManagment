using empManagment.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace empManagment.Data
{
    public class clsAppDBContext : IdentityDbContext<ApplicationUser>
    {
        public clsAppDBContext(DbContextOptions<clsAppDBContext> options) : base(options)
        {

        }
        public DbSet<clsEmployee> Employees { get; set; }
        public DbSet<clsDepartment> Departments { get; set; }
        public DbSet<clsPosition> Positions { get; set; }

        public DbSet<clsRetiredEmployee> RetiredEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<clsDepartment>().HasData(
    new clsDepartment
    {
        DepID = 12,
        DepName = "Human Resources",
        Description = "Human Resources Department"
    },
    new clsDepartment
    {
        DepID = 13,
        DepName = "Information Technology",
        Description = "Information Technology Department"
    },
    new clsDepartment
    {
        DepID = 14,
        DepName = "Finance",
        Description = "Finance Department"
    },
    new clsDepartment
    {
        DepID = 15,
        DepName = "Sales",
        Description = "Sales Department"
    },
    new clsDepartment
    {
        DepID = 16,
        DepName = "Marketing",
        Description = "Marketing Department"
    },
    new clsDepartment
    {
        DepID = 17,
        DepName = "Operations",
        Description = "Operations Department"
    },
    new clsDepartment
    {
        DepID = 18,
        DepName = "Customer Service",
        Description = "Customer Service Department"
    }
);
            modelBuilder.Entity<clsPosition>().HasData(

    // Human Resources - Department 12
    new clsPosition
    {
        PosID = 7,
        PosTitle = "HR Manager",
        MinSalary = 1500,
        MaxSalary = 3000,
        DepartmentID = 12
    },
    new clsPosition
    {
        PosID = 8,
        PosTitle = "HR Specialist",
        MinSalary = 700,
        MaxSalary = 1500,
        DepartmentID = 12
    },
    new clsPosition
    {
        PosID = 9,
        PosTitle = "Recruitment Officer",
        MinSalary = 600,
        MaxSalary = 1300,
        DepartmentID = 12
    },
    new clsPosition
    {
        PosID = 10,
        PosTitle = "HR Assistant",
        MinSalary = 500,
        MaxSalary = 1000,
        DepartmentID = 12
    },

    // Information Technology - Department 13
    new clsPosition
    {
        PosID = 11,
        PosTitle = "IT Manager",
        MinSalary = 1800,
        MaxSalary = 3500,
        DepartmentID = 13
    },
    new clsPosition
    {
        PosID = 12,
        PosTitle = "Software Developer",
        MinSalary = 1000,
        MaxSalary = 2500,
        DepartmentID = 13
    },
    new clsPosition
    {
        PosID = 13,
        PosTitle = "System Administrator",
        MinSalary = 900,
        MaxSalary = 2200,
        DepartmentID = 13
    },
    new clsPosition
    {
        PosID = 14,
        PosTitle = "IT Support Specialist",
        MinSalary = 500,
        MaxSalary = 1200,
        DepartmentID = 13
    },

    // Finance - Department 14
    new clsPosition
    {
        PosID = 15,
        PosTitle = "Finance Manager",
        MinSalary = 1800,
        MaxSalary = 3500,
        DepartmentID = 14
    },
    new clsPosition
    {
        PosID = 16,
        PosTitle = "Accountant",
        MinSalary = 700,
        MaxSalary = 1500,
        DepartmentID = 14
    },
    new clsPosition
    {
        PosID = 17,
        PosTitle = "Financial Analyst",
        MinSalary = 900,
        MaxSalary = 2000,
        DepartmentID = 14
    },
    new clsPosition
    {
        PosID = 18,
        PosTitle = "Finance Assistant",
        MinSalary = 600,
        MaxSalary = 1200,
        DepartmentID = 14
    },

    // Sales - Department 15
    new clsPosition
    {
        PosID = 19,
        PosTitle = "Sales Manager",
        MinSalary = 1500,
        MaxSalary = 3000,
        DepartmentID = 15
    },
    new clsPosition
    {
        PosID = 20,
        PosTitle = "Sales Representative",
        MinSalary = 600,
        MaxSalary = 1500,
        DepartmentID = 15
    },
    new clsPosition
    {
        PosID = 21,
        PosTitle = "Account Executive",
        MinSalary = 800,
        MaxSalary = 1800,
        DepartmentID = 15
    },
    new clsPosition
    {
        PosID = 22,
        PosTitle = "Sales Assistant",
        MinSalary = 500,
        MaxSalary = 1000,
        DepartmentID = 15
    },

    // Marketing - Department 16
    new clsPosition
    {
        PosID = 23,
        PosTitle = "Marketing Manager",
        MinSalary = 1600,
        MaxSalary = 3000,
        DepartmentID = 16
    },
    new clsPosition
    {
        PosID = 24,
        PosTitle = "Marketing Specialist",
        MinSalary = 800,
        MaxSalary = 1600,
        DepartmentID = 16
    },
    new clsPosition
    {
        PosID = 25,
        PosTitle = "Digital Marketing Specialist",
        MinSalary = 700,
        MaxSalary = 1500,
        DepartmentID = 16
    },
    new clsPosition
    {
        PosID = 26,
        PosTitle = "Marketing Assistant",
        MinSalary = 500,
        MaxSalary = 1000,
        DepartmentID = 16
    },

    // Operations - Department 17
    new clsPosition
    {
        PosID = 27,
        PosTitle = "Operations Manager",
        MinSalary = 1800,
        MaxSalary = 3500,
        DepartmentID = 17
    },
    new clsPosition
    {
        PosID = 28,
        PosTitle = "Operations Supervisor",
        MinSalary = 900,
        MaxSalary = 2000,
        DepartmentID = 17
    },
    new clsPosition
    {
        PosID = 29,
        PosTitle = "Operations Officer",
        MinSalary = 700,
        MaxSalary = 1500,
        DepartmentID = 17
    },
    new clsPosition
    {
        PosID = 30,
        PosTitle = "Operations Assistant",
        MinSalary = 500,
        MaxSalary = 1000,
        DepartmentID = 17
    },

    // Customer Service - Department 18
    new clsPosition
    {
        PosID = 31,
        PosTitle = "Customer Service Manager",
        MinSalary = 1400,
        MaxSalary = 2800,
        DepartmentID = 18
    },
    new clsPosition
    {
        PosID = 32,
        PosTitle = "Customer Service Representative",
        MinSalary = 700,
        MaxSalary = 1500,
        DepartmentID = 18
    },
    new clsPosition
    {
        PosID = 33,
        PosTitle = "Customer Support Specialist",
        MinSalary = 600,
        MaxSalary = 1300,
        DepartmentID = 18
    },
    new clsPosition
    {
        PosID = 34,
        PosTitle = "Customer Service Assistant",
        MinSalary = 500,
        MaxSalary = 1000,
        DepartmentID = 18
    }
);
            modelBuilder.Entity<clsEmployee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.DepEmployees)
                .HasForeignKey(e => e.DepartmentID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<clsEmployee>()
               .HasOne(e => e.Position)
               .WithMany(p => p.PosEmployees)
               .HasForeignKey(e => e.PositionID)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<clsPosition>()
               .HasOne(p => p.Departments)
               .WithMany(d => d.DepPositions)
               .HasForeignKey(p => p.DepartmentID)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<clsEmployee>().HasData(

     // Human Resources - Department 12
     new clsEmployee
     {
         EmpID = 100,
         FirstName = "Ahmad",
         LastName = "Al-Khaldi",
         Email = "ahmad.khaldi@company.com",
         Phone = "0791234567",
         Salary = 1800,
         HireDate = new DateTime(2020, 3, 15),
         DepartmentID = 12,
         PositionID = 7
     },

     new clsEmployee
     {
         EmpID = 101,
         FirstName = "Sara",
         LastName = "Ahmad",
         Email = "sara.ahmad@company.com",
         Phone = "0782345678",
         Salary = 950,
         HireDate = new DateTime(2021, 6, 10),
         DepartmentID = 12,
         PositionID = 8
     },
     new clsEmployee
     {
         EmpID = 102,
         FirstName = "Omar",
         LastName = "Haddad",
         Email = "omar.haddad@company.com",
         Phone = "0773456789",
         Salary = 800,
         HireDate = new DateTime(2022, 1, 20),
         DepartmentID = 12,
         PositionID = 9
     },
     new clsEmployee
     {
         EmpID = 103,
         FirstName = "Lina",
         LastName = "Saleh",
         Email = "lina.saleh@company.com",
         Phone = "0794567890",
         Salary = 600,
         HireDate = new DateTime(2023, 5, 12),
         DepartmentID = 12,
         PositionID = 10
     },

     // Information Technology - Department 13
     new clsEmployee
     {
         EmpID = 104,
         FirstName = "Mohammad",
         LastName = "Nasser",
         Email = "mohammad.nasser@company.com",
         Phone = "0795678901",
         Salary = 2200,
         HireDate = new DateTime(2019, 8, 5),
         DepartmentID = 13,
         PositionID = 11
     },
     new clsEmployee
     {
         EmpID = 105,
         FirstName = "Yousef",
         LastName = "Abdullah",
         Email = "yousef.abdullah@company.com",
         Phone = "0786789012",
         Salary = 1400,
         HireDate = new DateTime(2021, 2, 18),
         DepartmentID = 13,
         PositionID = 12
     },
     new clsEmployee
     {
         EmpID = 106,
         FirstName = "Khaled",
         LastName = "Ali",
         Email = "khaled.ali@company.com",
         Phone = "0777890123",
         Salary = 1200,
         HireDate = new DateTime(2020, 11, 7),
         DepartmentID = 13,
         PositionID = 13
     },
     new clsEmployee
     {
         EmpID = 107,
         FirstName = "Rami",
         LastName = "Mahmoud",
         Email = "rami.mahmoud@company.com",
         Phone = "0798901234",
         Salary = 750,
         HireDate = new DateTime(2023, 3, 25),
         DepartmentID = 13,
         PositionID = 14
     },

     // Finance - Department 14
     new clsEmployee
     {
         EmpID = 108,
         FirstName = "Hani",
         LastName = "Qasem",
         Email = "hani.qasem@company.com",
         Phone = "0799012345",
         Salary = 2000,
         HireDate = new DateTime(2018, 7, 14),
         DepartmentID = 14,
         PositionID = 15
     },
     new clsEmployee
     {
         EmpID = 109,
         FirstName = "Dana",
         LastName = "Khalil",
         Email = "dana.khalil@company.com",
         Phone = "0780123456",
         Salary = 1000,
         HireDate = new DateTime(2021, 9, 3),
         DepartmentID = 14,
         PositionID = 16
     },
     new clsEmployee
     {
         EmpID = 110,
         FirstName = "Tareq",
         LastName = "Salameh",
         Email = "tareq.salameh@company.com",
         Phone = "0771234560",
         Salary = 1300,
         HireDate = new DateTime(2020, 4, 22),
         DepartmentID = 14,
         PositionID = 17
     },
     new clsEmployee
     {
         EmpID = 111,
         FirstName = "Noor",
         LastName = "Hamdan",
         Email = "noor.hamdan@company.com",
         Phone = "0792345670",
         Salary = 850,
         HireDate = new DateTime(2022, 6, 8),
         DepartmentID = 14,
         PositionID = 18
     },

     // Sales - Department 15
     new clsEmployee
     {
         EmpID = 112,
         FirstName = "Sami",
         LastName = "Odeh",
         Email = "sami.odeh@company.com",
         Phone = "0793456780",
         Salary = 1800,
         HireDate = new DateTime(2019, 10, 11),
         DepartmentID = 15,
         PositionID = 19
     },
     new clsEmployee
     {
         EmpID = 113,
         FirstName = "Fadi",
         LastName = "Yasin",
         Email = "fadi.yasin@company.com",
         Phone = "0784567890",
         Salary = 800,
         HireDate = new DateTime(2022, 2, 14),
         DepartmentID = 15,
         PositionID = 20
     },
     new clsEmployee
     {
         EmpID = 114,
         FirstName = "Maya",
         LastName = "Saadi",
         Email = "maya.saadi@company.com",
         Phone = "0775678900",
         Salary = 1100,
         HireDate = new DateTime(2021, 7, 19),
         DepartmentID = 15,
         PositionID = 21
     },
     new clsEmployee
     {
         EmpID = 115,
         FirstName = "Rana",
         LastName = "Zaid",
         Email = "rana.zaid@company.com",
         Phone = "0796789010",
         Salary = 700,
         HireDate = new DateTime(2023, 1, 5),
         DepartmentID = 15,
         PositionID = 22
     },

     // Marketing - Department 16
     new clsEmployee
     {
         EmpID = 116,
         FirstName = "Basel",
         LastName = "Kanaan",
         Email = "basel.kanaan@company.com",
         Phone = "0797890120",
         Salary = 1900,
         HireDate = new DateTime(2020, 5, 17),
         DepartmentID = 16,
         PositionID = 23
     },
     new clsEmployee
     {
         EmpID = 117,
         FirstName = "Aya",
         LastName = "Mustafa",
         Email = "aya.mustafa@company.com",
         Phone = "0788901230",
         Salary = 1200,
         HireDate = new DateTime(2021, 8, 23),
         DepartmentID = 16,
         PositionID = 24
     },
     new clsEmployee
     {
         EmpID = 118,
         FirstName = "Laith",
         LastName = "Ibrahim",
         Email = "laith.ibrahim@company.com",
         Phone = "0779012340",
         Salary = 850,
         HireDate = new DateTime(2022, 3, 10),
         DepartmentID = 16,
         PositionID = 25
     },
     new clsEmployee
     {
         EmpID = 119,
         FirstName = "Hala",
         LastName = "Jaber",
         Email = "hala.jaber@company.com",
         Phone = "0790123451",
         Salary = 750,
         HireDate = new DateTime(2023, 6, 15),
         DepartmentID = 16,
         PositionID = 26
     },

     // Operations - Department 17
     new clsEmployee
     {
         EmpID = 120,
         FirstName = "Nabil",
         LastName = "Shami",
         Email = "nabil.shami@company.com",
         Phone = "0791234501",
         Salary = 2000,
         HireDate = new DateTime(2019, 4, 9),
         DepartmentID = 17,
         PositionID = 27
     },
     new clsEmployee
     {
         EmpID = 121,
         FirstName = "Walid",
         LastName = "Fares",
         Email = "walid.fares@company.com",
         Phone = "0782345601",
         Salary = 1200,
         HireDate = new DateTime(2021, 1, 12),
         DepartmentID = 17,
         PositionID = 28
     },
     new clsEmployee
     {
         EmpID = 122,
         FirstName = "Rashid",
         LastName = "Mansour",
         Email = "rashid.mansour@company.com",
         Phone = "0773456701",
         Salary = 850,
         HireDate = new DateTime(2022, 8, 20),
         DepartmentID = 17,
         PositionID = 29
     },
     new clsEmployee
     {
         EmpID = 123,
         FirstName = "Samer",
         LastName = "Barakat",
         Email = "samer.barakat@company.com",
         Phone = "0794567801",
         Salary = 650,
         HireDate = new DateTime(2023, 2, 28),
         DepartmentID = 17,
         PositionID = 30
     },

     // Customer Service - Department 18
     new clsEmployee
     {
         EmpID = 124,
         FirstName = "Imad",
         LastName = "Naji",
         Email = "imad.naji@company.com",
         Phone = "0795678902",
         Salary = 1600,
         HireDate = new DateTime(2020, 6, 4),
         DepartmentID = 18,
         PositionID = 31
     },
     new clsEmployee
     {
         EmpID = 125,
         FirstName = "Jamal",
         LastName = "Hussein",
         Email = "jamal.hussein@company.com",
         Phone = "0786789013",
         Salary = 1000,
         HireDate = new DateTime(2021, 10, 18),
         DepartmentID = 18,
         PositionID = 32
     },
     new clsEmployee
     {
         EmpID = 126,
         FirstName = "Nour",
         LastName = "Suleiman",
         Email = "nour.suleiman@company.com",
         Phone = "0777890124",
         Salary = 650,
         HireDate = new DateTime(2022, 5, 7),
         DepartmentID = 18,
         PositionID = 33
     },
     new clsEmployee
     {
         EmpID = 127,
         FirstName = "Salma",
         LastName = "Rashed",
         Email = "salma.rashed@company.com",
         Phone = "0798901235",
         Salary = 550,
         HireDate = new DateTime(2023, 9, 14),
         DepartmentID = 18,
         PositionID = 34
     }
 );

        }
    }
}
