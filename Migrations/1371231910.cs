using FluentMigrator;

namespace Migrations
{
	[Migration(1371231910)]
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