using System.Reflection.PortableExecutable;

namespace Task5_c_
{
    #region testttt
    //sealed class test
    //{

    //}
    //class test2 : test
    //{

    //}
    #endregion

    #region first Task
    class question
    {
        
        public int Mark { set; get; }
        public string Header { set; get; }
        public int Body { set; get; }
        public virtual void display()
        {
            Console.WriteLine($"Your mark is: {Mark}\n The Header is: {Header}\n The Body is: {Body}");
        }
    }
    class m_c_q:question
    {
       
        public override void display()
        {
            Console.WriteLine("Your mark is: 25\n The Header is: choose the coorect answer\n The Body is: multiple choose Questions");
        }
    }
    class True_false:question
    {
        public override void display()
        {
            Console.WriteLine($"Your mark is: 30\n The Header is: choose the correct answer\n The Body is: True or False questions");
        }
    }
    class complete:question
    {
        public override void display()
        {
            Console.WriteLine($"Your mark is: 45\n The Header is: choose the correct answer\n The Body is: Complete the space Questions");
        }
    }
    #endregion

    #region Second Task
    class parent
    {
       
       public int x { set; get; }
        public parent(int x)
        {
            this.x = x;
        }

        public virtual void display()
        {
            Console.WriteLine($"x: {x}");
        }

    }
     class child:parent
    {
       public  int y { set; get; }
        public child(int x,int y):base(x)
        {
            this.y = y;
        }

        //public new void display()
        //{
        //    Console.WriteLine($"x: {x},y : {y}");
        //    base.display();
        //  //  Console.WriteLine("y: {y}");
        //}
        public override void display()
        {
            Console.WriteLine($"x: {x} y:{y}");
        }
    }
    class subChild:child
    {
        public int z { set; get; }
        public subChild(int x,int y,int z):base(x,y)
        {
            this.z = z;
        }
        public new void display()
        {
            Console.WriteLine($"x: {x}, y:{y} , z: {z}");
            
        }

    }
    #endregion

    #region Third Task
    static class calc
    {
        public static int sum(int x,int y)
        {
            return x + y;
        }
        public static int div(int x,int y)
        {
            return x / y;
        }
        public static int sub(int x,int y)
        {
            return x - y;
        }

    }

    #endregion

    #region Fourth
    class student
    {
        int id;
        int age;
        string name;
       public static int count;
        static student()
        {
            count = 0;
        }

        public student(int id, int age, string name)
        {
            count++;
            this.id = count;
            this.age = age;
            this.name = name;
        }
        public student() { }
        public void display()
        {
            Console.WriteLine($"name: {name}\t age: {age}\t id: {id}");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {

            parent p = new child(4,5);
            p.display();


            calc.sum(10,5);
            calc.div(10,5);
            calc.sub(10,5);


            student s1 = new student(4,25,"ahmed");
            student s2 = new student(4, 25, "Omar");
            student s3 = new student(4, 25, "Ashraf");
            
            s3.display();
         //  Console.WriteLine( student.count);
            
        }
    }
}
