using FluentMigrator;

namespace Migrations
{
	[Migration(11206474348)]
	public class V6_createTableTag : Migration
	{
		public override void Up()
		{
			Execute.Script("Sql/Up/V6_createTableTag.Up.sql");
		}
		public override void Down()
		{
			Execute.Script("Sql/Down/V6_createTableTag.Down.sql");
		}
	}
}