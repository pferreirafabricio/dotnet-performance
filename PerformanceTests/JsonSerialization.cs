using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;

namespace PerformanceTests;

public class JsonSerialization
{
    private string json = "{ \"id\": 1, \"name\": \"abc\", \"value\": 10.01 }";

    private JsonSerializerOptions jsonSerializerOptions;

    [GlobalSetup]
    public void Setup()
    {
        jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }

    [Benchmark]
    public void JsonSerializerDeserialize()
    {
        var obj = System.Text.Json.JsonSerializer.Deserialize<Product>(json);
    }

    [Benchmark]
    public void NewtonsoftJsonDeserialize()
    {
        var obj = JsonConvert.DeserializeObject<Product>(json);
    }
}