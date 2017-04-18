using Xunit;
using Shouldly;

namespace GoogleDistanceMatrix
{
    public class ProgramTest
    {
        [Fact]
        public void DistanceMatrixConfigTest()
        {
            DistanceMatrixConfig conf = new DistanceMatrixConfig();
            conf.AddParam = "Manchester";
            conf.Url.ShouldContain("Manchester");
        }

        [Fact]
        public void ApiCallerTest()
        {
            ApiCaller api = new ApiCaller("https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins=Manchester,UK&destinations=London,UK&key=");
            var response = api.Response;
            response.ToString().ShouldContain("208 mi");
            response.ToString().ShouldContain("3 hours 54 mins");
        }

    }
}