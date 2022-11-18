using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace SerialTest
{
    [Serializable]
    //[XmlRoot("Neeraj")]
    public class Member
    {
        
        public string Name { get; set; }
       // [XmlElement("Neeraj_Email")]
        public string E_mail { get; set; }
       /// [XmlElement("Age")]
        public int Age { get; set; }    
    }
}
