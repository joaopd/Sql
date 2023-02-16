using FluentMigrator;

namespace Migrations
{
	[Migration(11206474348)]
	public class createTableTag : Migration
	{
		public override void Up()
		{
			Execute.Script("Sql/Up/createTableTag.Up.sql");
		}
		public override void Down()
		{
			Execute.Script("Sql/Down/createTableTag.Down.sql");
		}
	}
}