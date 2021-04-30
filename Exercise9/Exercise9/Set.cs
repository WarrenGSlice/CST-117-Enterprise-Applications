using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
/* * * * * * * * * * * *
 * Warren Peterson * * *
 * This is my own work *
 * CST-117 4/30/2021 * *
 * Exercise 9  * * * * *
 * Code Checking * * * *
 * * * * * * * * * * * */

// Corrected by <Warren Peterson>

namespace Exercise9
{
    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }
        public bool addElement(int val)
        {
            if (ContainsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }
        private bool ContainsElement(int val)
        {
            return elements.Contains(val);  //corrected code line
            //replaced with List<T>.Contains method

            //for (int i = 0; i < elements.Count; i++)
            //{
            //    if (val == elements[i])
            //        return true;
            //    else
            //        return false;
            //}
            //return false;
        }
        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }
        public void clearSet()
        {
            elements.Clear();
        }
        public Set union(Set rhs)
        {
            // needs to return a new Set object instead of adding to current object.
            Set union = new Set();

            //Add the current elements to the new object.
            for (int i = 0; i < this.elements.Count; i++)
            {
                union.addElement(this.elements[i]);
            }
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                //Adds elements to the current object
                //this.addElement(rhs.elements[i]);
                union.addElement(rhs.elements[i]);
            }
            return union;
            //return rhs;
        }
    }
}