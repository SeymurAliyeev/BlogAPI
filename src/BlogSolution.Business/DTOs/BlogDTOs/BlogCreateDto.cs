using System.ComponentModel.DataAnnotations;

namespace BlogSolution.Business.DTOs.BlogDTOs;

public class BlogCreateDto
{
    public string Title { get; set; }
    public string Desc { get; set; }
    public bool IsDeleted { get; set; }
    public DataType CreatedDate { get; set; }
    public DataType UpdatedDate { get; set; }
}
