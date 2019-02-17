namespace MealPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredient",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RecipeID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Unit = c.String(),
                        Item = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Recipe", t => t.RecipeID, cascadeDelete: true)
                .Index(t => t.RecipeID);
            
            CreateTable(
                "dbo.Recipe",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(),
                        PrepTime = c.Int(nullable: false),
                        CookTime = c.Int(nullable: false),
                        Calories = c.Int(nullable: false),
                        NumServings = c.Int(nullable: false),
                        Course = c.String(),
                        Cuisine = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Instruction",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RecipeID = c.Int(nullable: false),
                        StepNum = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Recipe", t => t.RecipeID, cascadeDelete: true)
                .Index(t => t.RecipeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instruction", "RecipeID", "dbo.Recipe");
            DropForeignKey("dbo.Ingredient", "RecipeID", "dbo.Recipe");
            DropIndex("dbo.Instruction", new[] { "RecipeID" });
            DropIndex("dbo.Ingredient", new[] { "RecipeID" });
            DropTable("dbo.Instruction");
            DropTable("dbo.Recipe");
            DropTable("dbo.Ingredient");
        }
    }
}
