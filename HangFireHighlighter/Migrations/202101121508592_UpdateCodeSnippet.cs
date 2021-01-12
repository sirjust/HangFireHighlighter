namespace HangFireHighlighter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCodeSnippet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CodeSnippets", "CreatedAt", c => c.DateTime(nullable: false));
            DropColumn("dbo.CodeSnippets", "dateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CodeSnippets", "dateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.CodeSnippets", "CreatedAt");
        }
    }
}
