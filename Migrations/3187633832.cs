using FluentMigrator;

namespace Migrations
{
	[Migration(187633832)]
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