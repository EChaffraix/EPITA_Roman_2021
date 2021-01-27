using System;
using System.IO;

namespace KataNumber
{
    public class FileAdapter : IOAdapter
    {
        private readonly string _output;
        private string[] _lines;
        private int step = 0;

        public FileAdapter(string input, string output)
        {
            _output = output;
            _lines = File.ReadAllLines(input);
        }


        public string Read()
        {
            if (step < _lines.Length)
            {
                var line = _lines[step];
                step++;
                return line;
            }

            return "STOP";
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}