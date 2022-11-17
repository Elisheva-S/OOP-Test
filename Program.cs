// See https://aka.ms/new-console-template for more information
using static Truck;

Console.WriteLine("Hello, World!");
//answer 6:
public abstract class Shape
{
    public abstract int Area(int length, int width);
    public abstract int Scope(int length, int width);
}
public class Rectangle : Shape
{
    public override int Area(int length, int width)
    {
        return length * width;
    }

    public override int Scope(int length, int width)
    {
        return (length * 2 ) + (width * 2 );
    }
}
//answer 7:
public interface ICar
{
    public int MaxSpeed();
    public int Seats();
}
public class Truck : ICar
{
    public int MaxSpeed()
    {
        return 200;    
    }

    public int Seats()
    {
        return 3;
    }
    public string Ability()
    {
        return "Can help with moving to a new apartment";
    }
    public void GetICar(ICar car)
    {
        car.Seats();
    }
    public void Implements()
    {
        ICar car = new Truck();
        car.MaxSpeed();
        car.Seats();
        //car.Ability(); -- it's can't access to this method.
        Truck truck = new Truck();
        truck.GetICar(truck);
    }
 //answer 8:
    public class MyClass
    {
        public int MyFunc(int a)
        {
            return a + a;
        }
        public int MyFunc()
        {
            return 5;
        }
        public int MyFunc(string a)
        {
            if (!string.IsNullOrEmpty(a))
            {
                if (a == "nine")
                {
                    return 9;
                }
                else if (a == "three")
                {
                    return 3;
                }
            }
            return 0;
        }
        public void Using()
        {
            MyClass myClass = new MyClass();
            int result;
            result= myClass.MyFunc();
            //result is equal to 5;
            result = myClass.MyFunc(4);
            //result is equal to 8;
            result = myClass.MyFunc("nine");
            //result is equal to 9;
        }
    }
    //answer 9:
    public abstract class Shape
    {
        public abstract int Area(int length, int width);
        public abstract int Scope(int length, int width);
    }
    public class Rectangle : Shape
    {
        public override int Area(int length, int width)
        {
            return length * width;
        }

        public override int Scope(int length, int width)
        {
            return (length * 2) + (width * 2);
        }
    }
    public class Square : Shape
    {
        public override int Area(int length, int width)
        {
            return length * length;
        }

        public override int Scope(int length, int width)
        {
            return length * 4;
        }
    }
    //answer 10:
    
    public class MyFactory
    {
        private Shape myShape;

        public void Building(Shape shape)
        {
            shape.Scope(5,5);
            shape.Area(5,5);
            //build the building...
        }
        public void FactoryTheShape()
        {
            string? shape=Console.ReadLine();
            if (shape=="rectangle")
            {
                 myShape = new Rectangle();
            }
            else if (shape == "square")
            {
                 myShape = new Square();
            }
            Building(myShape);
        }
    }
    //הסבר:
    //כהמשך לתשובה הקודמת (9)- יצרתי פונקציה שיוצרת מבנה מצורה שקיבלה
    //( shape מקבלת כפרמטר),
    //ויחד עם המחלקות המממשות את צורה (מלבן וריבוע) יצרתי פונציית
    //(FactoryTheShape)
    //שהיא אחראית לטפל בכל מה שקשור למחלקות המממשות, במקרה זה היא אחראית ליצור אוביקט חדש לפי קלט שהמשתמש הכניס
    //השימוש בה מאפשר בצורה מסודרת להוסיף מחלקות מממשות וכו' כי היא מעין ה"כיסוי" של המחלקות המממשות, ברעיון של הסתרת נתונים.
}
