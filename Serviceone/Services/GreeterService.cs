using Grpc.Core;
using Serviceone;

namespace Serviceone.Services;

public class GreeterService : Average.AverageBase
{

    public override async Task<AverageReply> GetAverage(AverageRequest request, ServerCallContext context)
    {

        int sum=0;
        foreach (var number in request.Numbers)
        {
            sum+=number;
        }
        var average = sum/request.Numbers.Count;
        return new AverageReply
        {
            Average = average
        };
        
    }
    
   

    
}
