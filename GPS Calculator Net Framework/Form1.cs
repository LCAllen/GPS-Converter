using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;

namespace GPS_Calculator_Net_Framework
{
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }

        // Active system selection radio buttons
        private void radioButtonDMS_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDLat.ReadOnly = false;
            textBoxDLong.ReadOnly = false;
            textBoxMLat.ReadOnly = false;
            textBoxMLong.ReadOnly = false;
            textBoxSLat.ReadOnly = false;
            textBoxSLong.ReadOnly = false;

            textBoxDDMLatD.ReadOnly = true;
            textBoxDDMLongD.ReadOnly = true;
            textBoxDDMLatM.ReadOnly = true;
            textBoxDDMLongM.ReadOnly = true;

            textBoxDDLat.ReadOnly = true;
            textBoxDDLong.ReadOnly = true;

            textBoxUTM.ReadOnly = true;

            textBoxMGRS.ReadOnly = true;
        }

        private void radioButtonDDM_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDLat.ReadOnly = true;
            textBoxDLong.ReadOnly = true;
            textBoxMLat.ReadOnly = true;
            textBoxMLong.ReadOnly = true;
            textBoxSLat.ReadOnly = true;
            textBoxSLong.ReadOnly = true;

            textBoxDDMLatD.ReadOnly = false;
            textBoxDDMLongD.ReadOnly = false;
            textBoxDDMLatM.ReadOnly = false;
            textBoxDDMLongM.ReadOnly = false;

            textBoxDDLat.ReadOnly = true;
            textBoxDDLong.ReadOnly = true;

            textBoxUTM.ReadOnly = true;

            textBoxMGRS.ReadOnly = true;
        }

        private void radioButtonDD_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDLat.ReadOnly = true;
            textBoxDLong.ReadOnly = true;
            textBoxMLat.ReadOnly = true;
            textBoxMLong.ReadOnly = true;
            textBoxSLat.ReadOnly = true;
            textBoxSLong.ReadOnly = true;

            textBoxDDMLatD.ReadOnly = true;
            textBoxDDMLongD.ReadOnly = true;
            textBoxDDMLatM.ReadOnly = true;
            textBoxDDMLongM.ReadOnly = true;

            textBoxDDLat.ReadOnly = false;
            textBoxDDLong.ReadOnly = false;

            textBoxUTM.ReadOnly = true;

            textBoxMGRS.ReadOnly = true;
        }


        private void radioButtonUTM_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDLat.ReadOnly = true;
            textBoxDLong.ReadOnly = true;
            textBoxMLat.ReadOnly = true;
            textBoxMLong.ReadOnly = true;
            textBoxSLat.ReadOnly = true;
            textBoxSLong.ReadOnly = true;

            textBoxDDMLatD.ReadOnly = true;
            textBoxDDMLongD.ReadOnly = true;
            textBoxDDMLatM.ReadOnly = true;
            textBoxDDMLongM.ReadOnly = true;

            textBoxDDLat.ReadOnly = true;
            textBoxDDLong.ReadOnly = true;

            textBoxUTM.ReadOnly = false;

            textBoxMGRS.ReadOnly = true;
        }

        private void radioButtonMGRS_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDLat.ReadOnly = true;
            textBoxDLong.ReadOnly = true;
            textBoxMLat.ReadOnly = true;
            textBoxMLong.ReadOnly = true;
            textBoxSLat.ReadOnly = true;
            textBoxSLong.ReadOnly = true;

            textBoxDDMLatD.ReadOnly = true;
            textBoxDDMLongD.ReadOnly = true;
            textBoxDDMLatM.ReadOnly = true;
            textBoxDDMLongM.ReadOnly = true;

            textBoxDDLat.ReadOnly = true;
            textBoxDDLong.ReadOnly = true;

            textBoxUTM.ReadOnly = true;

            textBoxMGRS.ReadOnly = false;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            // Check which active system is being used

            // DMS is input
            if (radioButtonDMS.Checked)
            {
                try
                {
                    // Set DD
                    double ddLat = double.Parse(textBoxDLat.Text) + (double.Parse(textBoxMLat.Text) / 60) + (double.Parse(textBoxSLat.Text) / 3600);
                    double ddLong = double.Parse(textBoxDLong.Text) + (double.Parse(textBoxMLong.Text) / 60) + (double.Parse(textBoxSLong.Text) / 3600);

                    // Invert for S/W coordinates
                    if (radioButtonS.Checked)
                    {
                        ddLat *= -1;
                    }

                    if (radioButtonW.Checked)
                    {
                        ddLong *= -1;
                    }

                    textBoxDDLat.Text = ddLat.ToString();
                    textBoxDDLong.Text = ddLong.ToString();

                    // Set DDM
                    textBoxDDMLatD.Text = textBoxDLat.Text;
                    textBoxDDMLongD.Text = textBoxDLong.Text;

                    double ddmLat = double.Parse(textBoxMLat.Text) + (double.Parse(textBoxSLat.Text) / 60);
                    double ddmLong = double.Parse(textBoxMLong.Text) + (double.Parse(textBoxSLong.Text) / 60);

                    textBoxDDMLatM.Text = Math.Round(ddmLat, 4).ToString();
                    textBoxDDMLongM.Text = Math.Round(ddmLong, 4).ToString();

                    // Set UTM
                    Deg2UTM utm = new Deg2UTM(ddLat, ddLong);
                    textBoxUTM.Text = utm.zone.ToString() + utm.letter.ToString() + ' ' + utm.easting.ToString() + ' ' + utm.northing.ToString();

                    // Set MGRS
                    UTM2MGRS mgrs = new UTM2MGRS(utm.zone, utm.letter, utm.easting, utm.northing);
                    textBoxMGRS.Text = mgrs.zone.ToString() + mgrs.letter + ' ' + mgrs.squareID + ' ' + mgrs.easting + ' ' + mgrs.northing;
                }
                // Rudimentary error handling
                catch (Exception e1)
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

                    System.Windows.Forms.MessageBox.Show("Input format error. Writing exception to log.txt");

                    if (!File.Exists(path))
                    {
                        FileStream fs = File.Open(path, FileMode.Create, FileAccess.Write, FileShare.None);
                        fs.Close();
                    }
                    File.AppendAllText(path, "\n" + e1.ToString());
                }
            }

            // DDM is input
            else if (radioButtonDDM.Checked)
            {
                try
                {
                    // Set DD
                    double ddLat = double.Parse(textBoxDDMLatD.Text) + (double.Parse(textBoxDDMLatM.Text) / 60);
                    double ddLong = double.Parse(textBoxDDMLongD.Text) + (double.Parse(textBoxDDMLongM.Text) / 60);

                    if (radioButtonDDMS.Checked)
                    {
                        ddLat *= -1;
                    }

                    if (radioButtonDDMW.Checked)
                    {
                        ddLong *= -1;
                    }

                    textBoxDDLat.Text = ddLat.ToString();
                    textBoxDDLong.Text = ddLong.ToString();

                    // Set DMS
                    double latSec = ddLat * 3600;
                    int latDeg = (int)latSec / 3600;
                    latSec = Math.Abs(latSec % 3600);
                    int latMin = (int)latSec / 60;
                    latSec %= 60;

                    double longSec = ddLong * 3600;
                    int longDeg = (int)longSec / 3600;
                    longSec = Math.Abs(longSec % 3600);
                    int longMin = (int)longSec / 60;
                    longSec %= 60;

                    if (ddLat < 0)
                    {
                        latDeg *= -1;
                        radioButtonS.Checked = true;
                    }

                    if (ddLong < 0)
                    {
                        longDeg *= -1;
                        radioButtonW.Checked = true;
                    }

                    // Set DMS
                    textBoxDLat.Text = latDeg.ToString();
                    textBoxDLong.Text = longDeg.ToString();

                    textBoxMLat.Text = latMin.ToString();
                    textBoxMLong.Text = longMin.ToString();

                    textBoxSLat.Text = Math.Round(latSec, 4).ToString();
                    textBoxSLong.Text = Math.Round(longSec, 4).ToString();

                    // Set UTM
                    Deg2UTM utm = new Deg2UTM(ddLat, ddLong);
                    textBoxUTM.Text = utm.zone.ToString() + utm.letter.ToString() + ' ' + utm.easting.ToString() + ' ' + utm.northing.ToString();

                    // Set MGRS
                    UTM2MGRS mgrs = new UTM2MGRS(utm.zone, utm.letter, utm.easting, utm.northing);
                    textBoxMGRS.Text = mgrs.zone.ToString() + mgrs.letter + ' ' + mgrs.squareID + ' ' + mgrs.easting + ' ' + mgrs.northing;
                }
                // Rudimentary error handling
                catch (Exception e1)
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

                    System.Windows.Forms.MessageBox.Show("Input format error. Writing exception to log.txt");

                    if (!File.Exists(path))
                    {
                        FileStream fs = File.Open(path, FileMode.Create, FileAccess.Write, FileShare.None);
                        fs.Close();
                    }
                    File.AppendAllText(path, "\n" + e1.ToString());
                }
            }

            // DD is input
            else if (radioButtonDD.Checked)
            {
                try
                {
                    // Set DMS
                    double ddLat = double.Parse(textBoxDDLat.Text);
                    double ddLong = double.Parse(textBoxDDLong.Text);

                    double latSec = ddLat * 3600;
                    int latDeg = (int)latSec / 3600;
                    latSec = Math.Abs(latSec % 3600);
                    double latMinDouble = latSec / 60;
                    int latMin = (int)latSec / 60;
                    latSec %= 60;

                    double longSec = ddLong * 3600;
                    int longDeg = (int)longSec / 3600;
                    longSec = Math.Abs(longSec % 3600);
                    int longMin = (int)longSec / 60;
                    double longMinDouble = longSec / 60;
                    longSec %= 60;

                    if (ddLat < 0)
                    {
                        latDeg *= -1;
                        radioButtonS.Checked = true;
                    }

                    if (ddLong < 0)
                    {
                        longDeg *= -1;
                        radioButtonW.Checked = true;
                    }

                    textBoxDLat.Text = latDeg.ToString();
                    textBoxDLong.Text = longDeg.ToString();

                    textBoxMLat.Text = latMin.ToString();
                    textBoxMLong.Text = longMin.ToString();

                    textBoxSLat.Text = Math.Round(latSec, 4).ToString();
                    textBoxSLong.Text = Math.Round(longSec, 4).ToString();

                    // Set DDM
                    double ddmLatM = latMin + (latSec / 60);
                    double ddmLongM = longMin + (longSec / 60);

                    if (ddLat < 0)
                    {
                        radioButtonDDMS.Checked = true;
                    }

                    if (ddLong < 0)
                    {
                        radioButtonDDMW.Checked = true;
                    }

                    textBoxDDMLatD.Text = latDeg.ToString();
                    textBoxDDMLongD.Text = longDeg.ToString();

                    textBoxDDMLatM.Text = Math.Round(ddmLatM, 4).ToString();
                    textBoxDDMLongM.Text = Math.Round(ddmLongM, 4).ToString();

                    // Set UTM
                    Deg2UTM utm = new Deg2UTM(ddLat, ddLong);
                    textBoxUTM.Text = utm.zone.ToString() + utm.letter.ToString() + ' ' + utm.easting.ToString() + ' ' + utm.northing.ToString();

                    // Set MGRS
                    UTM2MGRS mgrs = new UTM2MGRS(utm.zone, utm.letter, utm.easting, utm.northing);
                    textBoxMGRS.Text = mgrs.zone.ToString() + mgrs.letter + ' ' + mgrs.squareID + ' ' + mgrs.easting + ' ' + mgrs.northing;
                }
                // Rudimentary error handling
                catch (Exception e1)
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

                    System.Windows.Forms.MessageBox.Show("Input format error. Writing exception to log.txt");

                    if (!File.Exists(path))
                    {
                        FileStream fs = File.Open(path, FileMode.Create, FileAccess.Write, FileShare.None);
                        fs.Close();
                    }
                    File.AppendAllText(path, "\n" + e1.ToString());
                }
            }

            // UTM is input
            else if (radioButtonUTM.Checked)
            {
                try
                {
                    UTM2Deg deg = new UTM2Deg(textBoxUTM.Text);

                    double ddLat = deg.latitude;
                    double ddLong = deg.longitude;

                    double latSec = ddLat * 3600;
                    int latDeg = (int)latSec / 3600;
                    latSec = Math.Abs(latSec % 3600);
                    int latMin = (int)latSec / 60;
                    latSec %= 60;

                    double longSec = ddLong * 3600;
                    int longDeg = (int)longSec / 3600;
                    longSec = Math.Abs(longSec % 3600);
                    int longMin = (int)longSec / 60;
                    longSec %= 60;

                    if (ddLat < 0)
                    {
                        latDeg *= -1;
                        radioButtonS.Checked = true;
                    }

                    if (ddLong < 0)
                    {
                        longDeg *= -1;
                        radioButtonW.Checked = true;
                    }

                    // Set DMS
                    textBoxDLat.Text = latDeg.ToString();
                    textBoxDLong.Text = longDeg.ToString();

                    textBoxMLat.Text = latMin.ToString();
                    textBoxMLong.Text = longMin.ToString();

                    textBoxSLat.Text = Math.Round(latSec, 4).ToString();
                    textBoxSLong.Text = Math.Round(longSec, 4).ToString();

                    // Set DD
                    textBoxDDLat.Text = ddLat.ToString();
                    textBoxDDLong.Text = ddLong.ToString();

                    // Set DDM
                    double ddmLat = double.Parse(textBoxMLat.Text) + (double.Parse(textBoxSLat.Text) / 60);
                    double ddmLong = double.Parse(textBoxMLong.Text) + (double.Parse(textBoxSLong.Text) / 60);

                    textBoxDDMLatM.Text = ddmLat.ToString();
                    textBoxDDMLongM.Text = ddmLong.ToString();

                    // Set MGRS
                    string zoneString = "";
                    int zone;
                    char letter = ' ';
                    double easting;
                    double northing;

                    string utmString = textBoxUTM.Text;
                    string[] utmStrings = utmString.Split(' ');

                    for (int i = 0; i < utmString.Length; i++)
                    {
                        if (Char.IsDigit(utmString[i]))
                        {
                            zoneString = zoneString + utmString.ElementAt(i);
                        }
                        else
                        {
                            letter = utmString[i];
                            break;
                        }
                    }

                    zone = int.Parse(zoneString);
                    easting = double.Parse(utmStrings[1]);
                    northing = double.Parse(utmStrings[2]);

                    UTM2MGRS mgrs = new UTM2MGRS(zone, letter, easting, northing);
                    textBoxMGRS.Text = mgrs.zone.ToString() + mgrs.letter + ' ' + mgrs.squareID + ' ' + mgrs.easting + ' ' + mgrs.northing;
                }
                // Rudimentary error handling
                catch (Exception e1)
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

                    System.Windows.Forms.MessageBox.Show("Input format error. Writing exception to log.txt");

                    if (!File.Exists(path))
                    {
                        FileStream fs = File.Open(path, FileMode.Create, FileAccess.Write, FileShare.None);
                        fs.Close();
                    }
                    File.AppendAllText(path, "\n" + e1.ToString());
                }
            }
        }

        private void buttonCopyDMSLat_Click(object sender, EventArgs e)
        {
            string output = "";

            if (radioButtonN.Checked == true)
            {
                output = textBoxDLat.Text + "° " + textBoxMLat.Text + "’ " + textBoxSLat.Text + "” " + "N";
            }
            else
            {
                output = textBoxDLat.Text + "° " + textBoxMLat.Text + "’ " + textBoxSLat.Text + "” " + "S";
            }
            Clipboard.SetText(output);
        }

        private void buttonCopyDMSLong_Click(object sender, EventArgs e)
        {
            string output = "";

            if (radioButtonE.Checked == true)
            {
                output = textBoxDLong.Text + "° " + textBoxMLong.Text + "’ " + textBoxSLong.Text + "” " + "E";
            }
            else
            {
                output = textBoxDLong.Text + "° " + textBoxMLong.Text + "’ " + textBoxSLong.Text + "” " + "W";
            }
            Clipboard.SetText(output);
        }

        private void buttonCopyDDMLat_Click(object sender, EventArgs e)
        {
            string output = "";

            if (radioButtonDDMN.Checked == true)
            {
                output = textBoxDDMLatD.Text + "° " + textBoxDDMLatM.Text + "’ " + "N";
            }
            else
            {
                output = textBoxDDMLatD.Text + "° " + textBoxDDMLatM.Text + "’ " + "S";
            }
            Clipboard.SetText(output);
        }

        private void buttonCopyDDMLong_Click(object sender, EventArgs e)
        {
            string output = "";

            if (radioButtonDDME.Checked == true)
            {
                output = textBoxDDMLatD.Text + "° " + textBoxDDMLatM.Text + "’ " + "E";
            }
            else
            {
                output = textBoxDDMLatD.Text + "° " + textBoxDDMLatM.Text + "’ " + "W";
            }
            Clipboard.SetText(output);
        }

        private void buttonCopyDDLat_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDDLat.Text);
        }

        private void buttonCopyDDLong_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDDLong.Text);
        }

        private void buttonCopyUTM_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxUTM.Text);
        }

        private void buttonCopyMGRS_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxMGRS.Text);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDLat.Text = "DD";
            textBoxDLong.Text = "DD";
            textBoxMLat.Text = "MM";
            textBoxMLong.Text = "MM";
            textBoxSLat.Text = "SS.SSSS";
            textBoxSLong.Text = "SS.SSSS";
            textBoxDDMLatD.Text = "DD";
            textBoxDDMLongD.Text = "DD";
            textBoxDDMLatM.Text = "MM.MMMM";
            textBoxDDMLongM.Text = "MM.MMMM";
            textBoxDDLat.Text = "DD.DDDDDD";
            textBoxDDLong.Text = "DD.DDDDDD";
            textBoxUTM.Text = "";
            textBoxMGRS.Text = "";
        }
    }
    public class UTM2MGRS
    {
        public int zone;
        public char letter;
        public string squareID;
        public string easting;
        public string northing;

        // converted to C# from https://github.com/chrisveness/geodesy

        // ORIGINAL LICENSE
        // The MIT License (MIT)

        // Copyright (c) 2014 Chris Veness

        // Permission is hereby granted, free of charge, to any person obtaining a copy
        // of this software and associated documentation files (the "Software"), to deal
        // in the Software without restriction, including without limitation the rights
        // to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
        // copies of the Software, and to permit persons to whom the Software is
        // furnished to do so, subject to the following conditions:

        // The above copyright notice and this permission notice shall be included in all
        // copies or substantial portions of the Software.

        // THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
        // IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
        // FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
        // AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
        // LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
        // OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
        // SOFTWARE.
        public UTM2MGRS(int Zone, char Letter, double Easting, double Northing)
        {
            string[] e100kLetters = { "ABCDEFGH", "JKLMNPQR", "STUVWXYZ" };
            string[] n100kLetters = { "ABCDEFGHJKLMNPQRSTUV", "FGHJKLMNPQRSTUVABCDE" };

            this.zone = Zone;
            this.letter = Letter;

            UTM2Deg deg = new UTM2Deg(Zone + Letter + " " + Easting + " " + Northing);

            double DDLat = deg.latitude;

            double col = Math.Floor(Easting / 100e3);
            char e100k = e100kLetters[(Zone - 1) % 3].ElementAt((int)(col - 1));

            double row = Math.Floor(Northing / 100e3) % 20;
            char n100k = n100kLetters[(Zone - 1) % 2].ElementAt((int)row);

            this.squareID = "" + e100k + n100k;

            Easting = Easting % 100e3;
            Northing = Northing % 100e3;

            this.easting = Math.Round(Easting, 6).ToString();
            this.northing = Math.Round(Northing, 6).ToString();

            this.easting = this.easting.PadLeft(5, '0');
            this.northing = this.northing.PadLeft(5, '0');
        }
    }

    public class MGRS2UTM
    {
        public int zone;
        public char letter;
        public double easting;
        public double northing;

        // converted to C# from https://github.com/chrisveness/geodesy

        // ORIGINAL LICENSE
        // The MIT License (MIT)

        // Copyright (c) 2014 Chris Veness

        // Permission is hereby granted, free of charge, to any person obtaining a copy
        // of this software and associated documentation files (the "Software"), to deal
        // in the Software without restriction, including without limitation the rights
        // to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
        // copies of the Software, and to permit persons to whom the Software is
        // furnished to do so, subject to the following conditions:

        // The above copyright notice and this permission notice shall be included in all
        // copies or substantial portions of the Software.

        // THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
        // IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
        // FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
        // AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
        // LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
        // OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
        // SOFTWARE.
        public MGRS2UTM(int Zone, char Letter, string SquareID, double Easting, double Northing)
        {
            string latBands = "CDEFGHJKLMNPQRSTUVWXX"; // X is repeated for 80-84°N
            string[] e100kLetters = { "ABCDEFGH", "JKLMNPQR", "STUVWXYZ" };
            string[] n100kLetters = { "ABCDEFGHJKLMNPQRSTUV", "FGHJKLMNPQRSTUVABCDE" };

            this.zone = Zone;
            this.letter = Letter;

            int col = e100kLetters[(Zone - 1) % 3].IndexOf(SquareID.ElementAt(0)) + 1;
            double e100kNum = col * 100e3;

            int row = n100kLetters[(Zone - 1) % 2].IndexOf(SquareID.ElementAt(1));
            double n100kNum = row * 100e3;

            int latBand = (latBands.IndexOf(Letter) - 10) * 8;

            this.easting = Easting + e100kNum;
            this.northing = Northing + n100kNum;

        }
    }

    // Converted to C# from user2548538 https://stackoverflow.com/questions/176137/java-convert-lat-lon-to-utm

    public class Deg2UTM
    {
        public int zone;
        public char letter;
        public double easting;
        public double northing;
        public Deg2UTM(double Latitude, double Longitude)
        {
            zone = (int)Math.Floor(Longitude / 6 + 31);
            if (Latitude < -72)
                letter = 'C';
            else if (Latitude < -64)
                letter = 'D';
            else if (Latitude < -56)
                letter = 'E';
            else if (Latitude < -48)
                letter = 'F';
            else if (Latitude < -40)
                letter = 'G';
            else if (Latitude < -32)
                letter = 'H';
            else if (Latitude < -24)
                letter = 'J';
            else if (Latitude < -16)
                letter = 'K';
            else if (Latitude < -8)
                letter = 'L';
            else if (Latitude < 0)
                letter = 'M';
            else if (Latitude < 8)
                letter = 'N';
            else if (Latitude < 16)
                letter = 'P';
            else if (Latitude < 24)
                letter = 'Q';
            else if (Latitude < 32)
                letter = 'R';
            else if (Latitude < 40)
                letter = 'S';
            else if (Latitude < 48)
                letter = 'T';
            else if (Latitude < 56)
                letter = 'U';
            else if (Latitude < 64)
                letter = 'V';
            else if (Latitude < 72)
                letter = 'W';
            else
                letter = 'X';
            easting = 0.5 * Math.Log((1 + Math.Cos(Latitude * Math.PI / 180)
                * Math.Sin(Longitude * Math.PI / 180 - (6 * zone - 183) * Math.PI / 180))
                / (1 - Math.Cos(Latitude * Math.PI / 180) * Math.Sin(Longitude * Math.PI / 180 - (6 * zone - 183)
                * Math.PI / 180))) * 0.9996 * 6399593.62 / Math.Pow((1 + Math.Pow(0.0820944379, 2)
                * Math.Pow(Math.Cos(Latitude * Math.PI / 180), 2)), 0.5) * (1 + Math.Pow(0.0820944379, 2) / 2
                * Math.Pow((0.5 * Math.Log((1 + Math.Cos(Latitude * Math.PI / 180)
                * Math.Sin(Longitude * Math.PI / 180 - (6 * zone - 183) * Math.PI / 180))
                / (1 - Math.Cos(Latitude * Math.PI / 180)
                * Math.Sin(Longitude * Math.PI / 180 - (6 * zone - 183) * Math.PI / 180)))), 2)
                * Math.Pow(Math.Cos(Latitude * Math.PI / 180), 2) / 3) + 500000;

            //Easting = Math.Round(Easting);
            easting = (int)easting;

            northing = (Math.Atan(Math.Tan(Latitude * Math.PI / 180)
                / Math.Cos((Longitude * Math.PI / 180 - (6 * zone - 183)
                * Math.PI / 180))) - Latitude * Math.PI / 180)
                * 0.9996
                * 6399593.625
                / Math.Sqrt(1 + 0.006739496742 * Math.Pow(Math.Cos(Latitude * Math.PI / 180), 2))
                * (1 + 0.006739496742 / 2 * Math.Pow(0.5 * Math.Log((1 + Math.Cos(Latitude * Math.PI / 180)
                * Math.Sin((Longitude * Math.PI / 180 - (6 * zone - 183) * Math.PI / 180)))
                / (1 - Math.Cos(Latitude * Math.PI / 180)
                * Math.Sin((Longitude * Math.PI / 180 - (6 * zone - 183) * Math.PI / 180)))), 2)
                * Math.Pow(Math.Cos(Latitude * Math.PI / 180), 2))
                + 0.9996
                * 6399593.625
                * (Latitude * Math.PI / 180 - 0.005054622556 * (Latitude * Math.PI / 180 + Math.Sin(2 * Latitude * Math.PI / 180) / 2)
                + 4.258201531e-05 * (3 * (Latitude * Math.PI / 180 + Math.Sin(2 * Latitude * Math.PI / 180) / 2)
                + Math.Sin(2 * Latitude * Math.PI / 180) * Math.Pow(Math.Cos(Latitude * Math.PI / 180), 2))
                / 4 - 1.674057895e-07 * (5 * (3 * (Latitude * Math.PI / 180 + Math.Sin(2 * Latitude * Math.PI / 180) / 2)
                + Math.Sin(2 * Latitude * Math.PI / 180) * Math.Pow(Math.Cos(Latitude * Math.PI / 180), 2))
                / 4 + Math.Sin(2 * Latitude * Math.PI / 180) * Math.Pow(Math.Cos(Latitude * Math.PI / 180), 2)
                * Math.Pow(Math.Cos(Latitude * Math.PI / 180), 2)) / 3);

            if (letter < 'M')
                northing = northing + 10000000;
            //Northing = Math.Round(Northing);
            northing = (int)northing;
        }
    }

    public class UTM2Deg
    {
        public double latitude;
        public double longitude;
        public UTM2Deg(string UTM)
        {
            string[] parts = UTM.Split(' ');

            if(parts.Length < 3)
            {
                System.Windows.Forms.MessageBox.Show("Please space separate zone, northing, and easting values");
            }

            char ZoneChar = parts[0].ElementAt(0);
            int Zone = (int)Char.GetNumericValue(ZoneChar);
            char Letter = Char.ToUpper(parts[0].ElementAt(1));
            double Easting = Double.Parse(parts[1]);
            double Northing = Double.Parse(parts[2]);
            double Hem;
            if (Letter > 'M')
                Hem = 'N';
            else
                Hem = 'S';
            double north;
            if (Hem == 'S')
                north = Northing - 10000000;
            else
                north = Northing;
            latitude = (north / 6366197.724 / 0.9996 + (1 + 0.006739496742
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2) - 0.006739496742
                * Math.Sin(north / 6366197.724 / 0.9996) * Math.Cos(north / 6366197.724 / 0.9996)
                * (Math.Atan(Math.Cos(Math.Atan((Math.Exp((Easting - 500000) / (0.9996 * 6399593.625
                / Math.Sqrt((1 + 0.006739496742 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))))
                * (1 - 0.006739496742 * Math.Pow((Easting - 500000) / (0.9996 * 6399593.625
                / Math.Sqrt((1 + 0.006739496742 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)))), 2)
                / 2 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2) / 3)) - Math.Exp(-(Easting - 500000)
                / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))))
                * (1 - 0.006739496742 * Math.Pow((Easting - 500000) / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)))), 2) / 2 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2) / 3)))
                / 2 / Math.Cos((north - 0.9996 * 6399593.625 * (north / 6366197.724 / 0.9996 - 0.006739496742 * 3
                / 4 * (north / 6366197.724 / 0.9996 + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2)
                + Math.Pow(0.006739496742 * 3 / 4, 2) * 5 / 3 * (3 * (north / 6366197.724 / 0.9996
                + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2) + Math.Sin(2 * north / 6366197.724 / 0.9996)
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)) / 4 - Math.Pow(0.006739496742 * 3 / 4, 3)
                * 35 / 27 * (5 * (3 * (north / 6366197.724 / 0.9996 + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2)
                + Math.Sin(2 * north / 6366197.724 / 0.9996) * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))
                / 4 + Math.Sin(2 * north / 6366197.724 / 0.9996) * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)) / 3)) / (0.9996 * 6399593.625
                / Math.Sqrt((1 + 0.006739496742 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))))
                * (1 - 0.006739496742 * Math.Pow((Easting - 500000) / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)))), 2) / 2 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))
                + north / 6366197.724 / 0.9996))) * Math.Tan((north - 0.9996 * 6399593.625 * (north / 6366197.724 / 0.9996 - 0.006739496742
                * 3 / 4 * (north / 6366197.724 / 0.9996 + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2) + Math.Pow(0.006739496742 * 3 / 4, 2)
                * 5 / 3 * (3 * (north / 6366197.724 / 0.9996 + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2)
                + Math.Sin(2 * north / 6366197.724 / 0.9996) * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))
                / 4 - Math.Pow(0.006739496742 * 3 / 4, 3) * 35 / 27 * (5 * (3 * (north / 6366197.724 / 0.9996
                + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2) + Math.Sin(2 * north / 6366197.724 / 0.9996)
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)) / 4 + Math.Sin(2 * north / 6366197.724 / 0.9996)
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2) * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)) / 3))
                / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))))
                * (1 - 0.006739496742 * Math.Pow((Easting - 500000) / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)))), 2) / 2 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))
                + north / 6366197.724 / 0.9996)) - north / 6366197.724 / 0.9996) * 3 / 2) * (Math.Atan(Math.Cos(Math.Atan((Math.Exp((Easting - 500000)
                / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))))
                * (1 - 0.006739496742 * Math.Pow((Easting - 500000) / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)))), 2) / 2 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2) / 3))
                - Math.Exp(-(Easting - 500000) / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)))) * (1 - 0.006739496742 * Math.Pow((Easting - 500000)
                / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)))), 2)
                / 2 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2) / 3))) / 2 / Math.Cos((north - 0.9996 * 6399593.625
                * (north / 6366197.724 / 0.9996 - 0.006739496742 * 3 / 4 * (north / 6366197.724 / 0.9996
                + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2) + Math.Pow(0.006739496742 * 3 / 4, 2) * 5
                / 3 * (3 * (north / 6366197.724 / 0.9996 + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2)
                + Math.Sin(2 * north / 6366197.724 / 0.9996) * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))
                / 4 - Math.Pow(0.006739496742 * 3 / 4, 3) * 35 / 27 * (5 * (3 * (north / 6366197.724 / 0.9996
                + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2) + Math.Sin(2 * north / 6366197.724 / 0.9996)
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)) / 4 + Math.Sin(2 * north / 6366197.724 / 0.9996)
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2) * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)) / 3))
                / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))))
                * (1 - 0.006739496742 * Math.Pow((Easting - 500000) / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)))), 2) / 2 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))
                + north / 6366197.724 / 0.9996))) * Math.Tan((north - 0.9996 * 6399593.625 * (north / 6366197.724 / 0.9996 - 0.006739496742
                * 3 / 4 * (north / 6366197.724 / 0.9996 + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2) + Math.Pow(0.006739496742 * 3 / 4, 2)
                * 5 / 3 * (3 * (north / 6366197.724 / 0.9996 + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2)
                + Math.Sin(2 * north / 6366197.724 / 0.9996) * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))
                / 4 - Math.Pow(0.006739496742 * 3 / 4, 3) * 35 / 27 * (5 * (3 * (north / 6366197.724 / 0.9996
                + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2) + Math.Sin(2 * north / 6366197.724 / 0.9996)
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)) / 4 + Math.Sin(2 * north / 6366197.724 / 0.9996)
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2) * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)) / 3))
                / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))))
                * (1 - 0.006739496742 * Math.Pow((Easting - 500000) / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)))), 2) / 2 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))
                + north / 6366197.724 / 0.9996)) - north / 6366197.724 / 0.9996)) * 180 / Math.PI;

            latitude = Math.Round(latitude * 10000000);
            latitude = latitude / 10000000;
            longitude = Math.Atan((Math.Exp((Easting - 500000)
                / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))))
                * (1 - 0.006739496742 * Math.Pow((Easting - 500000)
                / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)))), 2)
                / 2 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2) / 3))
                - Math.Exp(-(Easting - 500000) / (0.9996 * 6399593.625
                / Math.Sqrt((1 + 0.006739496742 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))))
                * (1 - 0.006739496742 * Math.Pow((Easting - 500000)
                / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)))), 2)
                / 2 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2) / 3)))
                / 2 / Math.Cos((north - 0.9996 * 6399593.625
                * (north / 6366197.724 / 0.9996 - 0.006739496742 * 3
                / 4 * (north / 6366197.724 / 0.9996 + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2) + Math.Pow(0.006739496742 * 3 / 4, 2)
                * 5 / 3 * (3 * (north / 6366197.724 / 0.9996 + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2)
                + Math.Sin(2 * north / 6366197.724 / 0.9996) * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))
                / 4 - Math.Pow(0.006739496742 * 3 / 4, 3) * 35 / 27 * (5 * (3 * (north / 6366197.724 / 0.9996
                + Math.Sin(2 * north / 6366197.724 / 0.9996) / 2) + Math.Sin(2 * north / 6366197.724 / 0.9996)
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)) / 4 + Math.Sin(2 * north / 6366197.724 / 0.9996)
                * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2) * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))
                / 3)) / (0.9996 * 6399593.625 / Math.Sqrt((1 + 0.006739496742 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2))))
                * (1 - 0.006739496742 * Math.Pow((Easting - 500000) / (0.9996 * 6399593.625
                / Math.Sqrt((1 + 0.006739496742 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)))), 2)
                / 2 * Math.Pow(Math.Cos(north / 6366197.724 / 0.9996), 2)) + north / 6366197.724 / 0.9996))
                * 180 / Math.PI + Zone * 6 - 183;

            longitude = Math.Round(longitude * 10000000);
            longitude = longitude / 10000000;
        }
    }
}