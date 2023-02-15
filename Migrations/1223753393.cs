using FluentMigrator;

namespace Migrations
{
	[Migration(1223753393)]
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