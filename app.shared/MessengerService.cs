using System;

namespace App.Shared
{
    public class MessengerService
    {
        public MessengerService() => Name = "World";

        public MessengerService(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));

        public string Name { get; }

        public string GetMessage()
        {
            return $"Hello, {Name}!";
        }
    }
}