﻿namespace TASK2.Data.Entities {
  public class AuditEntity : BaseEntity {
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
  }
}
