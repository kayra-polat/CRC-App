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
    public class Crc16Types
    {
        #region Private Variables

        private Dictionary<string, Crc16Model> CRC16_Versions = new Dictionary<string, Crc16Model>();
        private static Crc16Model CRC16_ARC = new Crc16Model(0x8005, 0x0000, true, true, 0x0000);
        private static Crc16Model CRC16_CDMA2000 = new Crc16Model(0xc867, 0xffff, false, false, 0x0000);
        private static Crc16Model CRC16_CMS = new Crc16Model(0x8005, 0xffff, false, false, 0x0000);
        private static Crc16Model CRC16_DDS_110 = new Crc16Model(0x8005, 0x800d, false, false, 0x0000);
        private static Crc16Model CRC16_DECT_R = new Crc16Model(0x0589, 0x0000, false, false, 0x0001);
        private static Crc16Model CRC16_DECT_X = new Crc16Model(0x0589, 0x0000, false, false, 0x0000);
        private static Crc16Model CRC16_DNP = new Crc16Model(0x3d65, 0x0000, true, true, 0xffff);
        private static Crc16Model CRC16_EN_13757 = new Crc16Model(0x3d65, 0x0000, false, false, 0xffff);
        private static Crc16Model CRC16_GENIBUS = new Crc16Model(0x1021, 0xffff, false, false, 0xffff);
        private static Crc16Model CRC16_GSM = new Crc16Model(0x1021, 0x0000, false, false, 0xffff);
        private static Crc16Model CRC16_IBM_3740 = new Crc16Model(0x1021, 0xffff, false, false, 0x0000);
        private static Crc16Model CRC16_IBM_SDLC = new Crc16Model(0x1021, 0xffff, true, true, 0xffff);
        private static Crc16Model CRC16_ISO_IEC_14443_3_A = new Crc16Model(0x1021, 0xc6c6, true, true, 0x0000);
        private static Crc16Model CRC16_KERMIT = new Crc16Model(0x1021, 0x0000, true, true, 0x0000);
        private static Crc16Model CRC16_LJ1200 = new Crc16Model(0x6f63, 0x0000, false, false, 0x0000);
        private static Crc16Model CRC16_M17 = new Crc16Model(0x5935, 0xffff, false, false, 0x0000);
        private static Crc16Model CRC16_MAXIM_DOW = new Crc16Model(0x8005, 0x0000, true, true, 0xffff);
        private static Crc16Model CRC16_MCRF4XX = new Crc16Model(0x1021, 0xffff, true, true, 0x0000);
        private static Crc16Model CRC16_MODBUS = new Crc16Model(0x8005, 0xffff, true, true, 0x0000);
        private static Crc16Model CRC16_NRSC_5 = new Crc16Model(0x080b, 0xffff, true, true, 0x0000);
        private static Crc16Model CRC16_OPENSAFETY_A = new Crc16Model(0x5935, 0x0000, false, false, 0x0000);
        private static Crc16Model CRC16_OPENSAFETY_B = new Crc16Model(0x755b, 0x0000, false, false, 0x0000);
        private static Crc16Model CRC16_PROFIBUS = new Crc16Model(0x1dcf, 0xffff, false, false, 0xffff);
        private static Crc16Model CRC16_RIELLO = new Crc16Model(0x1021, 0xb2aa, true, true, 0x0000);
        private static Crc16Model CRC16_SPI_FUJITSU = new Crc16Model(0x1021, 0x1d0f, false, false, 0x0000);
        private static Crc16Model CRC16_T10_DIF = new Crc16Model(0x8bb7, 0x0000, false, false, 0x0000);
        private static Crc16Model CRC16_TELEDISK = new Crc16Model(0xa097, 0x0000, false, false, 0x0000);
        private static Crc16Model CRC16_TMS37157 = new Crc16Model(0x1021, 0x89ec, true, true, 0x0000);
        private static Crc16Model CRC16_UMTS = new Crc16Model(0x8005, 0x0000, false, false, 0x0000);
        private static Crc16Model CRC16_USB = new Crc16Model(0x8005, 0xffff, true, true, 0xffff);
        private static Crc16Model CRC16_XMODEM = new Crc16Model(0x1021, 0x0000, false, false, 0x0000);

        #endregion

        #region Constructor
        public Crc16Types()
        {
            CRC16_Versions.Add("CRC-16/ARC", CRC16_ARC);
            CRC16_Versions.Add("CRC-16/CDMA2000", CRC16_CDMA2000);
            CRC16_Versions.Add("CRC-16/CMS", CRC16_CMS);
            CRC16_Versions.Add("CRC-16/DDS-110", CRC16_DDS_110);
            CRC16_Versions.Add("CRC-16/DECT-R", CRC16_DECT_R);
            CRC16_Versions.Add("CRC-16/DECT-X", CRC16_DECT_X);
            CRC16_Versions.Add("CRC-16/DNP", CRC16_DNP);
            CRC16_Versions.Add("CRC-16/EN-13757", CRC16_EN_13757);
            CRC16_Versions.Add("CRC-16/GENIBUS", CRC16_GENIBUS);
            CRC16_Versions.Add("CRC-16/GSM", CRC16_GSM);
            CRC16_Versions.Add("CRC-16/IBM-3740", CRC16_IBM_3740);
            CRC16_Versions.Add("CRC-16/IBM-SDLC", CRC16_IBM_SDLC);
            CRC16_Versions.Add("CRC-16/ISO-IEC-14443-3-A", CRC16_ISO_IEC_14443_3_A);
            CRC16_Versions.Add("CRC-16/KERMIT", CRC16_KERMIT);
            CRC16_Versions.Add("CRC-16/LJ1200", CRC16_LJ1200);
            CRC16_Versions.Add("CRC-16/M17", CRC16_M17);
            CRC16_Versions.Add("CRC-16/MAXIM-DOW", CRC16_MAXIM_DOW);
            CRC16_Versions.Add("CRC-16/MCRF4XX", CRC16_MCRF4XX);
            CRC16_Versions.Add("CRC-16/MODBUS", CRC16_MODBUS);
            CRC16_Versions.Add("CRC-16/NRSC-5", CRC16_NRSC_5);
            CRC16_Versions.Add("CRC-16/OPENSAFETY-A", CRC16_OPENSAFETY_A);
            CRC16_Versions.Add("CRC-16/OPENSAFETY-B", CRC16_OPENSAFETY_B);
            CRC16_Versions.Add("CRC-16/PROFIBUS", CRC16_PROFIBUS);
            CRC16_Versions.Add("CRC-16/RIELLO", CRC16_RIELLO);
            CRC16_Versions.Add("CRC-16/SPI-FUJITSU", CRC16_SPI_FUJITSU);
            CRC16_Versions.Add("CRC-16/T10-DIF", CRC16_T10_DIF);
            CRC16_Versions.Add("CRC-16/TELEDISK", CRC16_TELEDISK);
            CRC16_Versions.Add("CRC-16/TMS37157", CRC16_TMS37157);
            CRC16_Versions.Add("CRC-16/UMTS", CRC16_UMTS);
            CRC16_Versions.Add("CRC-16/USB", CRC16_USB);
            CRC16_Versions.Add("CRC-16/XMODEM", CRC16_XMODEM);
        }
        #endregion

        #region Getter/Setter
        public Dictionary<string, Crc16Model> CRC16Versions
        {
            get { return CRC16_Versions; }
            set { CRC16_Versions = value; }
        }
        #endregion
    }

}
