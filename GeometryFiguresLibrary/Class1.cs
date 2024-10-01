namespace GeometryFiguresLibrary
{
    class FigureSquare
    {

        public double Square(int[] sides)
        {
            if (sides.Length < 1) return Circle(sides[0]);
            else if (sides.Length == 3) return Triangle(sides[0], sides[1], sides[2]);
            else Console.WriteLine("Error"); return 0;

            // Можно также добавить универсальные методы для любого многоугольникаб квадрата и трапеции и т. д.
        }


        public double Circle(double radius)
        {
            Console.WriteLine("Площадь Круга:"); // Можно создать отдельный метод для вывода этого сообщения, чтобы не дублировать код
            return 2 * Math.PI * radius;
        }

        public double Triangle(double a, double b, double c)
        {
            double p = (a + b + c)/2;
            Console.WriteLine("Площадь треуголника:");
            return Math.Sqrt(p)*(p-a)*(p-b)*(p-c);
        }

        public double Triangle(double height, double ground)
        {
            Console.WriteLine("Площадь треуголника:");
            return (height * ground)/2;
        }
    }
}
