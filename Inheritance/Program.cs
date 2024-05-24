namespace Inheritance
{
    //Hybrid Inheritance
    interface High
    {
        void HighInterfaceMethod();
    }
    //Multiple Inheritance
    //C# doesn't support Multiple Inheritance but By using Interface we can
    //achieve Multiple Inheritance.
    interface Interface1 :High
    {
        void InterfaceMethod1();
    }
    interface Interface2
    {
        void InterfaceMethod2();
    }
    class Multiple : Interface1, Interface2
    {
        public void HighInterfaceMethod()
        {
            Console.WriteLine("High Interface method called in derived class of derived interface.");
        }
        public void InterfaceMethod2()
        {
            Console.WriteLine("method from interface 2.");
        }

        public void InterfaceMethod1()
        {
            Console.WriteLine("method from interface 1.");
        }
    }
    //Hierarchical inheritance
    internal class Parent
    {
        internal virtual void MethodParent()
        {
            Console.WriteLine("Parent Method");
        }
    }
    internal class Child1:Parent
    {
        void MethodChild1()
        {
            Console.WriteLine("Child1 method");
        }
    }
    internal class Child2:Parent
    {
        internal override void MethodParent()
        {
            Console.WriteLine("Overrided Parent class method");
        }
        void MethodChild2()
        {
            Console.WriteLine("Child2 method");
        }
    }
    //Multi-Level Inheritance
    class ParentOfBase
    {
        internal void SuperMostMethod()
        {
            Console.WriteLine("Super most class method");
        }
    }
    //Single level inheritance
    class Base : ParentOfBase
    {
        public virtual void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
    }
    class Derived :Base
    {
        public override void BaseMethod()
        {
            Console.WriteLine("Override method");
        }
        internal void DerivedMethod()
        {
            Console.WriteLine("Derived Method");
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //single Inheritance
            Derived derived = new Derived();
            derived.BaseMethod();
            derived.DerivedMethod();
            //multilevel Inheritance
            Derived derived1 = new Derived();
            derived1.SuperMostMethod();
            //Hierarchical inheritance
            Child1 child1 = new Child1();
            child1.MethodParent();
            Child2 child2 = new Child2();
            child2.MethodParent();//overriding in child class.
            //Multiple Inheritance
            Interface1 interface1 = new Multiple();
            Interface2 interface2 = new Multiple();
            Multiple multiple = new Multiple();
            multiple.InterfaceMethod2();
            interface1.InterfaceMethod1();
            interface2.InterfaceMethod2();
            //Hybrid Interitance
            interface1.HighInterfaceMethod();
            Console.ReadKey();
        }
    }
}
