using System.ComponentModel.DataAnnotations;

namespace WikiMovier.Models
{
	public class Movie
    {
	    public int Id { get; set; }
	    public string UserName { get; set; }
		[Required]
		[MaxLength(40)]
		[MinLength(2)]
	    public string Query { get; set; }
    }
}
