using FluentMigrator;

namespace Migrations
{
	[Migration(100001737603315)]
	public class createTableTag6 : Migration
	{
		public override void Up()
		{
			Execute.Script("/home/joaoc/Documents/apps/x/Sql/Up/1_createTableTag6.Up.sql");
		}
		public override void Down()
		{
		}
	}
}