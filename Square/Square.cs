namespace Square
{
    public static class Square
    {
        public static double Circle(double Radius) => Radius * 2 * 3.14;

        public static double Triangle(double side1, double side2, double side3)
        {
            double p = (side1 + side2 + side3) / 2;//Полупериметр
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public static bool Rectangular(double side1, double side2, double side3) //Проверка на прямоугольный треугольник
        {
            if(side1 * side1 == side2 * side2 + side3 * side3 || 
                side2 * side2 == side1 * side1 + side3 * side3 || 
                side3 * side3 == side2 * side2 + side1 * side1)
                return true;
            else
                return false;
        }
    }
}