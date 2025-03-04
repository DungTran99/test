using System;

// Lớp trừu tượng Vehicle định nghĩa các tính năng chung của phương tiện
abstract class Vehicle
{
    public string Name { get; set; }

    // Phương thức trừu tượng, lớp con phải triển khai
    public abstract void Move();

    // Phương thức không trừu tượng, có thể tái sử dụng
    public void Stop()
    {
        Console.WriteLine($"{Name} đã dừng lại.");
    }
}

// Lớp Car kế thừa từ Vehicle
class Car : Vehicle
{
    public Car(string name)
    {
        Name = name;
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} đang chạy trên đường.");
    }
}

// Lớp Plane kế thừa từ Vehicle
class Plane : Vehicle
{
    public Plane(string name)
    {
        Name = name;
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} đang bay trên trời.");
    }
}

class Program  // Đổi tên từ VehicleProgram thành Program
{
    static void Main(string[] args)
    {
        Vehicle myCar = new Car("Toyota");
        Vehicle myPlane = new Plane("Boeing");

        myCar.Move();   // Output: Toyota đang chạy trên đường.
        myCar.Stop();   // Output: Toyota đã dừng lại.
        myPlane.Move(); // Output: Boeing đang bay trên trời.
        myPlane.Stop(); // Output: Boeing đã dừng lại.
    }
}