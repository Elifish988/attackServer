using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace attackServer
{
    internal class Node<T>
    {
        private T _value;
        private Node<T> _next;
        

        public Node(T value){ SetValue(value); SetNext(null); }

        public Node(T value, Node<T> next){ SetValue(value); SetNext(next); }


        public void SetValue(T value){_value = value;}

        public void SetNext(Node<T> next){_next = next;}

        public T GetValue(){return _value;}

        public Node<T> GetNext(){return _next;}

        public string ToString()
        {

            string hesNext = this.GetNext() != null ? "hes" : "no";
            return $"Node value is: {GetValue()} {hesNext} next";
        }

    }
}
