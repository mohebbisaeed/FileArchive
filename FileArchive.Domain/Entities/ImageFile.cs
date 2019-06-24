using FileArchive.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Domain.Entities
{
    public class ImageFile : Entity
    {
        public Guid FileId { get; set; }
        public virtual File File { get; set; }
        public string Equip_Make { get; set; }
        public string Y_ResolutionY { get; set; }
        public string X_Resolution { get; set; }
        public string User_Comment { get; set; }
        public string DTDigitized { get; set; }
        public string Shutter_Speed { get; set; }
        public string Flash { get; set; }
        public string Equip_Model { get; set; }
        public string F_Number { get; set; }
        public string Experture_Time { get; set; }
        public string Sensing_Method { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string MapUrl { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public double LatitudeGeoCode { get; set; }
        public double LongitudeGeoCode { get; set; }
    }
}
