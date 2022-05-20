namespace MediatorExample
{
    public delegate void MessageBroadcastedEventHandler(string id, string message);

    public class User
    {
        public event MessageBroadcastedEventHandler MessageBroadcasted;

        public string Name
        {
            get;
        }

        public string Role
        {
            get;
        }

        public string Id
        {
            get;
        }

        public User(string name, string role, string id)
        {
            Name = name;
            Role = role;
            Id = id;
        }

        public void SendMessage(string message)
        {
            OnMessageBroadcasted(message);
        }

        public void ReceiveMessage(User from, string message)
        {
            Console.WriteLine("\"" + this.Name + "\" received a message from \"" + from.Name + "\": \"" + message + "\"");
        }

        protected void OnMessageBroadcasted(string message)
        {
            MessageBroadcasted?.Invoke(Id, message);
        }
    }
}
