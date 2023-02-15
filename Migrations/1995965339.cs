using FluentMigrator;

namespace Migrations
{
	[Migration(1995965339)]
	public class AlterTableOrder : Migration
	{
		public override void Up()
		{
			Execute.Script("Sql/Up/AlterTableOrder.Up.sql");
		}
		public override void Down()
		{
		}
	}
}