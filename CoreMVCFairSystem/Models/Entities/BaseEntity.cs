﻿using CoreMVCFairSystem.Models.Enums;
using CoreMVCFairSystem.Models.Interfaces;

namespace CoreMVCFairSystem.Models.Entities
{
    public abstract class BaseEntity:IEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.UtcNow;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
