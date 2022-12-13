using Planovac.Models;

namespace Planovac.ViewModels
{

    public record class StatusTextChanged(string StatusText);
    public record class ViewChanged(string ViewName);
    public record class SaveRequest();
    public record class NewEventCreated(Event newEvent);
    public record class EventArchived(Event archivedEvent);
    public record class PostToTelegramRequest();
}
