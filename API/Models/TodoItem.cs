using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Category { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Timestamp {get; set;}
        public decimal Longitude {get; set;}
        public decimal Latitude {get; set;}
        public decimal Altitude {get; set;}
        public decimal Radius {get; set;}


    }
}