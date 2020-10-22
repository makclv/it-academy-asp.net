using Microsoft.AspNet.SignalR;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}