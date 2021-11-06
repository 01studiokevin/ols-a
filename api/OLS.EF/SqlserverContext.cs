using Microsoft.EntityFrameworkCore;
using OLS.Models;
using System;

namespace OLS.EF
{
    public class SqlserverContext:DbContext
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
        public DbSet<CourseSection> CourseSections { get; set; }
        public DbSet<CourseGroup> CourseGroups { get; set; }
        public DbSet<CourseChapter> CourseChapters { get; set; }
        public DbSet<CourseTeacher> CourseTeachers { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<CourseTypeMany> CourseTypeManies { get; set; }
        public DbSet<PointDiscussion> PointDiscussions { get; set; }
        public DbSet<PointType> PointTypes { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolCourse> SchoolCourses { get; set; }
        public DbSet<SectionPoint> SectionPoints { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
        public DbSet<UserCourseAnswer> UserCourseAnswers { get; set; }
        public DbSet<UserInfoDetail> UserInfoDetails { get; set; }
        

        //admin
        public DbSet<MasterMenu> MasterMenus { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entity.Name).ToTable(entity.DisplayName());
            }
        }
    }
}
