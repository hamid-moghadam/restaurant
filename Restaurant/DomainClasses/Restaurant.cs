using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using DomainClasses.Hash;

namespace DomainClasses
{
    [Serializable]
    public class Restaurant
    {
        public Restaurant()
        {
        }

        public Restaurant(string name, string owner,string user, string pass, int tax)
        {
            Name = name;
            Owner = owner;
            Username = user;
            Password = pass;
            Tax = tax;
        }

        public string Name { get; set; }
        public string Owner { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Tax { get; set; }


        public override string ToString()
        {
            string pass = Password.CustomHash();
            return string.Format($"{Name}\r\n{Owner}\r\n{Username}\r\n{pass}\r\n{Tax}");
        }

        public bool Save()
        {
            string path = Directory.GetCurrentDirectory() + "\\info.txt";
            if (Name == "" || Owner == "" || Username == "" || Password == "" || Tax < 0)
                return false;
            this.Password = this.Password.CustomHash();
            using (FileStream stream = File.Create(path))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
            }
            return true;;
        }

        public bool CanLogin(string user, string pass)
        {
            return user == this.Username && pass.CustomHash() == this.Password;
        }
    }
}
