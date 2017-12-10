namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTmdbLinkToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "TmdbLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "TmdbLink");
        }
    }
}
