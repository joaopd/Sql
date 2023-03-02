using FluentMigrator;

namespace Migrations
{
	[Migration(1_1675202756)]
	public class createTableTag6 : Migration
	{
		public override void Up()
		{
			Execute.Script("Sql/Sql/Up/1_createTableTag6.Up.sql");
		}
		public override void Down()
		{
		}
	}
}