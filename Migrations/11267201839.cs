using FluentMigrator;

namespace Migrations
{
	[Migration(11267201839)]
	public class createTableOrder : Migration
	{
		public override void Up()
		{
			Execute.Script("Sql/Up/createTableOrder.Up.sql");
		}
		public override void Down()
		{
			Execute.Script("Sql/Down/createTableOrder.Down.sql");
		}
	}
}