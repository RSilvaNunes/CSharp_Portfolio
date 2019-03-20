using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raquel_da_Silva_Nunes_Lab_1B_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use of generic LinkedList data structure to mantain the list of students
            LinkedList<Student> list = new LinkedList<Student>();

            Student student1 = new Student(1, "Raquel");
            Student student2 = new Student(2, "Roberto");
            Student student3 = new Student(3, "John");
            Student student4 = new Student(4, "Claire");
            Student student5 = new Student(5, "Ruth");

            list.AddLast(student1);
            list.AddLast(student2);
            list.AddLast(student3);
            list.AddLast(student4);
            list.AddLast(student5);

            // item (a) Add a Student to the list
            Student newStudent = new Student(6, "Katie");
            AddLinkedListItem(list, newStudent);

            // item (b) Remove a Student from the list
            RemoveLinkedListItem(list, student5);

            // item (c) Display the items of the LinkedList
            PrintLinkedList(list);

            // item (d) Search a Student
            Student studentInTheList = SearchLinkedListItem(list, student4);
            //Console.WriteLine(studentInTheList);
            Student studentOffTheList = SearchLinkedListItem(list, student5);
            Console.WriteLine(studentOffTheList);

            // item (e) Clear the LinkedList
            RemoveAllLinkedListItems(list);
            PrintLinkedList(list);
        }
        
        //item (a) Define a method in order to add a Student to the list
        public static void AddLinkedListItem(LinkedList<Student> list, Student student)
        {
            list.AddLast(student);
        }
        //item (b) Define a method in order to remove a Student from the list
        public static void RemoveLinkedListItem(LinkedList<Student> list, Student student)
        {
            list.Remove(student);
        }
        //item (c) Define a method PrintLinkedList in order to display the items of the LinkedList
        public static void PrintLinkedList(LinkedList<Student> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        //item (d) Define a metod SearchLinkedListItem in order to search a Student
        public static Student SearchLinkedListItem(LinkedList<Student> list, Student student)
        {
            LinkedListNode<Student> studentFound = list.Find(student);
            if (studentFound != null)
            {
                return studentFound.Value;
            }
            else
            {
                return null;
            }
        }
        //item (e) Define a method RemoveAllLinkedItems in order to clear the LinkedList
        public static void RemoveAllLinkedListItems(LinkedList<Student> list)
        {
            var currentNode = list.First;

            while ((currentNode.Next != null))
            {
                list.Remove(currentNode.Next); // remove next node
            }
            list.RemoveFirst();
        }
    }
}

