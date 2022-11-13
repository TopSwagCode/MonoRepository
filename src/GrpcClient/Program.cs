using Grpc.Net.Client;
using GrpcService;

using var channel = GrpcChannel.ForAddress("https://grpc.topswagcode.com");

var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
     new HelloRequest { Name = "TopSwagCode" });
Console.WriteLine(reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();