using System;
using System.ComponentModel.DataAnnotations;
using TASK2.Data.Entities;
namespace TASK2.Data.Entities {
  public class Group : AuditEntity {
    public string? Name { get; set; }
    public int Limit { get; set; }
    public List<Student> Students { get; set; } = new();
  }
}

