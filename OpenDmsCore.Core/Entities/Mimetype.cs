using System;
using System.Collections.Generic;

namespace OpenDmsCore.Core.Entities
{
    public partial class Mimetype
    {
        public int Id { get; set; }
        public string Extension { get; set; }
        public string KindOfDocument { get; set; }
        public string MimeType { get; set; }
    }
}
