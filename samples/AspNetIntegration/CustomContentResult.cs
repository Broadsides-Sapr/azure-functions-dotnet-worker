using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetIntegration
{
    [JsonConverter(typeof(CustomContentResultConverter))]
    public class CustomContentResult : ContentResult
    {
    }
}
