// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.MariaDB
{
	[Table("inheritanceparent")]
	public class Inheritanceparent
	{
		[Column("InheritanceParentId", IsPrimaryKey = true)] public int     InheritanceParentId { get; set; } // int(11)
		[Column("TypeDiscriminator"                       )] public int?    TypeDiscriminator   { get; set; } // int(11)
		[Column("Name"                                    )] public string? Name                { get; set; } // varchar(50)
	}
}