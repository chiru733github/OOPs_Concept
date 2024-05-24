namespace OOPS_Concept
{

    //Encapsulation
    class Encapsulation
    {
        private int id;
        public int Id 
        {
            get 
            {
                return id; 
            }
            set
            {
                id = value;
            }
        }
        private string? name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
    }
    public class Base
    {
        public string Name;
        public int Id;
        static Base()
        {
            Console.WriteLine("Static Construction is invoke only first instance is created.");
        }
        public Base() :this(10)
        {
            Console.WriteLine("when instances is created this constructor is called parameterized constructor");
        }
        public Base(int id,string Name="Chiru")
        {
            this.Id =id;
            this.Name =Name;
        }
        public string details
        {
            get
            {
                return "Obj id is "+this.Id+" Object name is "+this.Name;
            }
        }
        ~Base()
        {
            Console.WriteLine("Destroy the Instances of that class.");
        }
    }
    class Derived :Base
    {
        public Derived() :base(10)
        {
            Console.WriteLine("Derived class Called Base class constructor.");
        }
        
    }
    //abstraction
    public abstract class Abstract1
    {
        public abstract void Method3();
        public void Method4()
        {
            Console.WriteLine("Abstract class contains both abstract and non-abstract methods");
        }
    }
    public class Program :Abstract1
    {
        static void Main(string[] args)
        {
            Base a = new Base(1, "Dileep");
            Console.WriteLine(a.details);
            Base b = new Derived();
            Console.WriteLine(b.details);

            Console.ReadKey();
            Ishape i = Factory.GetIshape(1);
            i.Draw();
        }
        void Method2()
        {
            Console.WriteLine("Method2 in derived class");
            
        }
        //Polymorphism
        public override void Method3()
        {
            Console.WriteLine("implementation for abstract class method3 in derived class");
        }
        //Overloading Method
        static void WholeSquare(int a,int b)
        {
            Console.WriteLine($"({a}+{b})^2 = " + ((a + b)*(a + b)));
        }
        static void WholeSquare(double a, double b)
        {
            Console.WriteLine($"{a}^2 + {b}^2 + 2*{a}*{b} = "+(a*a + b*b + 2*a*b));
        }
        private static void SingleTonMethod(SingleTon singleTon)
        {
            singleTon.print("Hello World");
            singleTon.print(5.56D);
            float a = 5f;
            singleTon.print(a);
        }

    }
    //SingleTon
    internal sealed class SingleTon
    {
        private static SingleTon? Instance;
        private SingleTon()
        {
            Console.WriteLine("Instance created only one");
        }
        public static SingleTon GetInstance
        {
            get
            {
                if (Instance == null)
                    Instance = new SingleTon();
                return Instance;
            }
        }
        public void print<T>(T val)
        {
            Console.WriteLine(val);
        }
    }
    //Factory Method
    public interface Ishape
    {
        void Draw();
    }
    class Square : Ishape
    {
        public Square()
        {
            Console.WriteLine("Square is created.");
        }
        public void Draw()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 || j == 0 || i == 4 || j == 4)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    class Triangle : Ishape
    {
        public Triangle()
        {
            Console.WriteLine("Triangle is created.");
        }
        public void Draw()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Circle : Ishape
    {
        public Circle()
        {
            Console.WriteLine("Circle is created.");
        }
        public void Draw()
        {
            Console.WriteLine(" **** ");
            Console.WriteLine("*    *");
            Console.WriteLine("*    *");
            Console.WriteLine("*    *");
            Console.WriteLine(" **** ");
        }
    }
    public class Factory
    {
        public static Ishape GetIshape(int i)
        {
            if (i == 0) return new Square();
            else if (i == 1) return new Circle();
            else if (i == 2) return new Triangle();
            else return null;
        }
    }

}
