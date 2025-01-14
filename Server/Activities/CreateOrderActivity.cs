using Elsa.Workflows;
using MassTransit;
using Server.Messages.Requests;

namespace Server.Activities;

public class CreateOrderActivity : CodeActivity
{
    protected override async ValueTask ExecuteAsync(ActivityExecutionContext context)
    {
        var bus = context.GetRequiredService<IBus>();

        await bus.Publish(new CreateOrder());
    }
}