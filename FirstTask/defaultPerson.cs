using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class Person
    {
        public string _id { get; set; }
        string _identifity { get; set; }
        defaultInfo _person { get; set; }
        
        internal class defaultInfo
        {
            internal string _name { get; set; }
            internal string _bio { get; set; }
            internal string _someInfo { get; set; } = string.Empty;
            internal List<string> folowers { get; set; } = new List<string> { };
            internal List<string> folowings { get; set; } = new List<string> { };

            //Соу мач как-то выходить, не?

            //Конструктор, если кого-то нового создаем
            internal defaultInfo(string name, string bio, string someInfo)
            {
                _name = name;
                _bio = bio;
                _someInfo = someInfo;
            }
        }

        public Person(string id, string identifity, string name, string bio, string someInfo)
        {
            _id = id;
            _identifity = identifity;
            _person = new defaultInfo(name, bio, someInfo);
            Console.WriteLine(_person._name);
        }
    }
}
