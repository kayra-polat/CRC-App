/// <author>
/// Kayra POLAT
/// </author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRCApp.Crc.Crc32
{
    public class Crc32Model
    {
        #region Private variables

        private uint poly;
        private uint init;
        private bool refIn;
        private bool refOut;
        private uint xorout;

        #endregion

        #region Constructor
        public Crc32Model(uint poly, uint init, bool refIn, bool refOut, uint xorout)
        {
            this.poly = poly;
            this.init = init;
            this.refIn = refIn;
            this.refOut = refOut;
            this.xorout = xorout;
        }
        #endregion

        #region Getters/Setters
        public uint Poly
        {
            get { return poly; }
            set { poly = value; }
        }

        public uint Inıt
        {
            get { return init; }
            set { init = value; }
        }
        public bool RefIn
        {
            get { return refIn; }
            set { refIn = value; }
        }
        public bool RefOut
        {
            get { return refOut; }
            set { refOut = value; }
        }
        public uint _xorOut
        {
            get { return xorout; }
            set { xorout = value; }
        }
        #endregion

    }
}
