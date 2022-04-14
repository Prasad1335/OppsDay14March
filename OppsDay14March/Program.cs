
//Count object 
//class to class inherites

//A a = new A();
////a.DisplayB();
////a.Display();
//Console.WriteLine("Total objects = " +A.TotalCount());
//A aa = new B();
////aa.DisplayB(); //not accessible in child class method in parent object
////aa.Display();



//class A
//{
//   public  static int count = 0;
//    protected void Display()
//    {
//        Console.WriteLine("display A");
//    }
//    public A()
//    {
//        count++;
//    }

//public static int TotalCount()
//    {
//        return count;
//    }
//}
//class B : A
//{
//    public void DisplayB()
//    {
//        Console.WriteLine("display B");
//        Display();
//    }
//}
//------------------------------------     static class  ----------------------------------------------

//rule: . static class madhe static varible and method pahije

//Math.Add(1, 2); //ans
//Console.WriteLine(Math.Add(1, 2));

//class Math 
//{
//    public static int Add(int x, int y)
//    {
//        return x + y;
//    }

//    public static int Mul(int x, int y)
//    {
//        return x * y;
//    }

//    public static int Sub(int x, int y)
//    {
//        return x - y;
//    }
//}

//------------------------------------    call by refrence / call by value    ----------------------------------------------

//call by refrence  display scope value 50
//void myFun(ref int a)
//{
//    a = 50;
//}
//int a = 20;
//myFun(ref a);
//Console.WriteLine(a);


////call by value  display out of scope value 20
//void myFun1(int b)
//{
//    b = 50;
//}
//int b = 20;
//myFun1(b);
//Console.WriteLine(b);

//========================================== Getter / Setter (get:set) ========================================================
//geter setter part od encapsulation

//Student s = new Student();
//s.NameInf = "prasad";
//Console.WriteLine(s.NameInf);

//class Student
//{
//    int ID;
//    string Name;
//    public string NameInf
//    {
//        get
//        {
//            return Name;
//        }
//        set
//        {
//            this.Name = value;
//        }

//    }
//}
//----------------------------------------  get:set value example -------------------------------------------------------------------------

//Account account = new Account(112233, "prasad", 5000, "saving");
//account.Display();
//account.NameSet = "raj";
//account.Display();


//class Account
//{
//    private int AcNo;
//    private string Name;
//    private int Bal;
//    private string Act;


//    public string NameSet
//    {
//        get { return Name; }
//        set { Name = value; }
//    }
//    public int BalNo
//    {
//        get { return Bal; }
//        set { BalNo = value; }
//    }
//    public Account(int AcNo, string Name, int Bal, string Act)
//    {
//        this.AcNo = AcNo;
//        this.Name = Name;
//        this.Bal = Bal;
//        this.Act = Act;
//    }

//    public void Display()
//    {
//        Console.WriteLine($"{AcNo}, {Name} ,{Bal} ,{Act}");
//    }


//}
//===================================== single  inhetitance ====================================================================
//---------------------------- parent to child interice and using base class --------------------------------------------

//Parent p = new Parent("Popatrao", "Deshmkuh");
//p.Display();

//Child c = new Child("Prasad", "Popatrao", "Deshmkuh");
//c.Display1();

//class Parent
//{
//    protected string MName; //protected  access only child class
//    protected string LName;

//    public Parent(string MName,string LName)
//    {
//        this.MName = MName;
//        this.LName = LName;
//    }

//    public void Display()
//    {
//        Console.WriteLine($"{MName} {LName}");
//    }
//}


//class Child : Parent
//{
//    private string FName;


//    public Child(string FName, string MName, string LName) :base(MName,LName)
//    {
//        this.FName = FName;

//    }

//    public void Display1()
//    {
//        Console.WriteLine($"{FName}, {MName} ,{LName}");
//    }
//}

//==================== multi level inheritance ================================
//Dog dog = new();
//dog.walk();
//dog.bark();
//dog.eat();


//Animal a = new Animal();
//a.eat();


//Dog d=new Dog();
//d.eat();
//d.bark();

//Cat c = new Cat();
//c.eat();
//c.bark();
//c.meu();


//class Animal
//{
//    public void eat()
//    {
//        Console.WriteLine("eating");
//    }

//}

//class Dog:Animal
//{
//    public void bark()
//    {
//        Console.WriteLine("bHO bho.....s");
//    }

//    public void walk()
//    {
//        Console.WriteLine("normal");
//    }

//}

//class Cat : Dog
//{
//    public void meu()
//    {
//        Console.WriteLine("meu meu..");
//    }
//}

// ================================  RelationShip   ===============================================
//Address add = new Address("pathardi", "ngr");
//Student s = new Student("Prasad", add);


//Student s1 = new Student("sonali", add);
//Address add2 = new Address("newasa", "ngr");

//Student s3 = new Student("raj", add2);
//s.Display();
//s1.Display();
//s3.Display();


//class Student
//{
//    string Name;
//    public Address address;

//    public Student(string name, Address add)
//    {
//        Name = name;
//        address = add;
//    }
//    public void Display()
//    {
//        Console.WriteLine($"{Name},{address.city},{address.distance}");
//    }
//}

//class Address
//{
//    public string city;
//    public string distance;

//    public Address(string city,string distance)
//    {
//        this.city = city;
//        this.distance = distance;
//    }
//}

// ================================= encapsulation ====================================================
// binding data with function 
//two type of encapsulation : 1) overloading 2) overloading 


//A a = new A();
//a.Show();
//a.Show(5,6);
//a.Show(5.7f);
//a.Show(5,6.7f);
//a.Show(5);

//class A
//{
//    public void Show()
//    {
//        Console.WriteLine("showing");
//    }

//    public void Show(int a)
//    {
//        Console.WriteLine("Showing "+a);
//    }

//    public void Show(float a)
//    {
//        Console.WriteLine("Showing " + a);
//    }


//    public void Show(int a,int b)
//    {
//        Console.WriteLine("int a, int b");
//    }

//    public void Show(int a,float b)
//    {
//        Console.WriteLine("int a,float b");
//    }
//}
//------------------------------- override ----------------------------------------------

//inheritance asel trach overring hoel
// overrinng madhe virtual and overrride keyword use karave lagtat


//Animal a = new Animal();
//a.eat();

//Animal aa = new Dog();
//aa.eat();

//Animal aaa = new Cow();
//aaa.eat();

//class Animal
//{
//  public virtual void eat()
//    {
//        Console.WriteLine("eating type");
//    }
//}

//class Dog : Animal
//{
//    public override void eat()
//    {
//        Console.WriteLine("sssss");

//    }
//}

//class Cow : Animal
//{
//    public override void eat()
//    {
//        Console.WriteLine("rrrrrr");

//    }
//}
//====================================== Abstraction ==============================================
//only show funtionality  dont show details


/*abstract method declreation ex.public abstract void Sound();*
*abstract method access only child class using override keyword*/

//Animal a = new Dog();
//a.Sound();


//Animal b =new Cow();
//b.Sound();

//abstract class Animal
//{
//    public abstract void Sound();

//    public void Show()
//    {
//        Console.WriteLine("abstract showing");
//    }
//}

//class Dog : Animal
//{
//    public override void Sound()
//    {
//        Console.WriteLine("bhobho");
//    }

//    public  void Eat()
//    {
//        Console.WriteLine("dog ssss");
//    }
//}

//class Cow : Animal
//{
//    public override void Sound()
//    {
//        Console.WriteLine("cow aaaaa");
//    }

//    void Eat()
//    {
//        Console.WriteLine("cow eating ");
//    }
//}

//---------------------------------------- interface --------------------------------------
Dog d=new Dog();
d.Sound();
d.Behevior();

Cat c = new Cat();
c.Sound();
c.Behevior();



public interface IAnimal
{
    public void Sound();
    public void Behevior();
}


public class Dog : IAnimal
{
    public void Behevior()
    {
        Console.WriteLine("aaaaa dog");
    }
    public void Sound()
    {
        Console.WriteLine("bhobho dog");

    }
}

public class Cat : IAnimal
{
    public void Behevior()
    {
        Console.WriteLine("sdwqfq cat");
    }

    public void Sound()
    {
        Console.WriteLine("meu meu cat");
    }
}


public class Cow : IAnimal
{
    public void Behevior()
    {
        Console.WriteLine("ddddd cow");
    }

    public void Sound()
    {
        Console.WriteLine("hhhmmm cow");
    }
}
