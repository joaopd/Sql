using FluentMigrator;

namespace Migrations
{
	[Migration(1206474348)]
	public class createTableTag : Migration
	{
		public override void Up()
		{
			Execute.Script("Sql/Sql/Up/createTableTag.Up.sql");
		}
		public override void Down()
		{
			Execute.Script("Sql/Sql/Down/createTableTag.Down.sql");
		}
	}
}