namespace LeagueService.Domain.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Team", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Team", "UserId");
        }
    }
}
