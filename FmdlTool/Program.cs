﻿using System;
using System.IO;

namespace FmdlTool
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
                using (FileStream stream = new FileStream(args[0], FileMode.Open))
                {
                    Fmdl file = new Fmdl();
                    file.Read(stream);
                    file.OutputSection8Info();
                    stream.Close();
                } //using
            Console.ReadKey();
        } //Main
    } //class
} //namespace
