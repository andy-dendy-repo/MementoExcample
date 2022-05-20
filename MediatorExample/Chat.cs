using System.Collections.Concurrent;

namespace MediatorExample
{
    public class Chat
    {
        private ConcurrentDictionary<string,User> Users = new ConcurrentDictionary<string, User>();

        public void AddUser(User userAdded)
        {
            Users.TryAdd(userAdded.Id, userAdded);
            userAdded.MessageBroadcasted += OnMessageBroadcasted;
        }

        public void RemoveUser(User userRemoved)
        {
            userRemoved.MessageBroadcasted -= OnMessageBroadcasted;
            Users.Remove(userRemoved.Id, out _);
        }

        protected void OnMessageBroadcasted(User from, string message)
        {
            var interestedUsers = Users[from.Id];

            foreach (var user in interestedUsers)
            {
                user.ReceiveMessage(from, message);
            }
        }
    }
}
