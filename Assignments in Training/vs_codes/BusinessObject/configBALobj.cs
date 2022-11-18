using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class configBALobj
    {
        private int _BloggerID;

        public int BloggerID
        {
            get { return _BloggerID; }
            set 
            {
                if (value <= 0)
                {
                    throw new NullReferenceException("Category id must be greater than 0");
                }
                else
                {
                    _BloggerID = value;
                }

            } 
        }
        private string _BloggerName;
        public string BloggerName
        {
            get { return _BloggerName; }
            set { _BloggerName = value; }
        }
        private string _BloggerSubject;
        public string BloggerSubject
        {
            get { return _BloggerSubject; }
            set { _BloggerSubject = value; }
        }

        private int _BlogID;
        public int BlogID
        {
            get { return _BlogID; }
            set {_BlogID = value; }
        }

        private string _BlogName;
        public string BlogName
        {
            get { return _BlogName; }
            set { _BlogName = value; }
        }
        private string _BlogContent;
        public string BlogContent
        {
            get { return _BlogContent; }
            set { _BlogContent = value; }
        }
        private DateTime _BlogDate;
        public DateTime BlogDate
        {
            get { return _BlogDate; }
            set { _BlogDate = value; }
        }
        
        public static void Main(String []args)
        {

        }
    }
}
