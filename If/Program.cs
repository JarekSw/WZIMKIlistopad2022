using System;


namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WielkaWojna.WynikWojny(1, 2, 3, 4); // pokój
            WielkaWojna.WynikWojny(1, 3, 2, 4); // wojna
            WielkaWojna.WynikWojny(1, 4, 2, 3); // piewszy win
            WielkaWojna.WynikWojny(2, 3, 1, 4); // drugi win

            WielkaWojna.WynikWojny(1, 4, 1, 4); // ???
            //WynikWojny(3,5,2,4); // wojna
        }
    }
}
