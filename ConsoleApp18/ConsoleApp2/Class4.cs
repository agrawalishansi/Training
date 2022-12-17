using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Class4
    {
        public static void Main(string[] args)
        {
            string[] files = { "171fa.txt", "171af.pdf",
                                "171faa.xml" , "171aaf.txt",
                                "171faaa.txt", "171aaaf.xml"};
            var result = files.Select(f => Path.GetExtension(f)
                                        .TrimStart('.').ToLower())
                                      .GroupBy(y => y, (ex, excnt) => new
                                      {
                                          Extension = ex,
                                          Count = excnt.Count()
                                      });
            foreach (var i in result)
            {
                Console.WriteLine(i.Count + "file -->" +
                                    i.Extension + " format ");
            }
        }
    }
}
