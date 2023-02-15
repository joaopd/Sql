using FluentMigrator;

namespace Migrations
{
	[Migration(1458424506)]
	public class InsertOrder : Migration
	{
		public override void Up()
		{
			Execute.Script("Sql/Up/InsertOrder.Up.sql");
		}
		public override void Down()
		{
		}
	}
}