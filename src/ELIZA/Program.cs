using ELIZA.NET;
using Reddit;
using Reddit.Controllers.EventArgs;
using Reddit.Things;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ELIZA
{
    class Program
    {
        // Load ELIZA script file and instantiate our libraries.  --Kris
        public static void Main(string[] args)
        {

            if (args.Length < 2)
            {
                Console.WriteLine("Usage: ELIZA <Reddit App ID> <Reddit Refresh Token> [Reddit Access Token]");
            }
            else
            {
                Workflow workflow = new Workflow(args);
                workflow.Run();
            }
        }
    }
}
