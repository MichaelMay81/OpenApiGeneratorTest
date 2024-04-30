using OpenApiGeneratorTest.WebApi.Client.Api;
using OpenApiGeneratorTest.WebApi.Client.Client;

namespace Test;

public class UnitTestDateOnly
{
    private readonly WebApiApi webApi;

    public UnitTestDateOnly()
    {
        webApi = new WebApiApi("http://localhost:5188") {
            ExceptionFactory = (methodName, response) =>
                new ApiException((int)response.StatusCode,
                    string.Format("Error calling {0}: {1}", methodName, response.ErrorText),
                    response.RawContent, response.Headers)
        };

    }

    /// <summary>
    /// GetWeatherForecast fails with
    /// 'Unable to cast object of type 'System.DateTime' to type 'System.DateOnly'
    /// because ApiClientGenerator decorates DateOnly with [JsonConverter(typeof(OpenAPIDateConverter))]
    /// </summary>
    [Fact]
    public void UnableToCastFromDateTimeToDateOnly()
    {
        try
        {
            webApi.GetWeatherForecast();
        }
        catch (Exception e)
        {
            Assert.Fail(e.Message);
        }
    }

    /// <summary>
    /// GetTestParams fails with
    /// 'Cannot convert null value to System.DateOnly.'
    /// because ApiClientGenerator does not make swagger nullable Date to C# Nullable DateOnly
    /// </summary>
    [Fact]
    public void DateOnlyNotNullable()
    {
        try
        {
            webApi.GetTestParams();
        }
        catch (Exception e)
        {
            Assert.Fail(e.Message);
        }
    }
}
