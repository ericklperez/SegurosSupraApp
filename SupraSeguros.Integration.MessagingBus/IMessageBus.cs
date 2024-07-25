using SupraSeguros.Integration.Messages;

namespace SupraSeguros.Integration.MessagingBus
{
    public interface IMessageBus
    {
        Task PublishMessage(IntegrationBaseMessage message, string topicMessage);
    }
}
