using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace SerialTest
{
    public class Program
    {

        public static void Main(string[] s)
        {
            SerilizeObject();
            SerializeList();
            Serializable_soap();
            Console.WriteLine("Process Done");
            Console.ReadKey();
        }

        private static void SerilizeObject()
        {
            var Member = new Member
            {
                Name = "Neeraj",
                E_mail = "ASDF@gmail.com",
                Age = 12
            };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Member));
            using (var writer = new StreamWriter(@"E:\sample.xml"))
            {
                xmlSerializer.Serialize(writer, Member);
            }

        }

        public static void SerializeList()
        {
            List<Member> list = new List<Member>()
            {
                new Member
                {
                    Name="Karthik",
                    E_mail="asd@Gmail.com",
                    Age=23
                },
                new Member
                {
                    Name="Purush",
                    E_mail="asdF@gmail.com",
                    Age=24
                }
            };


            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Member>));
            using (StreamWriter sw = new StreamWriter(@"E:\ sample1.xml"))
            {
                xmlSerializer.Serialize(sw, list);
            }




        }
        public static void Serializable_soap()
        {
            List<Member> list1 = new List<Member>()
            {
                new Member
                {
                    Name="Karthik",
                    E_mail="asd@Gmail.com",
                    Age=23
                },
                new Member
                {
                    Name="Purush",
                    E_mail="asdF@gmail.com",
                    Age=24
                }
            };

            SoapFormatter sf = new SoapFormatter();
            using (StreamWriter sw = new StreamWriter(@"E:\sample23.xml"))
            {
                sf.Serialize(sw, list1);
            }

        }

    }
}
