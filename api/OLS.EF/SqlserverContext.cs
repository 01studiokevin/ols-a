using Microsoft.EntityFrameworkCore;
using OLS.Models;

namespace OLS.EF
{
    public class SqlserverContext : DbContext
    {

        public SqlserverContext(DbContextOptions<SqlserverContext> options)
            : base(options)
        {

        }

        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<ChapterSection> ChapterSections { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<CourseGroup> CourseGroups { get; set; }
        public DbSet<CourseChapter> CourseChapters { get; set; }
        public DbSet<CourseTeacher> CourseTeachers { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<PointDiscussion> PointDiscussions { get; set; }
        public DbSet<PointType> PointTypes { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolCourse> SchoolCourses { get; set; }
        public DbSet<SectionPoint> SectionPoints { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
        public DbSet<UserCourseAnswer> UserCourseAnswers { get; set; }
        public DbSet<UserInfoDetail> UserInfoDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entity.Name).ToTable(entity.DisplayName());
            }
            modelBuilder.Entity<UserInfo>().HasData(
                new UserInfo
                {
                    Id = 1,
                    UserName = "李明航",
                    Account = "kevin.minghang.li@outlook.com",
                    Password = "123456",
                    Gender = "1",
                    Tel = "19923985290",
                    IsActive = "1"
                }
                );
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = 1,
                RoleValue = "1",
                RoleName = "用户",
                Describe = "普通用户"
            },
            new Role
            {
                Id = 2,
                RoleValue = "2",
                RoleName = "管理员",
                Describe = "权限：所有"
            });
            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                Id = 1,
                UserId = 1,
                RoleId = 1
            });
        }
    }
}