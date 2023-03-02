using FluentMigrator;

namespace Migrations
{
	[Migration(2_1333546883)]
	public class createTableTagcoy : Migration
	{
		public override void Up()
		{
			Execute.Script("Sql/Sql/Up/2_createTableTag.Up copy.sql");
		}
		public override void Down()
		{
		}
	}
}