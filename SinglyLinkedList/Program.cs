using System;

namespace SinglyLinkedList
{
    class Program
    {
        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            private Node<T> Head = null;

            public void AddNodeFromFront(T value)
            {
                if (Head == null)
                {
                    Head = new Node<T>() { Value = value };
                    Head.Next = null;
                }
                else
                {
                    Node<T> temp = Head;
                    Head = new Node<T>() { Value = value };
                    Head.Next = temp;
                }
            }// end AddNodeFromFront()


            public void AddFrontTail(T value)
            {
                if (Head == null)
                {
                    Head = new Node<T>() { Value = value };
                    Head.Next = null;
                }
                else
                {
                    Node<T> temp = Head;
                    Node<T> currentNode = null;
                    while (temp != null)
                    {
                        currentNode = temp;
                        temp = temp.Next;
                    }// end whil e

                    Node<T> newNode = new Node<T>() { Value = value };
                    currentNode.Next = newNode;
                    newNode.Next = null; 


                }
            }// end AddFrontTail()


            public void DeleteNode (T value)
            {
                Node<T> tempNode = Head; 
                Node<T> nodeToDelete = null;
                Node<T> prevNode = null;

                // Just one node in the list 
                if (tempNode.Next == null)
                {
                    Head = null;
                }
                else
                {

                    while (tempNode != null)
                    {


                        // if (prevNode != null) Console.WriteLine($">> {prevNode.Value}"); 

                        if (tempNode.Value.Equals(value))
                        {
                            nodeToDelete = tempNode;

                            if (prevNode == null) // Deleting Head item
                            {
                                Head = Head.Next;
                            }
                            else // Deleting others
                            {
                                prevNode.Next = nodeToDelete.Next;

                            }

                            break; 
                        }

                        prevNode = tempNode;
                        tempNode = tempNode.Next;

                    }// end while


                    

                }// end if 
                


            }// end DeleteNode()

            public void ShowList()
            {
                Node<T> temp = Head;

                while (temp != null)
                {
                    Console.WriteLine(temp.Value);

                    temp = temp.Next;
                }


            }// end ShowList()
        }

        

        static void Main(string[] args)
        {
            var app = new Node<int>();
            app.AddNodeFromFront(2); 
            app.AddNodeFromFront(3); 
            app.AddNodeFromFront(1); 
            app.AddNodeFromFront(4);

            app.AddFrontTail(10);

            // app.DeleteNode(3); 
            //app.DeleteNode(4);
            app.DeleteNode(10);

            app.ShowList();

            Console.WriteLine("\n\nProgram Finished ...");

        }
    }
}
