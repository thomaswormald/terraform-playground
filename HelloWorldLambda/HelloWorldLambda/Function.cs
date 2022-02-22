using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelloWorldLambda
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest input, ILambdaContext context)
        {
            if (input.QueryStringParameters.TryGetValue("name", out var name))
            {
                return new APIGatewayProxyResponse()
                {
                    Body = $"Hello, {name}",
                    IsBase64Encoded = false,
                    StatusCode = 200
                };
            }
            else
            {
                return new APIGatewayProxyResponse()
                {
                    StatusCode = 400
                };
            }
        }
    }
}
