using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADBFinal05.Models
{
    public class KhoaModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        
        [BsonElement("MaKhoa")]
        public string MaKhoa { get; set; }

        [BsonElement("TenKhoa")]
        public string TenKhoa { get; set; }

        [BsonElement("NamThanhLap")]
        public string NamThanhLap { get; set; }
    }
}