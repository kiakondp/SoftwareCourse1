using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCourse1
{
    public class CatFood : Product
    {
        public bool IsKittenFood { get; set; }

        public override string ToString() 
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Kitten Food: {IsKittenFood}";
        }
    }
}
