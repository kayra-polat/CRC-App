/// <author>
/// Kayra POLAT
/// </author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRCApp
{
    public class Helper
    {
        #region String to Byte Array Converter Method
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        #endregion

        #region Ascii to Hex Converter Method
        public static string asciiToHex(string ascii)
        {
            char[] chars = ascii.ToCharArray();
            string hex = "";

            foreach (char c in chars)
            {
                int value = Convert.ToInt32(c);
                hex += String.Format("{0:X}", value);
            }

            return hex;
        }
        #endregion

        #region 8-Bit Reflection Method
        public static byte Reflection_8bit(byte input)
        {
            byte reflected = 0;

            for (int i = 0; i < 8; i++) if ((input & (1 << i)) != 0) reflected |= (byte)(1 << (7 - i));

            return reflected;
        }
        #endregion

        #region 16-Bit Reflection Method
        public static ushort Reflection_16bit(ushort input)
        {
            ushort reflected = 0;

            for (int i = 0; i < 16; i++) if ((input & (1 << i)) != 0) reflected |= (ushort)(1 << (15 - i));

            return reflected;
        }
        #endregion

        #region 32-Bit Reflection Method
        public static uint Reflection_32bit(uint value)
        {
            uint reflected = 0;

            for (int i = 0; i < 32; i++) if ((value & (1 << i)) != 0) reflected |= (uint)(1 << (31 - i));

            return reflected;
        }
        #endregion
    }
}
