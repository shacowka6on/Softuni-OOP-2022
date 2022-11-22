using System;

namespace AuthorProblem
{
    [Author("Victor")]
    class StartUp
    {
        [Author("George")]
        static void Main()
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}
