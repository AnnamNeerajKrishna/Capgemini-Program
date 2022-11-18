using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayerLirbary
{
    public class CategoryBAL
    {
        private int _Categoryid;
        public int CategoryID 
        {
            get 
            {
                return _Categoryid;
            } 
            set 
            {
                if (value <= 0)
                {
                    throw new NullReferenceException("Category id must be greater than 0");
                }
                else
                {
                    _Categoryid = value;
                }
            
            } 
        }
        private string _name;
        public string CategoryName 
        { get { return _name; } 
            set 
            {
                if (value==null || string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Category name cannot be null or empty");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public string CatDesc { get; set; }
    }
}
