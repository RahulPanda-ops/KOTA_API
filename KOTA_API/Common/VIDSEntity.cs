using System;
using System.Collections.Generic;
using System.Text;

namespace KOTA_API.Common
{
    internal class VIDSEntity
    {
        public int incedent_id { get; set; }

        public string? CType { get; set; }

        public string? Location { get; set; }

        public string? Lane { get; set; }

        public string? DateTime { get; set; }

        public string? FullImage { get; set; }

        public string? VideoUrl { get; set; }

        public string? Category { get; set; }

        public string? IpAddressCam { get; set; }

        public string? IpAddressSystem { get; set; }

        public string? EventName { get; set; }

        public string? GeneratedBy { get; set; }

        public string? Latitude { get; set; }

        public string? Longitude { get; set; }

        public string? PackageNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? Success { get; set; }
        public string? ErrorCode { get; set; }
        public string? Message { get; set; }
    }
}
