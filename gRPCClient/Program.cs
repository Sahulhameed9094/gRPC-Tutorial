using Grpc.Net.Client;
using gRPCClient;



GrpcChannel grpcChannel = GrpcChannel.ForAddress("https://localhost:7240");
var client = new Greeter.GreeterClient(grpcChannel);

HelloRequest request = new HelloRequest() { Name = "sahul hameed.s" };
HelloReply response = client.SayHello(request);
Console.WriteLine(response.Message);
Console.ReadLine();