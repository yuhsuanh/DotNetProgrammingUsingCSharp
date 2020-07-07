using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectLab
{
    class InterfaceVSAbstractLab
    {
    }

    interface IMessage
    { 
        bool Send(); //interfaces can have no state or implementation 
        string Message { get; set; }
        string Address { get; set; }
    }

    class MobileMessage : IMessage 
    {
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Send()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// a class that implements an interface must provide an implementation of 
    /// all the methods of that interface
    /// interfaces may be multiple-inherited, abstract classes may not 
    /// </summary>
    class EmailMessage : Message, IMessage , IComparable,IComparer
        {
        //if not impletment Send()
        new  public bool Send()
       {
            Console.Write("Sent");
            return true;
            //throw new Exception("not implemented.");  
        }

        public int CompareTo(object obj)
        {
            if (obj!=null)
            {
                return 0;
            }
            else
            {
                return - 1;
            }
        }

        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }

        public string Message
            {
                get
                {
                    throw new Exception(" not implemented.");   }  
   
               set{ throw new Exception(" not implemented.");   }  
        }

        public string Address
        {
            get
            {
                throw new Exception("not implemented.");    }  
   
           set{ throw new Exception("is not implemented."); }  
        } 
         
    }

    // if one or more methods are abostarct, the class must also be abstract 

    abstract class ShapesClass
    {
        //abstract classes may contain state (data members) and/or implementation (methods) 
        public int width = 0;

        //if one or more methods are abstarct, the class must also be abstract 
        abstract public int Area();
       
        abstract public void SetWidth();

        //abstract classes may contain state (data members) and/or implementation (methods) 
        public void ResetWidth()
        {
            Console.WriteLine("tasks.");
            width = 0;
        } 
    }
    abstract
    class OrderClass
    {
        //abstract classes may contain state (data members) and/or implementation (methods) 
        public int OrderNo = 0;

        //if one or more methods are abostarct, the class must also be abstract  
        abstract public void Invoice(); 
    }
    //abstract 
    /// <summary>
    /// interfaces may be multiple-inherited, abstract classes may not 
    /// </summary>
    class Square : ShapesClass // , OrderClass
    {
        int side = 0;

        public Square(int n)
        {
            side = n;
        }
        public override int Area()
        {
            return side * side;
        }


        // Area method is required to avoid a compile-time error.
        //abstract classes can be inherited without implementing the abstract methods (though such a derived class is abstract itself)
         
        public override void SetWidth()
        {
            throw new NotImplementedException();
        }
    }


    
    // Output: Area of the square = 144



}
