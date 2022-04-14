using Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool isShowHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }

    }
}
