using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADBFinal05.Models
{
    public class SinhVienModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("MSSV")]
        public string MSSV { get; set; }

        [BsonElement("TenSV")]
        public string TenSV { get; set; }

        [BsonElement("_Khoa")]
        public ObjectId _Khoa { get; set; }
    }
}