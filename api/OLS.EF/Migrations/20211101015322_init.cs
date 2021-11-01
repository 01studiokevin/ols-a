using Microsoft.EntityFrameworkCore.Migrations;

namespace OLS.EF.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChapterSection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EndTime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    JoinCount = table.Column<int>(type: "int", nullable: false),
                    CourseStatus = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PeriodCount = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseGroupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CourseGroupValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CourseGroupRouter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Describe = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PointType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Describe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleValue = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Describe = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SchoolValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Account = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Profile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Describe = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Summarize = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prepare = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Target = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseDetail_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TypeValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GroupTypeId = table.Column<int>(type: "int", nullable: false),
                    CourseGroupId = table.Column<int>(type: "int", nullable: true),
                    TypeDescribe = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseType_CourseGroup_CourseGroupId",
                        column: x => x.CourseGroupId,
                        principalTable: "CourseGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SectionPoint",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    PointUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionPoint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionPoint_ChapterSection_SectionId",
                        column: x => x.SectionId,
                        principalTable: "ChapterSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionPoint_PointType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "PointType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolCourse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolCourse_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolCourse_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseTeacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTeacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseTeacher_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTeacher_UserInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCourse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCourse_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCourse_UserInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCourseAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCourseAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCourseAnswer_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCourseAnswer_UserInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInfoDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FllowCount = table.Column<int>(type: "int", nullable: false),
                    SubscribeCount = table.Column<int>(type: "int", nullable: false),
                    ThumbUpCount = table.Column<int>(type: "int", nullable: false),
                    leaningTimeCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfoDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInfoDetail_UserInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_UserInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseChapter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CourseDetailId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseChapter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseChapter_CourseDetail_CourseDetailId",
                        column: x => x.CourseDetailId,
                        principalTable: "CourseDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PointDiscussion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionPointId = table.Column<int>(type: "int", nullable: false),
                    SectinPointId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointDiscussion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PointDiscussion_SectionPoint_SectinPointId",
                        column: x => x.SectinPointId,
                        principalTable: "SectionPoint",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Describe", "RoleName", "RoleValue" },
                values: new object[] { 1, "普通用户", "用户", "1" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Describe", "RoleName", "RoleValue" },
                values: new object[] { 2, "权限：所有", "管理员", "2" });

            migrationBuilder.InsertData(
                table: "UserInfo",
                columns: new[] { "Id", "Account", "Describe", "Gender", "IsActive", "Password", "Profile", "Tel", "UserName" },
                values: new object[] { 1, "kevin.minghang.li@outlook.com", null, "1", "1", "123456", null, "19923985290", "李明航" });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_CourseChapter_CourseDetailId",
                table: "CourseChapter",
                column: "CourseDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseDetail_CourseId",
                table: "CourseDetail",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTeacher_CourseId",
                table: "CourseTeacher",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTeacher_UserId",
                table: "CourseTeacher",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseType_CourseGroupId",
                table: "CourseType",
                column: "CourseGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PointDiscussion_SectinPointId",
                table: "PointDiscussion",
                column: "SectinPointId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolCourse_CourseId",
                table: "SchoolCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolCourse_SchoolId",
                table: "SchoolCourse",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionPoint_SectionId",
                table: "SectionPoint",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionPoint_TypeId",
                table: "SectionPoint",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCourse_CourseId",
                table: "UserCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCourse_UserId",
                table: "UserCourse",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCourseAnswer_CourseId",
                table: "UserCourseAnswer",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCourseAnswer_UserId",
                table: "UserCourseAnswer",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfoDetail_UserId",
                table: "UserInfoDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseChapter");

            migrationBuilder.DropTable(
                name: "CourseTeacher");

            migrationBuilder.DropTable(
                name: "CourseType");

            migrationBuilder.DropTable(
                name: "PointDiscussion");

            migrationBuilder.DropTable(
                name: "SchoolCourse");

            migrationBuilder.DropTable(
                name: "UserCourse");

            migrationBuilder.DropTable(
                name: "UserCourseAnswer");

            migrationBuilder.DropTable(
                name: "UserInfoDetail");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "CourseDetail");

            migrationBuilder.DropTable(
                name: "CourseGroup");

            migrationBuilder.DropTable(
                name: "SectionPoint");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "ChapterSection");

            migrationBuilder.DropTable(
                name: "PointType");
        }
    }
}
