using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Migrator.Framework;

namespace Gerenciador.Migracao
{
    [Migrator.Framework.Migration(2011)
    public class CreateTableEmpresa_001: Migrator.Framework.Migration 
    {
        public override void Up()
        {
            Database.AddTable("Empresa", new Column("UserId", DbType.Int32, ColumnProperties.PrimaryKeyWithIdentity),
                                new Column("Username", DbType.AnsiString, 25));
        }

        public override void Down()
        {
            Database.RemoveTable("Empresa");
        }
    }
}
