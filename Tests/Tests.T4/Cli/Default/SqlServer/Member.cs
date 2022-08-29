// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.SqlServer
{
	[Table("Member")]
	public class Member
	{
		[Column("MemberId", IsPrimaryKey = true , IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public int    MemberId { get; set; } // int
		[Column("Alias"   , CanBeNull    = false                                                             )] public string Alias    { get; set; } = null!; // nvarchar(50)

		#region Associations
		/// <summary>
		/// FK_Provider_Member backreference
		/// </summary>
		[Association(ThisKey = nameof(MemberId), OtherKey = nameof(SqlServer.Provider.ProviderId))]
		public Provider? Provider { get; set; }
		#endregion
	}
}