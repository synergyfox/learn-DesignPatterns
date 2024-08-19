using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{

    #region ChatUser
        
    public abstract class User {
        protected string Name;
        protected User(string name)
        {
                this.Name = name;
        }
        public IChatGroupMediator Mediator { get; set; }
        public abstract void Send(string message);
        public abstract void Receive(string message);

    }

    public class ConcreteUser : User
    {
        public ConcreteUser(string name) : base(name)
        {

        }

        public override void Receive(string message)
        {
            Console.WriteLine(this.Name + ": Received Message:" + message);
        }

        public override void Send(string message)
        {
            Console.WriteLine(this.Name + ": Sending Message=" + message + "\n");
            Mediator.SendMessage(message, this);
        }
    }
    #endregion

    #region ChatGroup

    public interface IChatGroupMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(User user);
    }

    public class ChatGroupMediator : IChatGroupMediator
    {
        private List<User> UsersList = new List<User>();

        void IChatGroupMediator.RegisterUser(User user)
        {
            
            UsersList.Add(user);            
            user.Mediator = this;
        }

        void IChatGroupMediator.SendMessage(string message, User user)
        {
            foreach (User u in UsersList)
            {
                
                if (u != user)
                {
                    u.Receive(message);
                }
            }

        }
    }
    #endregion




}
