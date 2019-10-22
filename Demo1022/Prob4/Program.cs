using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region An array of the base class type is created and initialized
            // An array of the base class type is created and initialized 
            // with a member of each class in the hierarchy
            Parent[] myArray = new Parent[3];
            myArray[0] = new Parent();
            myArray[1] = new Child();
            myArray[2] = new GrandChild();

            // Show that a method belonging to the base class is called from a child instance
            // create ParentMethod() in Parent & iterate thru array calling 
            // this method to demonstrate that all child classes have access to it

            // test ParentMethod() by doing a foreach loop

            foreach (Parent element in myArray)
            {
                // GetType property is to get type of an element
                Console.Write("{0}: ", element.GetType());
                // call method for each element in array as it iterates thru the foreach
                element.ParentMethod();
            }
            Console.WriteLine();
            #endregion

            #region Demonstrate overriding a base class method by a child

            foreach (Parent element in myArray)
            {
                // GetType property is to get type of an element
                Console.Write("{0}: ", element.GetType());
                // call method for each element in array as it iterates thru the foreach
                element.SomeMethod();
            }
            Console.WriteLine();

            #endregion

            #region Demonstrate a child method calling the parent's method
            // create a virtual method in parent 
            // override in child and call the parent as part of the implementation
            foreach (Parent element in myArray)
            {
                // GetType property is to get type of an element
                Console.Write("{0}: ", element.GetType());
                // call method for each element in array as it iterates thru the foreach
                element.Method2();
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region Demonstrate use of "as" keyword
            // repeat calls to SomeMethod but using the as keyword
            // element is of type object
            foreach (object element in myArray)
            {
                // have to cast object to a parent type to use SomeMethod
                // creating a new variable of type p
                // as well as casting to type element
                // following 2 lines are doing almost same thing
                //Parent p = element as Parent; - cast is implicit bc of "as" operator
                //Parent p = (Parent)element; - explcit cast
                // Using the "as" is a litte more expressive
                Parent p = (Parent)element;
                Console.Write("{0}: ", p.GetType());
                // call method for each element in array as it iterates thru the foreach
                p.SomeMethod();

            }

            #endregion

            #region Demonstrate use of "is" keyword
            Console.WriteLine("\nDemo use of is");
            foreach (Parent element in myArray)
            {
                // grandchild to child to parent order
                // if you reverse the order, the child is-a parent
                // and grandchild is-a parent
                // because all derrived classes have an is-a relationship to parent
                if (element is GrandChild) Console.WriteLine("GrandChild");
                else if (element is Child) Console.WriteLine("Child");
                else if (element is Parent) Console.WriteLine("Parent");
            }
            Console.WriteLine();
            #endregion

            #region switch statement
            Console.WriteLine("Demo switch:");
            foreach (Parent element in myArray)
            {
                switch (element)
                {
                    // within the case statement creating a variable
                    // can call within the switch statement block on that method
                    // for example, scope of p is only within the case Parent p block
                    case GrandChild gc:
                        Console.WriteLine("GrandChild");
                        break;
                    case Child c:
                        Console.WriteLine("Child");
                        break;
                    case Parent p:
                        Console.WriteLine("Parent");
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }
            }
            Console.WriteLine();
            #endregion

            #region Create an object of "object" type
            //, but initialized of the base class type, 
            // then cast it to the actual type so you can call a method
            object obj = new Parent();
            /// make an explicit cast to see the methods that belong to Parent
            /// first part of below is casting, second part after dot is calling to method
            ((Parent)obj).ParentMethod();

            Parent p2 = new GrandChild();
            ((GrandChild)p2).SpecializedMethod();

            #endregion
        }
    }
}
