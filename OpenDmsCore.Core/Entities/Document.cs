using System;

namespace OpenDmsCore.Core.Entities
{
    public partial class Document
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public string Extension { get; set; }
        public float Size { get; set; }
        public int TeamId { get; set; }
        public int EntityId { get; set; }
        public DateTime InsertionDate { get; set; }
        public string PathAlternative { get; set; }
        public string CommentDetail { get; set; }
        public string DistinctDetail { get; set; }
        public int IdUser { get; set; }
        public bool Disabled { get; set; }
    }
}
