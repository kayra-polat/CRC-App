/// <author>
/// Kayra POLAT
/// </author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRCApp.Crc.Crc16
{
    public class Crc16Model
    {
        #region Private Variables

        private ushort poly;
        private ushort init;
        private bool refIn;
        private bool refOut;
        private ushort xorout;

        #endregion

        #region Constructor
        public Crc16Model(ushort poly, ushort init, bool refIn, bool refOut, ushort xorout)
        {
            this.poly = poly;
            this.init = init;
            this.refIn = refIn;
            this.refOut = refOut;
            this.xorout = xorout;
        }
        #endregion

        #region Getters/Setters
        public ushort Poly
        {
            get { return poly; }
            set { poly = value; }
        }

        public ushort Inıt
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
        public ushort _xorOut
        {
            get { return xorout; }
            set { xorout = value; }
        }

        #endregion
    }
}
