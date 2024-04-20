using System.ComponentModel.DataAnnotations;

namespace BlogSolution.Core.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public DataType CreatedDate { get; set; }
    public DataType UpdatedDate { get; set; }
}
