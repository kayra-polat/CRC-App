/// <author>
/// Kayra POLAT
/// </author>

using CRCApp.Crc.Crc16;
using CRCApp.Crc.Crc32;
using CRCApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRC_App
{
    public partial class Form1 : Form
    {
        #region Private Variables
        private Dictionary<string, uint> CRCKeyValuePairs = new Dictionary<string, uint>(); // A Dictonary to store CRC version names and it's CRC codes
        private int algo = 0; // A flag value which help to choose which algoritm is going to use for CRC caluculation
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region Crc-16 Button
        private void btn_crc16_Click(object sender, EventArgs e)
        {
            output_box.Items.Clear();
            CRCKeyValuePairs.Clear();

            if (string.IsNullOrEmpty(msg_box.Text))
            {
                MessageBox.Show("Please write your message!");
                return;
            }
            else
            {
                string input = msg_box.Text.Trim();
                input = input.Replace(" ", String.Empty);

                if (comboBox_inpver.SelectedItem == null)
                {
                    MessageBox.Show("Please choose an input version! (ASCII or HEX)");
                    return;
                }

                string selectedItem = comboBox_inpver.Items[comboBox_inpver.SelectedIndex].ToString();

                input = (selectedItem.Equals("ASCII") ? Helper.asciiToHex(input) : input);

                byte[] input_array = Helper.StringToByteArray(input);

                if (radiobtn_SimpleCrc.Checked) algo = 1;
                else if (radiobtn_LookupTable.Checked) algo = 2;
                else
                {
                    MessageBox.Show("Please choose an algorithm!");
                    return;
                }

                CRCKeyValuePairs = storeCRC16s(input_array, algo, CRCKeyValuePairs);

                foreach (KeyValuePair<string, uint> pair in CRCKeyValuePairs)
                {
                    string hex = pair.Value.ToString("X");
                    string hexVal = "0x" + hex;
                    output_box.Items.Add(pair.Key + ": " + hexVal);
                }

            }

        }
        #endregion

        #region CRC-32 Button
        private void btn_crc32_Click_1(object sender, EventArgs e)
        {
            output_box.Items.Clear();
            CRCKeyValuePairs.Clear();

            if (string.IsNullOrEmpty(msg_box.Text))
            {
                MessageBox.Show("Please write your message!");
                return;
            }
            else
            {
                string input = msg_box.Text.Trim();
                input = input.Replace(" ", String.Empty);

                if (comboBox_inpver.SelectedItem == null)
                {
                    MessageBox.Show("Please choose an input version! (ASCII or HEX)");
                    return;
                }

                string selectedItem = comboBox_inpver.Items[comboBox_inpver.SelectedIndex].ToString();

                input = (selectedItem.Equals("ASCII") ? Helper.asciiToHex(input) : input);

                byte[] input_array = Helper.StringToByteArray(input);

                if (radiobtn_SimpleCrc.Checked) algo = 1;
                else if (radiobtn_LookupTable.Checked) algo = 2;
                else
                {
                    MessageBox.Show("Please choose an algorithm!");
                    return;
                }

                CRCKeyValuePairs = storeCRC32s(input_array, algo, CRCKeyValuePairs);

                foreach (KeyValuePair<string, uint> pair in CRCKeyValuePairs)
                {
                    string hex = pair.Value.ToString("X");
                    string hexVal = "0x" + hex;
                    output_box.Items.Add(pair.Key + ": " + hexVal);
                }

            }
        }
        #endregion

        #region Add Crc-16 codes to the List
        private Dictionary<string, uint> storeCRC16s(byte[] inp, int algo, Dictionary<string, uint> CRC_list)
        {
            Crc16Types crc16Types = new Crc16Types();

            foreach (KeyValuePair<string, Crc16Model> v in crc16Types.CRC16Versions)
            {
                Crc16 crc16 = new Crc16(v.Value, inp, algo);
                CRC_list.Add(v.Key, crc16.CRC16_Code);
            }

            return CRC_list;
        }
        #endregion

        #region Add Crc-32 codes to the list
        private Dictionary<string, uint> storeCRC32s(byte[] inp, int algo, Dictionary<string, uint> CRC_list)
        {
            Crc32Types crc32Types = new Crc32Types();

            foreach (KeyValuePair<string, Crc32Model> v in crc32Types.CRC32Versions)
            {
                Crc32 crc32 = new Crc32(v.Value, inp, algo);
                CRC_list.Add(v.Key, crc32.CRC32_Code);
            }

            return CRC_list;
        }
        #endregion

        #region Go Back Start Screen
        private void btn_back_Click(object sender, EventArgs e)
        {
            StartScreen start = new StartScreen();
            this.Hide();
            start.Show();
        }
        #endregion

        #region Close the APP
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
    }
}
