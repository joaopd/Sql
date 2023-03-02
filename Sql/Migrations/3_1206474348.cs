using FluentMigrator;

namespace Migrations
{
	[Migration(3_1206474348)]
	public class createTableTag5 : Migration
	{
		public override void Up()
		{
			Execute.Script("Sql/Sql/Up/3_createTableTag5.Up.sql");
		}
		public override void Down()
		{
		}
	}
}