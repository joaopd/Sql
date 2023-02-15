using FluentMigrator;

namespace Migrations
{
	[Migration(11223753393)]
	public class dateTableOrder : Migration
	{
		public override void Up()
		{
			Execute.Script("Sql/Up/UpdateTableOrder.Up.sql");
		}
		public override void Down()
		{
		}
	}
}