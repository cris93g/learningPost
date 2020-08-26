using System;

namespace advoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("thanks for the sub",true,"cristian");
            Post post2 = new Post("thanks", true, "cri");
            Console.WriteLine(post2.ToString());
            ImagePost imagePost1 = new ImagePost("check out my new shoes","cristian","http://imgurl.com/shoe",true);
            Console.WriteLine(imagePost1.ToString());
        }
    }
}
