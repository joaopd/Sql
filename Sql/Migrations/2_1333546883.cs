using FluentMigrator;

namespace Migrations
{
	[Migration(2_1333546883)]
	public class insertintotag6 : Migration
	{
		public override void Up()
		{
			Execute.Script("Sql/Sql/Up/2_insertintotag6.Up.sql");
		}
		public override void Down()
		{
		}
	}
}