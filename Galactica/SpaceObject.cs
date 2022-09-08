namespace Galactica
{
    public partial class SpaceObjects
    {


        public int Id { get; set; }
        public string? Name { get; set; }
        public Position? position { get; set; }


        public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }
        public class Position : SpaceObjects
        {
            public Position()
            {
            }

            public Position(int tal1, int tal2)
            {
                Tal1 = tal1;
                Tal2 = tal2;
            }


            public int Tal1 { get; }
            public int Tal2 { get; }
            public double X { get; set; }
            public double Y { get; set; }
            public override string ToString()
            {
                return $"({X}, {Y})";
            }

        }


    }
}
