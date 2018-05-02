using System;
using kz.tsnproff.Orix4.model;

namespace kz.tsnproff.Orix4.utils.impl
{
    class ConsoleOutput : IOutput
    {
        ConsoleColor[] _COLORS = { ConsoleColor.White, ConsoleColor.Green, 
                                     ConsoleColor.Yellow, ConsoleColor.Cyan,
                                     ConsoleColor.Red, ConsoleColor.DarkMagenta};

        public void println(string text)
        {
            Console.WriteLine(text);
        }

        private ConsoleColor defineColor(Const.EElementType elementType)
        {
            switch (elementType)
            {
                case Const.EElementType.Default: return _COLORS[0];
                case Const.EElementType.Today: return _COLORS[1];
                case Const.EElementType.After: return _COLORS[2];
                case Const.EElementType.Occurred: return _COLORS[3];
                case Const.EElementType.CompletedTask: return _COLORS[5];
                case Const.EElementType.Task: return _COLORS[4];
                default: return _COLORS[0];
            }
        }

        public void println(string text, Const.EElementType elementType)
        {
            Console.ForegroundColor = defineColor(elementType);
            Console.WriteLine(text);
        }

    }
}
