using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MyCoolFunction
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(WeatherDto data, ILambdaContext context)
        {
            var info = $"The id is : {data.id} of the city {data.Name}";

            context.Logger.Log("test");
            return info.ToUpper();
        }

        public class WeatherDto
        {
            public int id { get; set; }
            public string Name { get; set; }
        }
    }
}
