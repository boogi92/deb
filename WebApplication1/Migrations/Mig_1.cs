namespace WebApplication1.Migrations
{
    using FluentMigrator;

    public class Mig_1: Migration
    {
        public override void Up()
        {
            Create.Table("Contects").WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("Text").AsString();
        }

        public override void Down()
        {
            throw new System.NotImplementedException();
        }
    }
}