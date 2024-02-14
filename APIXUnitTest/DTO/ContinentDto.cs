using APIXUnitTest.Model;
using System.Diagnostics.Metrics;

namespace APIXUnitTest.DTO
{
    public class ContinentDto
    {
        public ContinentDto()
        {
          
        }
        public int ContinentId { get; set; }
       // public string Description { get; set; }
       // public int Population { get; set; }
        public string Name { get; set; } = null!;
     //   public virtual ICollection<CountryDto> Countrys { get; set; } = null!;

    }
}
