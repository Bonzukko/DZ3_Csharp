Console.Write("Введите координату х точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки A: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату х точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.Write("A("+xA+","+yA+","+zA+"); B("+xB+","+yB+","+zB+") -> ");
Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((xB-xA),2)+Math.Pow((yB-yA),2)+Math.Pow((zB-zA),2)),2));