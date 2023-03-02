using FluentMigrator;

namespace Migrations
{
	[Migration(3_1206474348)]
	public class createTableTag : Migration
	{
		public override void Up()
		{
			Execute.Script("Sql/Sql/Up/3_createTableTag.Up.sql");
		}
		public override void Down()
		{
		}
	}
}