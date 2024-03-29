﻿using Moq;
using APIXUnitTest.Controllers;
using APIXUnitTest.Model;
using APIXUnitTest.Services;
using APIXUnitTest.VM;

namespace XUnitTestProject
{
    // UnitTestController
    public class UnitTestController
    {
        private readonly Mock<IGeographyService> GeographyService;
        public UnitTestController()
        {
            GeographyService = new Mock<IGeographyService>();
        }
        [Fact]
        public void GetCountryList_CountryList()
        {
            //arrange
            var countryList = GetCountrysData();
            GeographyService.Setup(x => x.GetCountryList())
                .Returns(countryList);
            var countryController = new GeographyController(GeographyService.Object,null);
            //act
            var countryResult = countryController.CountryList();
            //assert
            Assert.NotNull(countryResult);
            Assert.Equal(GetCountrysData().Count(), countryResult.Count());
            Assert.Equal(GetCountrysData().ToString(), countryResult.ToString());
            Assert.True(countryList.Equals(countryResult));
        }
        [Fact]
        public void GetCountryByID_Country()
        {
            //arrange
            var countryList = GetCountrysData();
            GeographyService.Setup(x => x.GetCountryById(2))
                .Returns(countryList[1]);
            var countryController = new GeographyController(GeographyService.Object,null);
            //act
            var countryResult = countryController.GetCountryById(2);
            //assert
            Assert.NotNull(countryResult);
            Assert.Equal(countryList[1].CountryId, countryResult.CountryId);
            Assert.True(countryList[1].CountryId == countryResult.CountryId);
        }
        [Theory]
        [InlineData("Italy")]
        public void CheckCountryExistOrNotByCountryName_Country(string countryName)
        {
            //arrange
            var countryList = GetCountrysData();
            GeographyService.Setup(x => x.GetCountryList())
                .Returns(countryList);
            var countryController = new GeographyController(GeographyService.Object,null);
            //act
            var countryResult = countryController.CountryList();
            var expectedCountryName = countryResult.ToList()[0].CountryName;
            //assert
            Assert.Equal(countryName, expectedCountryName);
        }

        [Fact]
        public void AddCountry_Country()
        {
            //arrange
            var countryList = GetCountrysData();
            var res = new Response();
            res.Message = "Ok";
            GeographyService.Setup(x => x.AddCountry(countryList[2]))
                .Returns(res);
            var countryController = new GeographyController(GeographyService.Object,null);
            //act
            var countryResult = countryController.AddCountry(countryList[2]);
            //assert
            Assert.NotNull(countryResult);
            Assert.Equal(res.Message, countryResult.Message);
            Assert.True(res.Message == countryResult.Message);
        }

        private List<Country> GetCountrysData()
        {
            List<Country> countrysData = new List<Country>
        {
            new Country
            {
                CountryId = 1,
                CountryName = "Italy",
                Description = "Description Italy",
              
            },
             new Country
            {
               CountryId = 2,
                CountryName = "France",
                Description = "Description France",
            },
             new Country
            {
                  CountryId = 3,
                CountryName = "Germany",
                Description = "Description Germany",
            },
        };
            return countrysData;
        }
    }
}
