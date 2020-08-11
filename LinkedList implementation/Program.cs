using System;

namespace LinkedList_implementation
{
    class Runner
    {
        static void Main(string[] args)
        {
            User Lucas = new User(1, "Lucas");
            User Marcos = new User(2, "Marcos");
            User Pedro = new User(3, "Pedro");

            LinkedList lista = new LinkedList();

            lista.Add(Lucas);
            lista.Add(Pedro);
            lista.Add(Marcos);

            lista.showAll();
        }
    }


}
