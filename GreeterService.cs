using Grpc.Core;
using System.Threading.Tasks;

namespace NetApp
{
    public class GreeterService : Greeter.GreeterBase
    {
        public GreeterService()
        {
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(
                new HelloReply
                {
                    Message = "Hello " + request.Name
                }
                );
        }
    }
}