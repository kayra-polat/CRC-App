/// <author>
/// Kayra POLAT
/// </author>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRCApp.Crc.Crc32
{
    public class Crc32Types
    {
        #region Private Variables
        private Dictionary<string, Crc32Model> CRC32_Versions = new Dictionary<string, Crc32Model>();
        private static Crc32Model CRC32 = new Crc32Model(0x04C11DB7, 0xffffffff, true, true, 0xffffffff);
        private static Crc32Model CRC32_Q = new Crc32Model(0x814141ab, 0x00000000, false, false, 0x00000000);
        private static Crc32Model CRC32_AUTOSAR = new Crc32Model(0xf4acfb13, 0xffffffff, true, true, 0xffffffff);
        private static Crc32Model CRC32_D = new Crc32Model(0xa833982b, 0xffffffff, true, true, 0xffffffff);
        private static Crc32Model CRC32_BZIP2 = new Crc32Model(0x04c11db7, 0xffffffff, false, false, 0xffffffff);
        private static Crc32Model CRC32_CD_ROM_EDC = new Crc32Model(0x8001801b, 0x00000000, true, true, 0x00000000);
        private static Crc32Model CRC32_POSIX = new Crc32Model(0x04c11db7, 0x00000000, false, false, 0xffffffff);
        private static Crc32Model CRC32_C = new Crc32Model(0x1edc6f41, 0xffffffff, true, true, 0xffffffff);
        private static Crc32Model CRC32_JAMCRC = new Crc32Model(0x04c11db7, 0xffffffff, true, true, 0x00000000);
        private static Crc32Model CRC32_MEF = new Crc32Model(0x741b8cd7, 0xffffffff, true, true, 0x00000000);
        private static Crc32Model CRC32_MPEG_2 = new Crc32Model(0x04c11db7, 0xffffffff, false, false, 0x00000000);
        private static Crc32Model CRC32_XFER = new Crc32Model(0x000000af, 0x00000000, false, false, 0x00000000);
        #endregion

        #region Constructor
        public Crc32Types()
        {
            CRC32_Versions.Add("CRC-32", CRC32);
            CRC32_Versions.Add("CRC-32/Q", CRC32_Q);
            CRC32_Versions.Add("CRC-32/AUTOSAR", CRC32_AUTOSAR);
            CRC32_Versions.Add("CRC-32/D", CRC32_D);
            CRC32_Versions.Add("CRC-32/BZIP2", CRC32_BZIP2);
            CRC32_Versions.Add("CRC-32/CD-ROM-EDC", CRC32_CD_ROM_EDC);
            CRC32_Versions.Add("CRC-32/POSIX", CRC32_POSIX);
            CRC32_Versions.Add("CRC-32/C", CRC32_C);
            CRC32_Versions.Add("CRC-32/JAMCRC", CRC32_JAMCRC);
            CRC32_Versions.Add("CRC-32/MEF", CRC32_MEF);
            CRC32_Versions.Add("CRC-32/MPEG-2", CRC32_MPEG_2);
            CRC32_Versions.Add("CRC-32/XFER", CRC32_XFER);
        }
        #endregion

        #region Getter/Setter
        public Dictionary<string, Crc32Model> CRC32Versions
        {
            get { return CRC32_Versions; }
            set { CRC32_Versions = value; }
        }
        #endregion
    }
}
