using FluentMigrator;

namespace Migrations
{
	[Migration(300001585208525)]
	public class createTableTag5 : Migration
	{
		public override void Up()
		{
			Execute.Script("/home/joaoc/Documents/apps/x/Sql/Up/3_createTableTag5.Up.sql");
		}
		public override void Down()
		{
		}
	}
}