using System;

namespace KataNumber
{
    internal class Program
    {
        private readonly IConvert converter;
        private readonly IOAdapter io;

        private Program(IConvert romanToArabic, IOAdapter io)
        {
            converter = romanToArabic;
            this.io = io;
        }

        private static void Main(string[] args)
        {
            var converter = new RomanToArabic();
            var consoleAdapter = new FileAdapter("input.txt", null);

            var program = new Program(converter, consoleAdapter);
            program.Run();
        }

        private void Run()
        {
            while(true)
            {
                var line = io.Read();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    if (string.Equals(line, "STOP", StringComparison.InvariantCultureIgnoreCase)) 
                        return;

                    var result = converter.Convert(line);
                    io.Write(result);
                }
            }
        }
    }
}