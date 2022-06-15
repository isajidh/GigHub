namespace GigHub3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class toGenre1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Gigs", name: "Genre_ID", newName: "Genre1_ID");
            RenameIndex(table: "dbo.Gigs", name: "IX_Genre_ID", newName: "IX_Genre1_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Gigs", name: "IX_Genre1_ID", newName: "IX_Genre_ID");
            RenameColumn(table: "dbo.Gigs", name: "Genre1_ID", newName: "Genre_ID");
        }
    }
}
