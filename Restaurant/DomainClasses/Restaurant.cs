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

        public string Save()
        {
            if (Name == "" || Owner == "" || Username == "" || Password == "" || Tax < 0)
                return "عملیات موفقیت آمیز نبود. مجدد با اطلاعات کامل سعی کنید";
            this.Password = this.Password.CustomHash();
            using (FileStream stream = File.Create(Path()))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
            }
            //using (StreamWriter writer = new StreamWriter(fileName))
            //{
            //    writer.WriteLineAsync(ToString());
            //}
            return "عملیات موفقیت آمیز بود";
        }

        public static Restaurant GetCurrent()
        {
            string[] info = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\info.txt");
            Restaurant r;
            using (FileStream stream = File.OpenRead(Path()))
            {
                var formatter = new BinaryFormatter();
                 r = (Restaurant)formatter.Deserialize(stream);
            }
            //Stream s = new StreamReader(Directory.GetCurrentDirectory() + "\\info.txt").BaseStream;
            //IFormatter deserilize = new BinaryFormatter();
            //deserilize.Deserialize(s);
            //s.
            //return  new Restaurant(info[0],info[1],info[2],info[3],int.Parse(info[4]));
            return r;
        }

        public bool CanLogin(string user, string pass)
        {
            return user == this.Username && pass.CustomHash() == this.Password;
        }

        private static string Path()
        {
            return Directory.GetCurrentDirectory() + "\\info.txt";
        }
    }
}
