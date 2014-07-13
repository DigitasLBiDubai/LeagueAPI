namespace LeagueService.Domain.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedAllSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Player",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExternalId = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UtcDateCreated = c.DateTime(nullable: false),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Team", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
            AddColumn("dbo.Match", "UtcStartDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Match", "UtcEndDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Score", "MatchId", c => c.Int(nullable: false));
            AddColumn("dbo.Score", "PlayerId", c => c.Int(nullable: false));
            AddColumn("dbo.Score", "Points", c => c.Int(nullable: false));
            AddColumn("dbo.Score", "UtcDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Team", "Name", c => c.String());
            AddColumn("dbo.Team", "UtcDateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Team", "Match_Id", c => c.Int());
            CreateIndex("dbo.Team", "Match_Id");
            CreateIndex("dbo.Score", "PlayerId");
            AddForeignKey("dbo.Score", "PlayerId", "dbo.Player", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Team", "Match_Id", "dbo.Match", "Id");
            DropColumn("dbo.Match", "StartDateTime");
            DropColumn("dbo.Match", "EndDateTime");
            DropColumn("dbo.Score", "DateTime");
            DropColumn("dbo.Team", "UserId");
            DropColumn("dbo.Team", "DateCreated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Team", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Team", "UserId", c => c.String());
            AddColumn("dbo.Score", "DateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Match", "EndDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Match", "StartDateTime", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Team", "Match_Id", "dbo.Match");
            DropForeignKey("dbo.Player", "Team_Id", "dbo.Team");
            DropForeignKey("dbo.Score", "PlayerId", "dbo.Player");
            DropIndex("dbo.Score", new[] { "PlayerId" });
            DropIndex("dbo.Player", new[] { "Team_Id" });
            DropIndex("dbo.Team", new[] { "Match_Id" });
            DropColumn("dbo.Team", "Match_Id");
            DropColumn("dbo.Team", "UtcDateCreated");
            DropColumn("dbo.Team", "Name");
            DropColumn("dbo.Score", "UtcDateTime");
            DropColumn("dbo.Score", "Points");
            DropColumn("dbo.Score", "PlayerId");
            DropColumn("dbo.Score", "MatchId");
            DropColumn("dbo.Match", "UtcEndDateTime");
            DropColumn("dbo.Match", "UtcStartDateTime");
            DropTable("dbo.Player");
        }
    }
}
