using FluentMigrator;

namespace Migrations
{
	[Migration(1_1675202756)]
	public class createTableTag : Migration
	{
		public override void Up()
		{
			Execute.Script("Sql/Sql/Up/1_createTableTag.Up.sql");
		}
		public override void Down()
		{
		}
	}
}