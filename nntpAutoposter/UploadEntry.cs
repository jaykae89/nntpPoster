﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nntpAutoposter
{
    class UploadEntry
    {
        public Int64 ID { get; set; }
        public String Name { get; set; }
        public Int64 Size { get; set; }
        public String CleanedName { get; set; }
        public String HashedName { get; set; }
        public Boolean RemoveAfterVerify { get; set; }
        public DateTime CreatedAt { get; set; }
        public Nullable<DateTime> UploadedAt { get; set; }
        public Nullable<DateTime> NotifiedIndexerAt { get; set; }
        public Nullable<DateTime> SeenOnIndexAt { get; set; }
        public Boolean Cancelled { get; set; }       
    }
}