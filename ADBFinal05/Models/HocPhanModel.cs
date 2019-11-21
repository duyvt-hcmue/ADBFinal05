using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADBFinal05.Models
{
    public class HocPhanModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("MaHP")]
        public string MaHP { get; set; }

        [BsonElement("TenHP")]
        public string TenHP { get; set; }

        [BsonElement("TC")]
        public int TC { get; set; }
    }
}