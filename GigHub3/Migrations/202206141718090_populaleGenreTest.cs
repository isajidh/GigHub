namespace GigHub3.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populaleGenreTest : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres(ID,Name) Values(1,'Rock')");
            Sql("Insert into Genres(ID,Name) Values(2,'Blue')");
            Sql("Insert into Genres(ID,Name) Values(3,'Country')");
            Sql("Insert into Genres(ID,Name) Values(4,'Jazz')");
        }

        public override void Down()
        {
            Sql("Delete from Genres Where ID IN (1,2,3,4)");
        }
    }
}
