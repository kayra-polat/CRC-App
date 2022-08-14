/// <author>
/// Kayra POLAT
/// </author>


namespace CRCApp.Crc.Crc16
{
    public class Crc16
    {
        #region Private Variables
        private ushort[] lookupTable;
        private readonly Crc16Model crc16Model;
        private ushort CRC16Code;
        #endregion

        #region Constructor
        /*
         * @summary Constructor method for create lookpup table and run the different crc-16 algorithm which is chosen by user
         * @params Crc16Model object, input is a byte array, which_algo is int
         */
        public Crc16(Crc16Model crc16Model, byte[] input, int which_algo)
        {
            this.crc16Model = crc16Model;
            InitializeCrcTable();

            // The algorithm which is chosen by user processed here
            CRC16Code = (which_algo == 1 ? Compute_CRC16(input) : ComputeWithLookUpTable(input));
        }
        #endregion

        #region Creating LookUp Table
        /*
         * @summary Calculating Crc-16 Lookup table
         * @params none
         */
        private void InitializeCrcTable()
        {
            lookupTable = new ushort[256];

            for (int divident = 0; divident < 256; divident++)
            {
                var current = (ushort)(divident << 8);
                for (byte bit = 0; bit < 8; bit++)
                {
                    if ((current & 0x8000) != 0) current = (ushort)((current << 1) ^ crc16Model.Poly); // Shift and XOR Operation take places in here
                    else current <<= 1; // Just shift one bit                 
                }
                lookupTable[divident] = current;
            }
        }

        #endregion

        #region Compute CRC-16 Code using LookUp Table
        /*
         * @summary Compute Crc-16 code using lookup table
         * @params name="input"
         * @returns crc
         */
        private ushort ComputeWithLookUpTable(byte[] input)
        {
            ushort crc = crc16Model.Inıt;
            foreach (byte i in input)
            {
                byte cur = (crc16Model.RefIn ? Helper.Reflection_8bit(i) : i); // Ternary Operator make a decision of reflections presence. If reflection true, then reflect 8 bit
                byte index = (byte)((crc ^ (cur << 8)) >> 8);
                crc = (ushort)((crc << 8) ^ (ushort)(lookupTable[index]));
            }
            crc = (crc16Model.RefOut ? Helper.Reflection_16bit(crc) : crc); // Final reflection is to be decided here. 
            crc = (ushort)(crc ^ crc16Model._xorOut); // XOR last crc value with XORout value
            return crc;
        }

        #endregion

        #region Compute CRC-16 Code using orijinal CRC calculation
        /*
         * @summary Compute Crc-16 code using orijinal method
         * @params name="input"
         * @returns crc
         */
        private ushort Compute_CRC16(byte[] input)
        {
            ushort crc = crc16Model.Inıt;

            foreach (byte b in input)
            {
                byte current;
                if (crc16Model.RefIn == true) current = Helper.Reflection_8bit(b);
                else current = b;

                // shift one byte into MSB of CRC
                crc ^= (ushort)(current << 8);

                /* Main for loop:
                 * Take one byte input, if first bit is one the shift one bit and xor with polynomial, 
                 * otherwise shift one bit
                 * */
                for (int i = 0; i < 8; i++)
                {
                    if ((crc & 0x8000) != 0) crc = (ushort)((crc << 1) ^ crc16Model.Poly);
                    else crc <<= 1;
                }
            }

            if (crc16Model.RefOut) crc = Helper.Reflection_16bit(crc); // Final Reflection if it necessary
            crc = (ushort)(crc ^ crc16Model._xorOut); // XOR last crc value with XORout value
            return crc;
        }

        #endregion

        #region Getter/Setter
        public ushort CRC16_Code
        {
            get { return CRC16Code; }
            set { CRC16Code = value; }
        }
        #endregion
    }
}
