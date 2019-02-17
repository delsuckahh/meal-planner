namespace MealPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecipeDummyField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recipe", "DummyField", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recipe", "DummyField");
        }
    }
}
