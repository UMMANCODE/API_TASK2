using CourseApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TASK1.Data.Configurations {
  public class GroupConfiguration : IEntityTypeConfiguration<Group> {
    public void Configure(EntityTypeBuilder<Group> builder) {
      builder.Property(g => g.Name)
          .IsRequired();

      builder.Property(g => g.Limit)
          .IsRequired();

      builder.ToTable(t => t.HasCheckConstraint("CK_Group_Limit", "[Limit] >= 5 AND [Limit] <= 18"));
      builder.ToTable(t => t.HasCheckConstraint("CK_Group_Name", "LEN([Name]) >= 4 AND LEN([Name]) <= 5"));
    }
  }
}
