using Grpc.Net.Client;
using Servicetwo;


//create chanel use grpc
var channel = GrpcChannel.ForAddress("http://localhost:5089");
var client = new Average.AverageClient(channel);

//create request
var request = new AverageRequest();
request.Numbers.Add(5);
request.Numbers.Add(5);
request.Numbers.Add(5);

//call service
var response =  client.GetAverage(request);

Console.WriteLine(response.Average);
