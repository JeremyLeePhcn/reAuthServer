using System;
using System.Collections.Generic;
using System.IO;
using ReAuthServer.Models;
using ReAuthServer.Utils;

namespace ReAuthServer.Services
{

    public class ReAuthService
    {
        public const String DEST = "../../hello_world.pdf";
        Utils.CreatePDF createPDF = new CreatePDF();
    
        
        public void sayHello(String name) 
        {
             FileInfo file = new FileInfo(DEST);
            file.Directory.Create();
            createPDF.helloPDF(DEST, name);
            Console.Write("Hello " + name);
        }
    }
}
