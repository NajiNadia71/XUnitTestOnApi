using System.ComponentModel.DataAnnotations.Schema;

namespace APIXUnitTest.Model
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Description { get; set; }
        public string Capital { get; set; }
        public string CountryInformation { get; set; }
        public int SurfaceArea { get; set; }
        public int Population { get; set; }

        [Column("ContinentId")]
        public int ContinentId { get; set; }
        [ForeignKey("ContinentId")]
        public virtual Continent Continent { get; set; } = null!;


    }
}
