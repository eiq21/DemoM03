using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public static class MigrationBuilderExtensions
    {
        public static MigrationBuilder CreateOrDeleteView(this MigrationBuilder migrationBuilder,
            string query)
        {
            migrationBuilder.Sql(query);
            return migrationBuilder;
        }
    }
}
