﻿
namespace GG.Core
{
    public class ToolDto : BaseEntity
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string ImagePath { get; set; }


    }
}