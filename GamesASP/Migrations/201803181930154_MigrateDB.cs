namespace GamesASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CourseStudent", newName: "GameGenres");
            RenameColumn(table: "dbo.GameGenres", name: "GanresId", newName: "GenresId");
            RenameIndex(table: "dbo.GameGenres", name: "IX_GanresId", newName: "IX_GenresId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.GameGenres", name: "IX_GenresId", newName: "IX_GanresId");
            RenameColumn(table: "dbo.GameGenres", name: "GenresId", newName: "GanresId");
            RenameTable(name: "dbo.GameGenres", newName: "CourseStudent");
        }
    }
}
