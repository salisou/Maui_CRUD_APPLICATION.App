namespace Maui_CRUD_APPLICATION.Models
{
    //public class ChatModel
    //{
    //    public string Avatar {get; set;}
    //    public string Name { get; set;}
    //    public DateTime LastMassageAt { get; set;}
    //    public string LastMessage { get; set;}
    //    public int UnreadCount { get; set;}
    //}

    public record ChatModel(string Avatar, string Name, DateTime LastMassageAt, string LastMessage, int UnreadCount)
    {
        public string LasMessageAtDisplay => $"{LastMassageAt:hh:mm}";
    }
}
