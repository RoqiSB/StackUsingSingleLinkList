using System;

namespace StackUsingSingleLinkList
{
    class node
    {
        public int info;
        public node next;
        public node(int i,node n)
        {
            info = i;
            next = n;
        }
    }
    class stack
    {
        node top;
        public stack()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(int element)
        {
            node fresh;
            fresh = new node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + "pushed");
        }
        public void pop()
        {
            Console.WriteLine("\n The poped elements is: " + top.info);
            top = top.next; // make top point to the next noode is squence
        }
        public void display()
        {
            node tmp;
            if(empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for(tmp = top; tmp != null; tmp = tmp.next)
                {

                }
            }    
        }

    }
}