using System;
using System.Collections.Generic;

namespace OpenDmsCore.Core.Entities
{
    public partial class Mimetype
    {
        public int Id { get; set; }
        public string Extension { get; set; }
        public string KinfOfDocument { get; set; }
        public string MimeType { get; set; }
    }
}
