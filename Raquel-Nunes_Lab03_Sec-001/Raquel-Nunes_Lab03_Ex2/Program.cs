using System;
using LinkedListLibrary;

public static class Extensions
{
    //Exercise 2(a)
    public static T GetFirst<T>(this List<T> obj) where T : IComparable
    {
        // I got the first object, but I also removed it. It's not the goal, but there is no method in the LinkedListLibrary to
        // get the first (or any) object of the list. To achieve this, one would have to change the LinkedListLibrary and to include
        // a method to retrieve the fist object of the list
        T first = obj.RemoveFromFront();
        return first;
    }

    //Exercise 2(b)
    public static T GetLast<T>(this List<T> obj) where T : IComparable
    {
        // Same idea as the previous comment
        T last = obj.RemoveFromBack();
        return last;
    }
    class Program
    {
        static void Main()
        {
            // create List container
            var list = new List<double>(); 

            // use List insert methods       
            list.InsertAtFront(3.5);
            list.Display();
            list.InsertAtFront(4.2);
            list.Display();
            list.InsertAtBack(5.3);
            list.Display();
            list.InsertAtBack(2);
            list.Display();

            //Ecervise 2(a and b)
            Console.WriteLine(list.GetFirst());
            Console.WriteLine(list.GetLast());

            try
            {
                object removedObject = list.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromBack();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromBack();
                Console.WriteLine($"{removedObject} removed");
                list.Display();
            }
            catch (EmptyListException emptyListException)
            {
                Console.Error.WriteLine($"\n{emptyListException}");
            }
        }
    }
}

