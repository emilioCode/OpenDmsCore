namespace OpenDmsCore.Core.Entities
{
    public partial class Company : BaseEntity
    {
        public string EntityName { get; set; }
        public bool Disabled { get; set; }
    }
}
