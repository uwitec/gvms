using System;
using System.Collections.Generic;
using System.Text;

namespace MapConfigure.Utilities
{
    class Converter
    {
        public static System.Drawing.Color ConvertIntegerToSystemColor(int color)
        {
            return System.Drawing.ColorTranslator.FromWin32(color);
        }

        public static int ConvertSystemtoIntegerColor(System.Drawing.Color color)
        {
            return System.Drawing.ColorTranslator.ToWin32(color);
        }
    }
}
