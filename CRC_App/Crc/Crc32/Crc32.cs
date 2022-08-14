/// <author>
/// Kayra POLAT
/// </author>

namespace CRCApp.Crc.Crc32
{
    public class Crc32
    {
        #region Private Variables
        private uint[] lookupTable;
        private readonly Crc32Model crc32Model;
        private uint CRC32Code;
        #endregion

        #region Constructor
        /*
         * @summary Constructor method for create lookpup table and run the different crc-32 algorithm which is chosen by user
         * @params Crc32Model object, input is a byte array, which_algo is int
         */
        public Crc32(Crc32Model crc32Model, byte[] input, int which_algo)
        {
            this.crc32Model = crc32Model;
            InitializeCrcTable();

            // The algorithm which is chosen by user processed here
            CRC32Code = (which_algo == 1 ? Compute_CRC32(input) : ComputeWithLookUpTable(input));
        }
        #endregion

        #region Compute CRC-32 Code using orijinal CRC calculation
        /*
         * @summary Compute Crc-32 code using orijinal method
         * @params name="input"
         * @returns crc
         */
        private uint Compute_CRC32(byte[] input)
        {
            uint crc = crc32Model.Inıt;

            foreach (byte b in input)
            {
                byte current;
                if (crc32Model.RefIn == true) current = Helper.Reflection_8bit(b);
                else current = b;

                // shift 24 bit into MSB of 32bit CRC
                crc ^= (uint)(current << 24);

                /* Main for loop:
                * Take one byte input, if first bit is one the shift one bit and xor with polynomial, 
                * otherwise shift one bit
                * */
                for (int i = 0; i < 8; i++)
                {
                    if ((crc & 0x80000000) != 0) crc = (uint)((crc << 1) ^ crc32Model.Poly);
                    else crc <<= 1;
                }
            }

            if (crc32Model.RefOut == true) crc = Helper.Reflection_32bit(crc); // Final Reflection if it necessary
            crc = (uint)(crc ^ crc32Model._xorOut); // XOR last crc value with XORout value
            return crc;
        }
        #endregion

        #region Creating LookUp Table
        /*
         * @summary Calculating Crc-32 Lookup table
         * @params none
         */
        private void InitializeCrcTable()
        {
            lookupTable = new uint[256];

            for (int divident = 0; divident < 256; divident++)
            {
                var currentB = (uint)(divident << 24);
                for (byte bit = 0; bit < 8; bit++)
                {
                    if ((currentB & 0x80000000) != 0) currentB = (uint)((currentB << 1) ^ crc32Model.Poly); // Shift and XOR Operation take places in here
                    else currentB <<= 1; // Just shift one bit   
                }
                lookupTable[divident] = currentB;
            }
        }
        #endregion

        #region Compute CRC-32 Code using LookUp Table
        /*
         * @summary Compute Crc-32 code using lookup table
         * @params name="input"
         * @returns crc
         */
        private uint ComputeWithLookUpTable(byte[] input)
        {
            uint crc = crc32Model.Inıt;
            foreach (byte i in input)
            {
                byte cur = (crc32Model.RefIn ? Helper.Reflection_8bit(i) : i); // Ternary Operator make a decision of reflections presence. If reflection true, then reflect 8 bit.
                byte index = (byte)((crc ^ (cur << 24)) >> 24);
                crc = (uint)((crc << 8) ^ (uint)(lookupTable[index]));
            }
            crc = (crc32Model.RefOut ? Helper.Reflection_32bit(crc) : crc); // Final reflection is to be decided here.
            crc = (uint)(crc ^ crc32Model._xorOut); // XOR last crc value with XORout value
            return crc;
        }
        #endregion

        #region Getter/Setter
        public uint CRC32_Code
        {
            get { return CRC32Code; }
            set { CRC32Code = value; }
        }
        #endregion
    }
}
