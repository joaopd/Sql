using FluentMigrator;

namespace Migrations
{
	[Migration(200002100920385)]
	public class insertintotag6 : Migration
	{
		public override void Up()
		{
			Execute.Script("/home/joaoc/Documents/apps/x/Sql/Up/2_insertintotag6.Up.sql");
		}
		public override void Down()
		{
		}
	}
}