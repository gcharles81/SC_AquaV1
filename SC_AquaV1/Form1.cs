using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Ini;


namespace SC_AquaV1
{
    public partial class Form1 : Form
    {
        //////////UDP_RELATED//////////////////////////
        char UDP_DELIMINER = ':';//
        char UDP_START = ' ';  //// A-Z
        int UDP_FUNCT = 0; //// 0-255
        String[] UDP_STRING_COMBINED = new String[8];
        String[] TEMP_STRING_DATA = new String[7];
        String EMPTY_UDP = "K:0:0:0:0:0:0:0";
        Char UDP_Timers_Digit_00 = ' ';
        int UDP_Timers_Digit_01 = 16;
        int UDP_Timers_Digit_02 = 10;
        int UDP_Timers_Digit_03 = 30;
        int UDP_Timers_Digit_04 = 14;
        int UDP_Timers_Digit_05 = 35;
        int UDP_Timers_Digit_06 = 100;
        int UDP_Timers_Digit_07 = 45;

        //////////////////////////Sunrise timer related
        bool SunriseHON = false;
        bool SunriseMON = false;
        bool SunriseHOFF = false;
        bool SunriseMOFF = false;
        bool SRDUR = false;
        bool ACTIVATE_SUNRISE = false;
        ////////////////////////////////////////////////
        //////////////////////////Sunset timer related
        bool ACTIVATE_SUNSET = false;
        bool SunsetHON = false;
        bool SunsetMON = false;
        bool SunsetHOFF = false;
        bool SunsetMOFF = false;
        bool SSDUR = false;
        ////////////////////////////////////////////////
        //////////////////////////Day1 timer related
        bool ACTIVATE_DAY1 = false;
        bool Day1HON = false;
        bool Day1MON = false;
        bool Day1HOFF = false;
        bool Day1MOFF = false;
        ////////////////////////////////////////////////
        //////////////////////////Day2 timer related
        bool ACTIVATE_DAY2 = false;
        bool Day2HON = false;
        bool Day2MON = false;
        bool Day2HOFF = false;
        bool Day2MOFF = false;
        ////////////////////////////////////////////////
        //////////////////////////Day3 timer related
        bool ACTIVATE_DAY3 = false;
        bool Day3HON = false;
        bool Day3MON = false;
        bool Day3HOFF = false;
        bool Day3MOFF = false;
        ////////////////////////////////////////////////
        //////////////////////////Neon1 timer related
        bool ACTIVATE_NEON1 = false;
        bool Neon1HON = false;
        bool Neon1MON = false;
        bool Neon1HOFF = false;
        bool Neon1MOFF = false;
        ////////////////////////////////////////////////
        //////////////////////////Neon2 timer related
        bool ACTIVATE_NEON2 = false;
        bool Neon2HON = false;
        bool Neon2MON = false;
        bool Neon2HOFF = false;
        bool Neon2MOFF = false;
        ////////////////////////////////////////////////
        //////////////////////////Neon3 timer related
        bool ACTIVATE_NEON3 = false;
        bool Neon3HON = false;
        bool Neon3MON = false;
        bool Neon3HOFF = false;
        bool Neon3MOFF = false;
        ////////////////////////////////////////////////
        //////////////////////////Night1 timer related
        bool ACTIVATE_NIGHT1 = false;
        bool Night1HON = false;
        bool Night1MON = false;
        bool Night1HOFF = false;
        bool Night1MOFF = false;
        ////////////////////////////////////////////////
        bool ACTIVATE_UV1 = false;
        bool Uv1HON = false;
        bool Uv1MON = false;
        bool Uv1HOFF = false;
        bool Uv1MOFF = false;
        ////////////////////////////////////////////////
        ////////////////////////////////////////////////
        bool ACTIVATE_UV2 = false;
        bool Uv2HON = false;
        bool Uv2MON = false;
        bool Uv2HOFF = false;
        bool Uv2MOFF = false;
        ////////////////////////////////////////////////
        //////////////GENERAL RGB MENU/////////////////
        bool DEBUG = false;
        bool NORMAL_MODE = true;
        ///////////////////////////////////////////////
        //////////////////////////RGB CH1 related
        bool RED1 = false;
        bool GREEN1 = false;
        bool BLUE1 = false;
        bool ACTIVATE_RGB1 = false;
        ////////////////////////////////////////////////
        //////////////////////////RGB CH2 related
        bool ACTIVATE_RGB2 = false;
        bool RED2 = false;
        bool GREEN2 = false;
        bool BLUE2 = false;
        ////////////////////////////////////////////////
        //////////////////////////RGB CH3 related
        bool ACTIVATE_RGB3 = false;
        bool RED3 = false;
        bool GREEN3 = false;
        bool BLUE3 = false;
        ////////////////////////////////////////////////
        //////////////////////////RGB CH4 related
        bool ACTIVATE_RGB4 = false;
        bool RED4 = false;
        bool GREEN4 = false;
        bool BLUE4 = false;
        ////////////////////////////////////////////////
        //////////////////////////LED TEST /////////////
        bool LED_TEST_DELAY = false;
        ///////////////////////////////////////////////
        /////////////////////RGB CH1 PANEL COLOR related 
        int mRed1 = 0;
        int mGreen1 = 0;
        int mBlue1 = 0;
        ///////////////////////////////////////////////
        /////////////////////RGB CH2 PANEL COLOR related 
        int mRed2 = 0;
        int mGreen2 = 0;
        int mBlue2 = 0;
        ///////////////////////////////////////////////			
        /////////////////////RGB CH3 PANEL COLOR related 
        int mRed3 = 0;
        int mGreen3 = 0;
        int mBlue3 = 0;
        ///////////////////////////////////////////////	
        /////////////////////RGB CH4 PANEL COLOR related 
        int mRed4 = 0;
        int mGreen4 = 0;
        int mBlue4 = 0;
        ///////////////////////////////////////////////
        ///////////////////RTC UPDATE related//////////
        bool RTC_ACTIVATE = false;
        bool day = false;
        bool month = false;
        bool year = false;
        bool hour = false;
        bool minute = false;
        ///////////////////////////////////////////////
        ///////////////////SLAVE ADDRESSS UPDATE related
        bool SLAVE_ADD_ACTIVATE = false;
        bool SLAVE_ADD_1_6 = false;
        bool SLAVE_ADD_7_12 = false;
        bool SLAVE_ADD_PH = false;
        ////////////////////////////////////////////////
        /// <Load Saved setting related>
        /// ///////////////////////////////////////////
        String newMessage;
        String newMessage1;
        String newMessage2;
        String newMessage3;
        String newMessage4;
        String newMessage5;
        String newMessage6;
        String newMessage7;
        String newMessage8;
        String newMessage9;
        int Parameters_test1 = 0;
        int Parameters_test2 = 0;
        int Parameters_test3 = 0;
        int Parameters_test4 = 0;
        int Parameters_test5 = 0;
        int Parameters_test6 = 0;
        int Parameters_test7 = 0;
        int Parameters_test8 = 0;
        int Parameters_test9 = 0;
        int Parameters_test10 = 0;

        /// </summary>


        public Form1()
        {
            InitializeComponent();
            FOLDERS();
            comboBox49.SelectedIndex = 0;

        }



        /// Create folders if not found

        private void FOLDERS() {

            String path18 = "config";

            if (Directory.Exists(path18)) {

            }
            else { DirectoryInfo di = Directory.CreateDirectory(path18);
            }
        }
        /// <summary>
        /// /

        /// <param name="e"></param>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////
        private void RGB_config_info() {
            /*
                    StreamWriter outFile = new StreamWriter("config/RGBCONFIG.txt");
                    outFile.Write("\n");
                    outFile.Write("//");
                    outFile.Write(DateTime.Now );
                    outFile.Write("\n");
                    outFile.Write("//File format created by Charles Galea 2016.");
                    outFile.Write("\n");
                    outFile.Write("//This file consists of all RGB4 pwm values.");
                    outFile.Write("\n");
                    outFile.Write("//It is supported from SC_AquaV1 onwards ");
                    outFile.Write("\n");
                    outFile.Write("//0 = OFF  while 255 = MAX VALUE");
                    outFile.Write("\n");
                    outFile.Write("\n");
            */
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////		
            IniFile ini = new IniFile("config/rgb.ini");

            ini.IniWriteValue("Info RGB", "File info ", "//File format created by Charles Galea 2018.");
            ini.IniWriteValue("Info RGB", "File Created ", DateTime.Now.ToString());


            if (ACTIVATE_RGB1 == true) {

                String RED1 = label1.Text;
                ini.IniWriteValue("RGB1", "Red", RED1);

                String GREEN1 = label2.Text;
                ini.IniWriteValue("RGB1", "Green", GREEN1);

                String BLUE1 = label3.Text;
                ini.IniWriteValue("RGB1", "Blue", BLUE1);

                ini.IniWriteValue("RGB1", "Status", "true");

            }

            else if (ACTIVATE_RGB1 == false) {

                String RED1 = label1.Text;
                ini.IniWriteValue("RGB1", "Red", "0");

                String GREEN1 = label2.Text;
                ini.IniWriteValue("RGB1", "Green", "0");

                String BLUE1 = label3.Text;
                ini.IniWriteValue("RGB1", "Blue", "0");

                ini.IniWriteValue("RGB1", "Status", "false");
            }




            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////			
            if (ACTIVATE_RGB2 == true)
            {

                String RED2 = label31.Text;
                ini.IniWriteValue("RGB2", "Red", RED2);

                String GREEN2 = label30.Text;
                ini.IniWriteValue("RGB2", "Green", GREEN2);

                String BLUE2 = label4.Text;
                ini.IniWriteValue("RGB2", "Blue", BLUE2);

                ini.IniWriteValue("RGB2", "Status", "true");

            }

            else if (ACTIVATE_RGB2 == false)
            {


                ini.IniWriteValue("RGB2", "Red", "0");


                ini.IniWriteValue("RGB2", "Green", "0");


                ini.IniWriteValue("RGB2", "Blue", "0");

                ini.IniWriteValue("RGB2", "Status", "false");
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (ACTIVATE_RGB3 == true)
            {

                String RED3 = label34.Text;
                ini.IniWriteValue("RGB3", "Red", RED3);

                String GREEN3 = label33.Text;
                ini.IniWriteValue("RGB3", "Green", GREEN3);

                String BLUE3 = label32.Text;
                ini.IniWriteValue("RGB3", "Blue", BLUE3);

                ini.IniWriteValue("RGB3", "Status", "true");

            }

            else if (ACTIVATE_RGB3 == false)
            {


                ini.IniWriteValue("RGB3", "Red", "0");


                ini.IniWriteValue("RGB3", "Green", "0");


                ini.IniWriteValue("RGB3", "Blue", "0");

                ini.IniWriteValue("RGB3", "Status", "false");
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (ACTIVATE_RGB4 == true)
            {

                String RED4 = label37.Text;
                ini.IniWriteValue("RGB4", "Red", RED4);

                String GREEN4 = label36.Text;
                ini.IniWriteValue("RGB4", "Green", GREEN4);

                String BLUE4 = label35.Text;
                ini.IniWriteValue("RGB4", "Blue", BLUE4);

                ini.IniWriteValue("RGB4", "Status", "true");

            }

            else if (ACTIVATE_RGB4 == false)
            {


                ini.IniWriteValue("RGB4", "Red", "0");


                ini.IniWriteValue("RGB4", "Green", "0");


                ini.IniWriteValue("RGB4", "Blue", "0");

                ini.IniWriteValue("RGB4", "Status", "false");
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            if ((DEBUG == true) & (NORMAL_MODE == false) & (LED_TEST_DELAY == true)) {

                String delay1 = comboBox49.Text;
                ini.IniWriteValue("LED MODE", "Debug", "true");
                ini.IniWriteValue("LED MODE", "Normal", "false");
                ini.IniWriteValue("LED MODE", "Delay", delay1);
            }

            else if ((DEBUG == false) & (NORMAL_MODE == true)) {
                String delay1 = comboBox49.Text;
                ini.IniWriteValue("LED MODE", "Debug", "false");
                ini.IniWriteValue("LED MODE", "Normal", "true");
                ini.IniWriteValue("LED MODE", "Delay", delay1);
            }



            richTextBox1.Text += (DateTime.Now);
            richTextBox1.Text += ("  ");
            richTextBox1.Text += " RGB Config file generated successfully \r\n";

        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            SunriseHON_Lable.BackColor = System.Drawing.Color.DarkOrange;
            //	System.Drawing.Color.Gray;
            SunriseHON = true;
        }
        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            SunriseMON_Lable.BackColor = System.Drawing.Color.DarkOrange;
            SunriseMON = true;
        }
        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            SunriseHOFF_Lable.BackColor = System.Drawing.Color.DarkOrange;
            SunriseHOFF = true;
        }
        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            SunriseMOFF_Lable.BackColor = System.Drawing.Color.DarkOrange;
            SunriseMOFF = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SRDUR_Lable.BackColor = System.Drawing.Color.DarkOrange;
            SRDUR = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ///////////////////////////////sunrise main title color change 
            if ((SunriseHON == true) & (SunriseMON == true) & (SunriseHOFF == true) & (SunriseMOFF == true) & (SRDUR == true) & (Sunrise_checkBox.Checked == true))
            {
                label42.BackColor = System.Drawing.Color.DarkOrange;
                ACTIVATE_SUNRISE = true;
            }

            else
            {
                label42.BackColor = System.Drawing.Color.DarkGray;
                ACTIVATE_SUNRISE = false;
            }
            ///////////////////////////////sunset main title color change 		 

            if ((ACTIVATE_SUNSET == true) & (SunsetHON == true) & (SunsetMON == true) & (SunsetHOFF == true) & (SunsetMOFF == true) & (SSDUR == true) & (Sunset_checkBox.Checked == true))
            {

                label43.BackColor = System.Drawing.Color.DarkOrange;
                ACTIVATE_SUNSET = true;
            }

            else
            {
                label43.BackColor = System.Drawing.Color.DarkGray;
                ACTIVATE_SUNSET = false;
            }
            ///////////////////////////////daytime 1 main title color change 
            if ((ACTIVATE_DAY1 == true) & (Day1HON == true) & (Day1MON == true) & (Day1HOFF == true) & (Day1MOFF == true) & (Day1_checkBox.Checked == true))
            {

                label57.BackColor = System.Drawing.Color.DarkOrange;
                ACTIVATE_DAY1 = true;
            }

            else
            {
                label57.BackColor = System.Drawing.Color.DarkGray;
                ACTIVATE_DAY1 = false;
            }

            ///////////////////////////////daytime 2 main title color change 
            if ((ACTIVATE_DAY2 == true) & (Day2HON == true) & (Day2MON == true) & (Day2HOFF == true) & (Day2MOFF == true) & (Day2_checkBox.Checked == true))
            {
                ACTIVATE_DAY2 = true;
                label23.BackColor = System.Drawing.Color.DarkOrange;
            }

            else
            {
                ACTIVATE_DAY2 = false;
                label23.BackColor = System.Drawing.Color.DarkGray;
            }

            ///////////////////////////////daytime 3 main title color change 
            if ((ACTIVATE_DAY3 == true) & (Day3HON == true) & (Day3MON == true) & (Day3HOFF == true) & (Day3MOFF == true) & (Day3_checkBox.Checked == true))
            {
                ACTIVATE_DAY3 = true;
                label18.BackColor = System.Drawing.Color.DarkOrange;
            }

            else
            {
                ACTIVATE_DAY3 = false;
                label18.BackColor = System.Drawing.Color.DarkGray;
            }


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////NEON 1 title color change 
            if ((ACTIVATE_NEON1 == true) & (Neon1HON == true) & (Neon1MON == true) & (Neon1HOFF == true) & (Neon1MOFF == true) & (Neon1_checkBox.Checked == true))
            {
                ACTIVATE_NEON1 = true;
                NEON1_Lable.BackColor = System.Drawing.Color.DarkOrange;
            }

            else
            {
                ACTIVATE_NEON1 = false;
                NEON1_Lable.BackColor = System.Drawing.Color.DarkGray;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////		 
            ///////////////////////////////NEON 2 title color change 
            if ((ACTIVATE_NEON2 == true) & (Neon2HON == true) & (Neon2MON == true) & (Neon2HOFF == true) & (Neon2MOFF == true) & (Neon2_checkBox.Checked == true))
            {
                ACTIVATE_NEON2 = true;
                NEON2_Lable.BackColor = System.Drawing.Color.DarkOrange;
            }

            else
            {
                ACTIVATE_NEON2 = false;
                NEON2_Lable.BackColor = System.Drawing.Color.DarkGray;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////	
            ///////////////////////////////NEON_3 title color change 
            if ((ACTIVATE_NEON3 == true) & (Neon3HON == true) & (Neon3MON == true) & (Neon3HOFF == true) & (Neon3MOFF == true) & (Neon3_checkBox.Checked == true))
            {
                ACTIVATE_NEON3 = true;
                NEON3_Lable.BackColor = System.Drawing.Color.DarkOrange;
            }

            else
            {
                ACTIVATE_NEON3 = false;
                NEON3_Lable.BackColor = System.Drawing.Color.DarkGray;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////NIGHT_1 title color change 
            if ((ACTIVATE_NIGHT1 == true) & (Night1HON == true) & (Night1MON == true) & (Night1HOFF == true) & (Night1MOFF == true) & (Night1_checkBox.Checked == true))
            {
                ACTIVATE_NIGHT1 = true;
                NIGHT1_Lable.BackColor = System.Drawing.Color.DarkOrange;
            }

            else
            {
                ACTIVATE_NIGHT1 = false;
                NIGHT1_Lable.BackColor = System.Drawing.Color.DarkGray;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////UV_STERILIZER 1 title color change 
            if ((ACTIVATE_UV1 == true) & (Uv1HON == true) & (Uv1MON == true) & (Uv1HOFF == true) & (Uv1MOFF == true) & (Uv1_checkBox.Checked == true))
            {
                ACTIVATE_UV1 = true;
                UV1_Lable.BackColor = System.Drawing.Color.DarkOrange;
            }

            else
            {
                ACTIVATE_UV1 = false;
                UV1_Lable.BackColor = System.Drawing.Color.DarkGray;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////UV_STERILIZER 2 title color change 
            if ((ACTIVATE_UV2 == true) & (Uv2HON == true) & (Uv2MON == true) & (Uv2HOFF == true) & (Uv2MOFF == true) & (Uv2_checkBox.Checked == true))
            {
                ACTIVATE_UV2 = true;
                UV2_Lable.BackColor = System.Drawing.Color.DarkOrange;
            }

            else
            {
                ACTIVATE_UV2 = false;
                UV2_Lable.BackColor = System.Drawing.Color.DarkGray;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////RTC UPDATE title color change 
            if ((RTC_ACTIVATE == true) & (day == true) & (month == true) & (year == true) & (hour == true) & (minute == true) & (RTC_checkBox.Checked == true))
            {
                RTC_Lable.BackColor = System.Drawing.Color.DarkOrange;
                RTC_ACTIVATE = true;
            }

            else
            {
                RTC_ACTIVATE = false;
                RTC_Lable.BackColor = System.Drawing.Color.DarkGray;
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////SLAVE number UPDATE title color change 
            if ((SLAVE_ADD_ACTIVATE == true) & (SLAVE_ADD_1_6 == true) & (SLAVE_ADD_7_12 == true) & (SLAVE_ADD_PH == true) && (SLAVEADD_checkBox.Checked == true))
            {
                SLAVE_ADD_ACTIVATE = true;
                Slave_ADD_Lable.BackColor = System.Drawing.Color.DarkOrange;
            }

            else
            {
                SLAVE_ADD_ACTIVATE = false;
                Slave_ADD_Lable.BackColor = System.Drawing.Color.DarkGray;
            }
            ///////////////////////////////LED TEST  UPDATE title color change # 1
            if ((NORMAL_MODE == true) || (DEBUG == true))
            {
                label27.BackColor = System.Drawing.Color.DarkOrange;
            }

            else
            {
                label27.BackColor = System.Drawing.Color.DarkGray;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (Sunrise_checkBox.Checked == true) {
                ACTIVATE_SUNRISE = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " sunrise activated \r\n";
            }
            else {
                ACTIVATE_SUNRISE = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " sunrise dis activated \r\n";
            }
        }
        //////////////////////////SUNSET////////////////////////////////////////////////////////////////////////////////////
        private void Sunset_CheckedChanged(object sender, EventArgs e)
        {

            if (Sunset_checkBox.Checked == true)
            {
                ACTIVATE_SUNSET = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " sunset activated \r\n";
            }
            else
            {
                ACTIVATE_SUNSET = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " sunset dis activated \r\n";
            }
        }


        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            SunsetHON_Label.BackColor = System.Drawing.Color.DarkOrange;
            SunsetHON = true;
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SunsetMON_Label.BackColor = System.Drawing.Color.DarkOrange;
            SunsetMON = true;
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            SunsetHOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            SunsetHOFF = true;
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            SunsetMOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            SunsetMOFF = true;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SSDUR_Lable.BackColor = System.Drawing.Color.DarkOrange;
            SSDUR = true;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////DAY 1 TIMER /////////////////////////////////////////////////////////////
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (Day1_checkBox.Checked == true)
            {
                ACTIVATE_DAY1 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 1 Timer is activated \r\n";
            }
            else
            {
                ACTIVATE_DAY1 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 1 Timer is dis activated \r\n";
            }
        }
        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR ON DAYTIME 1
            Day1HON_Label.BackColor = System.Drawing.Color.DarkOrange;
            Day1HON = true;
        }
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN ON DAYTIME 1
            Day1MON_Label.BackColor = System.Drawing.Color.DarkOrange;
            Day1MON = true;
        }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR OFF DAYTIME 1
            Day1HOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            Day1HOFF = true;
        }
        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN OFF DAYTIME 1
            Day1MOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            Day1MOFF = true;
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////DAY 3 TIMER /////////////////////////////////////////////////////////////
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (Day3_checkBox.Checked == true)
            {
                ACTIVATE_DAY3 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 3 Timer is activated \r\n";
            }
            else
            {
                ACTIVATE_DAY3 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 3 Timer is dis activated \r\n";
            }
        }
        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR ON DAYTIME3
            Day3HON_Label.BackColor = System.Drawing.Color.DarkOrange;
            Day3HON = true;
        }
        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN ON DAYTIME3
            Day3MON_Label.BackColor = System.Drawing.Color.DarkOrange;
            Day3MON = true;
        }
        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR OFF DAYTIME3
            Day3HOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            Day3HOFF = true;
        }
        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN OFF DAYTIME3
            Day3MOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            Day3MOFF = true;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////DAY 2 TIMER /////////////////////////////////////////////////////////////
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            if (Day2_checkBox.Checked == true)
            {
                ACTIVATE_DAY2 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 2 Timer is activated \r\n";
            }
            else
            {
                ACTIVATE_DAY2 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 2 Timer is dis activated \r\n";
            }
        }
        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR ON DAYTIME2
            Day2HON_Label.BackColor = System.Drawing.Color.DarkOrange;
            Day2HON = true;
        }
        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN ON DAYTIME2
            Day2MON_Label.BackColor = System.Drawing.Color.DarkOrange;
            Day2MON = true;
        }
        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR OFF DAYTIME2
            Day2HOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            Day2HOFF = true;
        }
        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN OFF DAYTIME2
            Day2MOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            Day2MOFF = true;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////


        ////////////////////NEON1 TIMER /////////////////////////////////////////////////////////////
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

            if (Neon1_checkBox.Checked == true)
            {
                ACTIVATE_NEON1 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " NEON_1 Timer is activated \r\n";
            }
            else
            {
                ACTIVATE_NEON1 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " NEON_1 Timer is dis activated \r\n";
            }
        }
        private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR ON NEON1
            Neon1HON_Label.BackColor = System.Drawing.Color.DarkOrange;
            Neon1HON = true;
        }
        private void comboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN ON NEON1
            Neon1MON_Label.BackColor = System.Drawing.Color.DarkOrange;
            Neon1MON = true;
        }
        private void comboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR OFF NEON1
            Neon1HOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            Neon1HOFF = true;
        }
        private void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN OFF NEON1
            Neon1MOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            Neon1MOFF = true;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////Neon2 TIMER /////////////////////////////////////////////////////////////
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

            if (Neon2_checkBox.Checked == true)
            {
                ACTIVATE_NEON2 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " NEON_2 Timer is activated \r\n";
            }
            else
            {
                ACTIVATE_NEON2 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " NEON_2 Timer is dis activated \r\n";
            }
        }
        private void comboBox46_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR ON Neon2
            Neon2HON_Label.BackColor = System.Drawing.Color.DarkOrange;
            Neon2HON = true;
        }
        private void comboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN ON Neon2
            Neon2MON_Label.BackColor = System.Drawing.Color.DarkOrange;
            Neon2MON = true;
        }
        private void comboBox45_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR OFF Neon2
            Neon2HOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            Neon2HOFF = true;
        }
        private void comboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN OFF Neon2
            Neon2MOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            Neon2MOFF = true;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////Neon3 TIMER /////////////////////////////////////////////////////////////
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

            if (Neon3_checkBox.Checked == true)
            {
                ACTIVATE_NEON3 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " NEON_3 Timer is activated \r\n";
            }
            else
            {
                ACTIVATE_NEON3 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " NEON_3 Timer is dis activated \r\n";
            }
        }
        private void comboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR ON Neon3
            Neon3HON_Label.BackColor = System.Drawing.Color.DarkOrange;
            Neon3HON = true;
        }
        private void comboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN ON Neon3
            Neon3MON_Label.BackColor = System.Drawing.Color.DarkOrange;
            Neon3MON = true;
        }
        private void comboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR OFF Neon3
            Neon3HOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            Neon3HOFF = true;
        }
        private void comboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN OFF Neon3
            Neon3MOFF_Label.BackColor = System.Drawing.Color.DarkOrange;
            Neon3MOFF = true;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////Night1 TIMER /////////////////////////////////////////////////////////////
        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

            if (Night1_checkBox.Checked == true)
            {
                ACTIVATE_NIGHT1 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " NIGHT_1 Timer is activated \r\n";
            }
            else
            {
                ACTIVATE_NIGHT1 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " NIGHT_1 Timer is dis activated \r\n";
            }
        }
        private void comboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR ON Night1
            label65.BackColor = System.Drawing.Color.DarkOrange;
            Night1HON = true;
        }
        private void comboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN ON Night1
            label69.BackColor = System.Drawing.Color.DarkOrange;
            Night1MON = true;
        }
        private void comboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR OFF Night1
            label68.BackColor = System.Drawing.Color.DarkOrange;
            Night1HOFF = true;
        }
        private void comboBox44_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN OFF Night1
            label67.BackColor = System.Drawing.Color.DarkOrange;
            Night1MOFF = true;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////Uv1 TIMER /////////////////////////////////////////////////////////////
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

            if (Uv1_checkBox.Checked == true)
            {
                ACTIVATE_UV1 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Uv STERILIZER 1 Timer is activated \r\n";
            }
            else
            {
                ACTIVATE_UV1 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Uv STERILIZER 1 Timer is dis activated \r\n";
            }
        }
        private void comboBox53_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR ON Uv1
            label82.BackColor = System.Drawing.Color.DarkOrange;
            Uv1HON = true;
        }
        private void comboBox52_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN ON Uv1
            label85.BackColor = System.Drawing.Color.DarkOrange;
            Uv1MON = true;
        }
        private void comboBox51_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR OFF Uv1
            label83.BackColor = System.Drawing.Color.DarkOrange;
            Uv1HOFF = true;
        }
        private void comboBox54_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN OFF Uv1
            label86.BackColor = System.Drawing.Color.DarkOrange;
            Uv1MOFF = true;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////Uv2 TIMER /////////////////////////////////////////////////////////////
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

            if (Uv2_checkBox.Checked == true)
            {
                ACTIVATE_UV2 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Uv STERILIZER 2 Timer is activated \r\n";
            }
            else
            {
                ACTIVATE_UV2 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Uv STERILIZER 2 Timer is dis activated \r\n";
            }
        }
        private void comboBox56_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR ON Uv2
            label88.BackColor = System.Drawing.Color.DarkOrange;
            Uv2HON = true;
        }
        private void comboBox57_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN ON Uv2
            label89.BackColor = System.Drawing.Color.DarkOrange;
            Uv2MON = true;
        }
        private void comboBox58_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HOUR OFF Uv2
            label90.BackColor = System.Drawing.Color.DarkOrange;
            Uv2HOFF = true;
        }
        private void comboBox59_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MIN OFF Uv2
            label91.BackColor = System.Drawing.Color.DarkOrange;
            Uv2MOFF = true;
        }
        /////////////////////////////RGB CH1 ////////////////////////////////////////////////////////////
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Concat("", trackBar5.Value);
            RGB_COLOR1_panel52();
            RED1 = true;
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label2.Text = String.Concat("", trackBar4.Value);
            RGB_COLOR1_panel52();
            GREEN1 = true;
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = String.Concat("", trackBar3.Value);
            RGB_COLOR1_panel52();
            BLUE1 = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                ACTIVATE_RGB1 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH1 activated \r\n";
                label76.BackColor = System.Drawing.Color.DarkOrange;
                ACTIVATE_RGB1 = true;
            }
            else
            {
                ACTIVATE_RGB1 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH1 disactivated \r\n";
                label76.BackColor = System.Drawing.Color.DarkGray;
                ACTIVATE_RGB1 = false;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////RGB CH2 ////////////////////////////////////////////////////////////
        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label31.Text = String.Concat("", trackBar6.Value);
            RED2 = true;
            RGB_COLOR2_panel54();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label30.Text = String.Concat("", trackBar1.Value);
            GREEN2 = true;
            RGB_COLOR2_panel54();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label4.Text = String.Concat("", trackBar2.Value);
            BLUE2 = true;
            RGB_COLOR2_panel54();
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            //textBox2.BackColor = System.Drawing.Color.DarkOrange;

            if (checkBox8.Checked == true)
            {
                ACTIVATE_RGB2 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH2 activated \r\n";
                label81.BackColor = System.Drawing.Color.DarkOrange;
                ACTIVATE_RGB2 = true;
            }
            else
            {
                ACTIVATE_RGB2 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH2 disactivated \r\n";
                label81.BackColor = System.Drawing.Color.White;
                ACTIVATE_RGB2 = false;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////RGB CH3///////////////////////////////////////////////////////////

        private void trackBar13_Scroll(object sender, EventArgs e)
        {
            label34.Text = String.Concat("", trackBar13.Value);
            RED3 = true;
            RGB_COLOR3_panel53();
        }
        private void trackBar11_Scroll(object sender, EventArgs e)
        {
            label33.Text = String.Concat("", trackBar11.Value);
            GREEN3 = true;
            RGB_COLOR3_panel53();
        }
        private void trackBar12_Scroll(object sender, EventArgs e)
        {
            label32.Text = String.Concat("", trackBar12.Value);
            BLUE3 = true;
            RGB_COLOR3_panel53();
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            //	textBox3.BackColor = System.Drawing.Color.DarkOrange;
            if (checkBox9.Checked == true)
            {
                ACTIVATE_RGB3 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH3 activated \r\n";
                label77.BackColor = System.Drawing.Color.DarkOrange;
                ACTIVATE_RGB3 = true;
            }
            else
            {
                ACTIVATE_RGB3 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH3 disactivated \r\n";
                label77.BackColor = System.Drawing.Color.White;
                ACTIVATE_RGB3 = false;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////RGB CH4///////////////////////////////////////////////////////////
        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            label37.Text = String.Concat("", trackBar9.Value);
            RED4 = true;
            RGB_COLOR4_panel55();
        }
        private void trackBar10_Scroll(object sender, EventArgs e)
        {
            label36.Text = String.Concat("", trackBar10.Value);
            GREEN4 = true;
            RGB_COLOR4_panel55();
        }
        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            label35.Text = String.Concat("", trackBar8.Value);
            BLUE4 = true;
            RGB_COLOR4_panel55();
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            // textBox4.BackColor = System.Drawing.Color.DarkOrange;
            if (checkBox10.Checked == true)
            {
                ACTIVATE_RGB4 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH4 activated \r\n";
                label78.BackColor = System.Drawing.Color.DarkOrange;
                ACTIVATE_RGB4 = true;
            }
            else
            {
                ACTIVATE_RGB4 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH4 disactivated \r\n";
                label78.BackColor = System.Drawing.Color.White;
                ACTIVATE_RGB4 = false;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void RGB_COLOR1_panel52()
        {

            mRed1 = trackBar5.Value;
            mGreen1 = trackBar4.Value;
            mBlue1 = trackBar3.Value;
            panel52.BackColor = System.Drawing.Color.FromArgb(mRed1, mGreen1, mBlue1);

        }
        private void RGB_COLOR2_panel54()
        {

            mRed2 = trackBar6.Value;
            mGreen2 = trackBar1.Value;
            mBlue2 = trackBar2.Value;
            panel54.BackColor = System.Drawing.Color.FromArgb(mRed2, mGreen2, mBlue2);

        }
        private void RGB_COLOR3_panel53()
        {

            mRed3 = trackBar13.Value;
            mGreen3 = trackBar11.Value;
            mBlue3 = trackBar12.Value;
            panel53.BackColor = System.Drawing.Color.FromArgb(mRed3, mGreen3, mBlue3);

        }
        private void RGB_COLOR4_panel55()
        {

            mRed4 = trackBar9.Value;
            mGreen4 = trackBar10.Value;
            mBlue4 = trackBar8.Value;
            panel55.BackColor = System.Drawing.Color.FromArgb(mRed4, mGreen4, mBlue4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RGB_config_info();

        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            DEBUG = true;
            NORMAL_MODE = false;
            richTextBox1.Text += (DateTime.Now);
            richTextBox1.Text += ("  ");
            richTextBox1.Text += " RGB Led channels test mode activated \r\n";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            DEBUG = false;
            NORMAL_MODE = true;
            richTextBox1.Text += (DateTime.Now);
            richTextBox1.Text += ("  ");
            richTextBox1.Text += " RGB Led channels normal mode activated  \r\n";
        }

        private void comboBox49_SelectedIndexChanged(object sender, EventArgs e)
        {
            label75.BackColor = System.Drawing.Color.DarkOrange;
            LED_TEST_DELAY = true;
            richTextBox1.Text += (DateTime.Now);
            richTextBox1.Text += ("  ");
            richTextBox1.Text += " RGB Led test delay set to ";
            richTextBox1.Text += (comboBox49.Text);
            richTextBox1.Text += " milliseconds  \r\n";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //IniFile ini = new IniFile("config/rgb.ini");
            //  ini.IniWriteValue("RGB3", "Red","DGSDG");
            Load_Saved_RGB_Settings();
        }


        private void Generate_timers_config_file()
        {

            ///////GENETATE GENERAL STATUS OF ALL TIMERS IN ONE FILE NAMED TIMSTS.txt////////////////////////////////////////////////


            IniFile ini = new IniFile("config/timers.ini");// Create general file for all timer values CHGA 29/8/2016 

            ini.IniWriteValue("Info Timers", "File info ", "//File format created by Charles Galea 2018.");
            ini.IniWriteValue("Info Timers", "File Created ", DateTime.Now.ToString());
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (ACTIVATE_SUNRISE)
            {


                String hourOn1 = comboBox16.Text;
                ini.IniWriteValue("Sunrise", "hourOn1", hourOn1);
                this.progressBar1.Increment(25);

                String minOn1 = comboBox13.Text;
                ini.IniWriteValue("Sunrise", "minOn1", minOn1);
                this.progressBar1.Increment(25);

                String hourOff1 = comboBox14.Text;
                ini.IniWriteValue("Sunrise", "hourOff1", hourOff1);
                this.progressBar1.Increment(25);

                String minOff1 = comboBox15.Text;
                ini.IniWriteValue("Sunrise", "minOff1", minOff1);
                this.progressBar1.Increment(25);

                String srdur = comboBox1.Text;
                ini.IniWriteValue("Sunrise", "duration", srdur);
                this.progressBar1.Increment(25);

                ////////UDP String GEneration

                UDP_Timers_Digit_00 = 'A'; // A = UDP TIMER PARAMETER 
                UDP_STRING_COMBINED[0] = UDP_Timers_Digit_00.ToString(); //UDP Fitst Letter set to A : 

                UDP_Timers_Digit_01 = 1; // 1 = SUNRISE TIMER PARAMETER
                UDP_STRING_COMBINED[1] = UDP_Timers_Digit_01.ToString();//UDP TIMER number 1 in UDP String 2nd Character after A


                UDP_STRING_COMBINED[2] = hourOn1.ToString(); //UDP TIMER hourOn value

                UDP_STRING_COMBINED[3] = minOn1.ToString();//UDP TIMER minOn value

                UDP_STRING_COMBINED[4] = hourOff1.ToString();//UDP TIMER hourOff value

                UDP_STRING_COMBINED[5] = minOff1.ToString();//UDP TIMER minOff value

                UDP_STRING_COMBINED[6] = srdur.ToString();//UDP TIMER duration value
                UDP_STRING_COMBINED[7] = "0".ToString();//UDP TIMER fill SPARE last value with 0

                String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED);//UDP join all values to one string
                var builder = new StringBuilder();
                Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
                var result = String.Join(":", UDP_STRING_COMBINED.ToArray());//Result contains the NEW String with Deliminer


                ini.IniWriteValue("Sunrise", "Status", "true");

                ini.IniWriteValue("Sunrise", "UDP_PACKET", result);//UDP string Write in Config file

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Sunrise files generated succesfully \r\n";



            }

            else
            {

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Sunrise Timer is DISABLED \r\n";
                ini.IniWriteValue("Sunrise", "Status", "false");
                ini.IniWriteValue("Sunrise", "hourOn1", "0");
                ini.IniWriteValue("Sunrise", "minOn1", "0");
                ini.IniWriteValue("Sunrise", "hourOff1", "0");
                ini.IniWriteValue("Sunrise", "minOff1", "0");
                ini.IniWriteValue("Sunrise", "duration", "0");
                ini.IniWriteValue("Sunrise", "UDP_PACKET", EMPTY_UDP);
            }

            if (ACTIVATE_SUNSET)
            {



                String hourOn1 = comboBox8.Text;
                ini.IniWriteValue("Sunset", "hourOn1", hourOn1);
                this.progressBar1.Increment(25);

                String minOn1 = comboBox5.Text;
                ini.IniWriteValue("Sunset", "minOn1", minOn1);
                this.progressBar1.Increment(25);

                String hourOff1 = comboBox6.Text;
                ini.IniWriteValue("Sunset", "hourOff1", hourOff1);
                this.progressBar1.Increment(25);

                String minOff1 = comboBox7.Text;
                ini.IniWriteValue("Sunset", "minOff1", minOff1);
                this.progressBar1.Increment(25);

                String srdur = comboBox2.Text;
                ini.IniWriteValue("Sunset", "duration", srdur);
                this.progressBar1.Increment(25);

                ////////UDP String GEneration

                UDP_Timers_Digit_00 = 'A'; // A = UDP TIMER PARAMETER 
                UDP_STRING_COMBINED[0] = UDP_Timers_Digit_00.ToString(); //UDP Fitst Letter set to A : 

                UDP_Timers_Digit_01 = 2; // 2 = SUNSET TIMER PARAMETER
                UDP_STRING_COMBINED[1] = UDP_Timers_Digit_01.ToString();//UDP TIMER number 1 in UDP String 2nd Character after A


                UDP_STRING_COMBINED[2] = hourOn1.ToString(); //UDP TIMER hourOn value

                UDP_STRING_COMBINED[3] = minOn1.ToString();//UDP TIMER minOn value

                UDP_STRING_COMBINED[4] = hourOff1.ToString();//UDP TIMER hourOff value

                UDP_STRING_COMBINED[5] = minOff1.ToString();//UDP TIMER minOff value

                UDP_STRING_COMBINED[6] = srdur.ToString();//UDP TIMER duration value
                UDP_STRING_COMBINED[7] = "0".ToString();//UDP TIMER fill SPARE last value with 0

                String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED);//UDP join all values to one string
                var builder = new StringBuilder();
                Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
                var result = String.Join(":", UDP_STRING_COMBINED.ToArray());//Result contains the NEW String with Deliminer

                ////UDP String Creation Ends  

                ini.IniWriteValue("Sunset", "Status", "true");
                ini.IniWriteValue("Sunset", "UDP_PACKET", result);//UDP string Write in Config file
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Sunset files generated succesfully \r\n";

            }

            else
            {
                ini.IniWriteValue("Sunset", "Status", "false");
                ini.IniWriteValue("Sunset", "Status", "false");
                ini.IniWriteValue("Sunset", "hourOn1", "0");
                ini.IniWriteValue("Sunset", "minOn1", "0");
                ini.IniWriteValue("Sunset", "hourOff1", "0");
                ini.IniWriteValue("Sunset", "minOff1", "0");
                ini.IniWriteValue("Sunset", "duration", "0");
                ini.IniWriteValue("Sunset", "UDP_PACKET", EMPTY_UDP);
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Sunset Timer is DISABLED \r\n";

            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////GENERATE DAY 1 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
            if (ACTIVATE_DAY1)
            {


                String hourOn1 = comboBox11.Text;
                ini.IniWriteValue("Day 1", "hourOn1", hourOn1);
                this.progressBar1.Increment(25);

                String minOn1 = comboBox10.Text;
                ini.IniWriteValue("Day 1", "minOn1", minOn1);
                this.progressBar1.Increment(25);

                String hourOff1 = comboBox9.Text;
                ini.IniWriteValue("Day 1", "hourOff1", hourOff1);
                this.progressBar1.Increment(25);

                String minOff1 = comboBox12.Text;
                ini.IniWriteValue("Day 1", "minOff1", minOff1);
                this.progressBar1.Increment(25);

                ////////UDP String GEneration

                UDP_Timers_Digit_00 = 'A'; // A = UDP TIMER PARAMETER 
                UDP_STRING_COMBINED[0] = UDP_Timers_Digit_00.ToString(); //UDP Fitst Letter set to A : 

                UDP_Timers_Digit_01 = 3; // 3 = DAY1 TIMER PARAMETER
                UDP_STRING_COMBINED[1] = UDP_Timers_Digit_01.ToString();//UDP TIMER number 1 in UDP String 2nd Character after A


                UDP_STRING_COMBINED[2] = hourOn1.ToString(); //UDP TIMER hourOn value

                UDP_STRING_COMBINED[3] = minOn1.ToString();//UDP TIMER minOn value

                UDP_STRING_COMBINED[4] = hourOff1.ToString();//UDP TIMER hourOff value

                UDP_STRING_COMBINED[5] = minOff1.ToString();//UDP TIMER minOff value

                UDP_STRING_COMBINED[6] = "0".ToString();//UDP TIMER duration value not applicable to this timer type
                UDP_STRING_COMBINED[7] = "0".ToString();//UDP TIMER fill SPARE last value with 0

                String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED);//UDP join all values to one string
                var builder = new StringBuilder();
                Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
                var result = String.Join(":", UDP_STRING_COMBINED.ToArray());//Result contains the NEW String with Deliminer

                ////UDP String Creation Ends  
                ini.IniWriteValue("Day 1", "Status", "true");
                ini.IniWriteValue("Day 1", "UDP_PACKET", result);//UDP string Write in Config file
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 1 files generated succesfully \r\n";

            }

            else
            {
                ini.IniWriteValue("Day 1", "Status", "false");
                ini.IniWriteValue("Day 1", "hourOn1", "0");
                ini.IniWriteValue("Day 1", "minOn1", "0");
                ini.IniWriteValue("Day 1", "hourOff1", "0");
                ini.IniWriteValue("Day 1", "minOff1", "0");
                ini.IniWriteValue("Day 1", "UDP_PACKET", EMPTY_UDP);
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 1 Timer is DISABLED \r\n";

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////GENERATE DAY 2 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
            if (ACTIVATE_DAY2)
            {

                String hourOn1 = comboBox22.Text;
                ini.IniWriteValue("Day 2", "hourOn1", hourOn1);
                this.progressBar1.Increment(25);

                String minOn1 = comboBox23.Text;
                ini.IniWriteValue("Day 2", "minOn1", minOn1);
                this.progressBar1.Increment(25);

                String hourOff1 = comboBox21.Text;
                ini.IniWriteValue("Day 2", "hourOff1", hourOff1);
                this.progressBar1.Increment(25);

                String minOff1 = comboBox24.Text;
                ini.IniWriteValue("Day 2", "minOff1", minOff1);
                this.progressBar1.Increment(25);
                ////////UDP String GEneration

                UDP_Timers_Digit_00 = 'A'; // A = UDP TIMER PARAMETER 
                UDP_STRING_COMBINED[0] = UDP_Timers_Digit_00.ToString(); //UDP Fitst Letter set to A : 

                UDP_Timers_Digit_01 = 4; // 4 = DAY2 TIMER PARAMETER
                UDP_STRING_COMBINED[1] = UDP_Timers_Digit_01.ToString();//UDP TIMER number 1 in UDP String 2nd Character after A


                UDP_STRING_COMBINED[2] = hourOn1.ToString(); //UDP TIMER hourOn value

                UDP_STRING_COMBINED[3] = minOn1.ToString();//UDP TIMER minOn value

                UDP_STRING_COMBINED[4] = hourOff1.ToString();//UDP TIMER hourOff value

                UDP_STRING_COMBINED[5] = minOff1.ToString();//UDP TIMER minOff value

                UDP_STRING_COMBINED[6] = "0".ToString();//UDP TIMER duration value not applicable to this timer type
                UDP_STRING_COMBINED[7] = "0".ToString();//UDP TIMER fill SPARE last value with 0

                String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED);//UDP join all values to one string
                var builder = new StringBuilder();
                Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
                var result = String.Join(":", UDP_STRING_COMBINED.ToArray());//Result contains the NEW String with Deliminer

                ////UDP String Creation Ends  
                ini.IniWriteValue("Day 2", "Status", "true");
                ini.IniWriteValue("Day 2", "UDP_PACKET", result);//UDP string Write in Config file


                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Day 2 files generated succesfully \r\n";

            }

            else
            {
                ini.IniWriteValue("Day 2", "Status", "false");
                ini.IniWriteValue("Day 2", "hourOn1", "0");
                ini.IniWriteValue("Day 2", "minOn1", "0");
                ini.IniWriteValue("Day 2", "hourOff1", "0");
                ini.IniWriteValue("Day 2", "minOff1", "0");
                ini.IniWriteValue("Day 2", "UDP_PACKET", EMPTY_UDP);

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Day 2 Timer is DISABLED \r\n";

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ///////////////////////////////GENERATE DAY 3 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
            if (ACTIVATE_DAY3)
            {

                String hourOn1 = comboBox18.Text;
                ini.IniWriteValue("Day 3", "hourOn1", hourOn1);
                this.progressBar1.Increment(25);

                String minOn1 = comboBox19.Text;
                ini.IniWriteValue("Day 3", "minOn1", minOn1);
                this.progressBar1.Increment(25);

                String hourOff1 = comboBox17.Text;
                ini.IniWriteValue("Day 3", "hourOff1", hourOff1);
                this.progressBar1.Increment(25);

                String minOff1 = comboBox20.Text;
                ini.IniWriteValue("Day 3", "minOff1", minOff1);
                this.progressBar1.Increment(25);
                ////////UDP String GEneration

                UDP_Timers_Digit_00 = 'A'; // A = UDP TIMER PARAMETER 
                UDP_STRING_COMBINED[0] = UDP_Timers_Digit_00.ToString(); //UDP Fitst Letter set to A : 

                UDP_Timers_Digit_01 = 5; // 5 = DAY3 TIMER PARAMETER
                UDP_STRING_COMBINED[1] = UDP_Timers_Digit_01.ToString();//UDP TIMER number 1 in UDP String 2nd Character after A


                UDP_STRING_COMBINED[2] = hourOn1.ToString(); //UDP TIMER hourOn value

                UDP_STRING_COMBINED[3] = minOn1.ToString();//UDP TIMER minOn value

                UDP_STRING_COMBINED[4] = hourOff1.ToString();//UDP TIMER hourOff value

                UDP_STRING_COMBINED[5] = minOff1.ToString();//UDP TIMER minOff value

                UDP_STRING_COMBINED[6] = "0".ToString();//UDP TIMER duration value not applicable to this timer type
                UDP_STRING_COMBINED[7] = "0".ToString();//UDP TIMER fill SPARE last value with 0

                String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED);//UDP join all values to one string
                var builder = new StringBuilder();
                Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
                var result = String.Join(":", UDP_STRING_COMBINED.ToArray());//Result contains the NEW String with Deliminer

                ////UDP String Creation Ends  
                ini.IniWriteValue("Day 3", "Status", "true");
                ini.IniWriteValue("Day 3", "UDP_PACKET", result);//UDP string Write in Config file


                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Day 3 files generated succesfully \r\n";

            }

            else
            {
                ini.IniWriteValue("Day 3", "Status", "false");
                ini.IniWriteValue("Day 3", "hourOn1", "0");
                ini.IniWriteValue("Day 3", "minOn1", "0");
                ini.IniWriteValue("Day 3", "hourOff1", "0");
                ini.IniWriteValue("Day 3", "minOff1", "0");
                ini.IniWriteValue("Day 3", "UDP_PACKET", EMPTY_UDP);
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Day 3 Timer is DISABLED \r\n";

            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////GENERATE NEON_1 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
            if (ACTIVATE_NEON1)
            {

                String hourOn1 = comboBox34.Text;
                ini.IniWriteValue("Neon 1", "hourOn1", hourOn1);
                this.progressBar1.Increment(25);

                String minOn1 = comboBox35.Text;
                ini.IniWriteValue("Neon 1", "minOn1", minOn1);
                this.progressBar1.Increment(25);

                String hourOff1 = comboBox33.Text;
                ini.IniWriteValue("Neon 1", "hourOff1", hourOff1);
                this.progressBar1.Increment(25);

                String minOff1 = comboBox36.Text;
                ini.IniWriteValue("Neon 1", "minOff1", minOff1);
                this.progressBar1.Increment(25);
                ////////UDP String GEneration

                UDP_Timers_Digit_00 = 'A'; // A = UDP TIMER PARAMETER 
                UDP_STRING_COMBINED[0] = UDP_Timers_Digit_00.ToString(); //UDP Fitst Letter set to A : 

                UDP_Timers_Digit_01 = 6; // 6 = NEON1 TIMER PARAMETER
                UDP_STRING_COMBINED[1] = UDP_Timers_Digit_01.ToString();//UDP TIMER number 1 in UDP String 2nd Character after A


                UDP_STRING_COMBINED[2] = hourOn1.ToString(); //UDP TIMER hourOn value

                UDP_STRING_COMBINED[3] = minOn1.ToString();//UDP TIMER minOn value

                UDP_STRING_COMBINED[4] = hourOff1.ToString();//UDP TIMER hourOff value

                UDP_STRING_COMBINED[5] = minOff1.ToString();//UDP TIMER minOff value

                UDP_STRING_COMBINED[6] = "0".ToString();//UDP TIMER duration value not applicable to this timer type
                UDP_STRING_COMBINED[7] = "0".ToString();//UDP TIMER fill SPARE last value with 0

                String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED);//UDP join all values to one string
                var builder = new StringBuilder();
                Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
                var result = String.Join(":", UDP_STRING_COMBINED.ToArray());//Result contains the NEW String with Deliminer

                ////UDP String Creation Ends  
                ini.IniWriteValue("Neon 1", "Status", "true");
                ini.IniWriteValue("Neon 1", "UDP_PACKET", result);//UDP string Write in Config file


                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Neon 1 files generated succesfully \r\n";

            }

            else
            {
                ini.IniWriteValue("Neon 1", "Status", "false");
                ini.IniWriteValue("Neon 1", "hourOn1", "0");
                ini.IniWriteValue("Neon 1", "minOn1", "0");
                ini.IniWriteValue("Neon 1", "hourOff1", "0");
                ini.IniWriteValue("Neon 1", "minOff1", "0");
                ini.IniWriteValue("Neon 1", "UDP_PACKET", EMPTY_UDP);
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Neon 1 Timer is DISABLED \r\n";

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////GENERATE NEON_2 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
            if (ACTIVATE_NEON2)
            {

                String hourOn1 = comboBox46.Text;
                ini.IniWriteValue("Neon 2", "hourOn1", hourOn1);
                this.progressBar1.Increment(25);

                String minOn1 = comboBox47.Text;
                ini.IniWriteValue("Neon 2", "minOn1", minOn1);
                this.progressBar1.Increment(25);

                String hourOff1 = comboBox45.Text;
                ini.IniWriteValue("Neon 2", "hourOff1", hourOff1);
                this.progressBar1.Increment(25);

                String minOff1 = comboBox48.Text;
                ini.IniWriteValue("Neon 2", "minOff1", minOff1);
                this.progressBar1.Increment(25);
                ////////UDP String GEneration

                UDP_Timers_Digit_00 = 'A'; // A = UDP TIMER PARAMETER 
                UDP_STRING_COMBINED[0] = UDP_Timers_Digit_00.ToString(); //UDP Fitst Letter set to A : 

                UDP_Timers_Digit_01 = 7; // 7 = NEON2 TIMER PARAMETER
                UDP_STRING_COMBINED[1] = UDP_Timers_Digit_01.ToString();//UDP TIMER number 1 in UDP String 2nd Character after A


                UDP_STRING_COMBINED[2] = hourOn1.ToString(); //UDP TIMER hourOn value

                UDP_STRING_COMBINED[3] = minOn1.ToString();//UDP TIMER minOn value

                UDP_STRING_COMBINED[4] = hourOff1.ToString();//UDP TIMER hourOff value

                UDP_STRING_COMBINED[5] = minOff1.ToString();//UDP TIMER minOff value

                UDP_STRING_COMBINED[6] = "0".ToString();//UDP TIMER duration value not applicable to this timer type
                UDP_STRING_COMBINED[7] = "0".ToString();//UDP TIMER fill SPARE last value with 0

                String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED);//UDP join all values to one string
                var builder = new StringBuilder();
                Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
                var result = String.Join(":", UDP_STRING_COMBINED.ToArray());//Result contains the NEW String with Deliminer

                ////UDP String Creation Ends  
                ini.IniWriteValue("Neon 2", "Status", "true");
                ini.IniWriteValue("Neon 2", "UDP_PACKET", result);//UDP string Write in Config file

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Neon 2 files generated succesfully \r\n";

            }

            else
            {
                ini.IniWriteValue("Neon 2", "Status", "false");
                ini.IniWriteValue("Neon 2", "hourOn1", "0");
                ini.IniWriteValue("Neon 2", "minOn1", "0");
                ini.IniWriteValue("Neon 2", "hourOff1", "0");
                ini.IniWriteValue("Neon 2", "minOff1", "0");
                ini.IniWriteValue("Neon 2", "UDP_PACKET", EMPTY_UDP);

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Neon 2 Timer is DISABLED \r\n";

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////GENERATE NEON_3 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
            if (ACTIVATE_NEON3 == true)
            {

                String hourOn1 = comboBox38.Text;
                ini.IniWriteValue("Neon 3", "hourOn1", hourOn1);
                this.progressBar1.Increment(25);

                String minOn1 = comboBox39.Text;
                ini.IniWriteValue("Neon 3", "minOn1", minOn1);
                this.progressBar1.Increment(25);

                String hourOff1 = comboBox37.Text;
                ini.IniWriteValue("Neon 3", "hourOff1", hourOff1);
                this.progressBar1.Increment(25);

                String minOff1 = comboBox40.Text;
                ini.IniWriteValue("Neon 3", "minOff1", minOff1);
                this.progressBar1.Increment(25);

                ////////UDP String GEneration

                UDP_Timers_Digit_00 = 'A'; // A = UDP TIMER PARAMETER 
                UDP_STRING_COMBINED[0] = UDP_Timers_Digit_00.ToString(); //UDP Fitst Letter set to A : 

                UDP_Timers_Digit_01 = 8; // 8 = NEON3 TIMER PARAMETER
                UDP_STRING_COMBINED[1] = UDP_Timers_Digit_01.ToString();//UDP TIMER number 1 in UDP String 2nd Character after A


                UDP_STRING_COMBINED[2] = hourOn1.ToString(); //UDP TIMER hourOn value

                UDP_STRING_COMBINED[3] = minOn1.ToString();//UDP TIMER minOn value

                UDP_STRING_COMBINED[4] = hourOff1.ToString();//UDP TIMER hourOff value

                UDP_STRING_COMBINED[5] = minOff1.ToString();//UDP TIMER minOff value

                UDP_STRING_COMBINED[6] = "0".ToString();//UDP TIMER duration value not applicable to this timer type
                UDP_STRING_COMBINED[7] = "0".ToString();//UDP TIMER fill SPARE last value with 0

                String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED);//UDP join all values to one string
                var builder = new StringBuilder();
                Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
                var result = String.Join(":", UDP_STRING_COMBINED.ToArray());//Result contains the NEW String with Deliminer

                ////UDP String Creation Ends  
                ini.IniWriteValue("Neon 3", "Status", "true");
                ini.IniWriteValue("Neon 3", "UDP_PACKET", result);//UDP string Write in Config file

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Neon 3 files generated succesfully \r\n";

            }

            else
            {
                ini.IniWriteValue("Neon 3", "Status", "false");
                ini.IniWriteValue("Neon 3", "hourOn1", "0");
                ini.IniWriteValue("Neon 3", "minOn1", "0");
                ini.IniWriteValue("Neon 3", "hourOff1", "0");
                ini.IniWriteValue("Neon 3", "minOff1", "0");
                ini.IniWriteValue("Neon 3", "UDP_PACKET", EMPTY_UDP);

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Neon 3 Timer is DISABLED \r\n";

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////GENERATE NIGHT_1 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
            if (ACTIVATE_NIGHT1)
            {

                String hourOn1 = comboBox42.Text;
                ini.IniWriteValue("Night 1", "hourOn1", hourOn1);
                this.progressBar1.Increment(25);

                String minOn1 = comboBox43.Text;
                ini.IniWriteValue("Night 1", "minOn1", minOn1);
                this.progressBar1.Increment(25);

                String hourOff1 = comboBox41.Text;
                ini.IniWriteValue("Night 1", "hourOff1", hourOff1);
                this.progressBar1.Increment(25);

                String minOff1 = comboBox44.Text;
                ini.IniWriteValue("Night 1", "minOff1", minOff1);
                this.progressBar1.Increment(25);

                ////////UDP String GEneration

                UDP_Timers_Digit_00 = 'A'; // A = UDP TIMER PARAMETER 
                UDP_STRING_COMBINED[0] = UDP_Timers_Digit_00.ToString(); //UDP Fitst Letter set to A : 

                UDP_Timers_Digit_01 = 9; // 9 = NIGHT1 TIMER PARAMETER
                UDP_STRING_COMBINED[1] = UDP_Timers_Digit_01.ToString();//UDP TIMER number 1 in UDP String 2nd Character after A


                UDP_STRING_COMBINED[2] = hourOn1.ToString(); //UDP TIMER hourOn value

                UDP_STRING_COMBINED[3] = minOn1.ToString();//UDP TIMER minOn value

                UDP_STRING_COMBINED[4] = hourOff1.ToString();//UDP TIMER hourOff value

                UDP_STRING_COMBINED[5] = minOff1.ToString();//UDP TIMER minOff value

                UDP_STRING_COMBINED[6] = "0".ToString();//UDP TIMER duration value not applicable to this timer type
                UDP_STRING_COMBINED[7] = "0".ToString();//UDP TIMER fill SPARE last value with 0

                String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED);//UDP join all values to one string
                var builder = new StringBuilder();
                Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
                var result = String.Join(":", UDP_STRING_COMBINED.ToArray());//Result contains the NEW String with Deliminer

                ////UDP String Creation Ends  
                ini.IniWriteValue("Night 1", "Status", "true");
                ini.IniWriteValue("Night 1", "UDP_PACKET", result);//UDP string Write in Config file

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Night 1 files generated succesfully \r\n";

            }

            else
            {
                ini.IniWriteValue("Night 1", "Status", "false");
                ini.IniWriteValue("Night 1", "hourOn1", "0");
                ini.IniWriteValue("Night 1", "minOn1", "0");
                ini.IniWriteValue("Night 1", "hourOff1", "0");
                ini.IniWriteValue("Night 1", "minOff1", "0");
                ini.IniWriteValue("Night 1", "UDP_PACKET", EMPTY_UDP);

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Night 1 Timer is DISABLED \r\n";

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////GENERATE UV_1 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
            if (ACTIVATE_UV1)
            {

                String hourOn1 = comboBox53.Text;
                ini.IniWriteValue("UV Light 1", "hourOn1", hourOn1);
                this.progressBar1.Increment(25);

                String minOn1 = comboBox52.Text;
                ini.IniWriteValue("UV Light 1", "minOn1", minOn1);
                this.progressBar1.Increment(25);

                String hourOff1 = comboBox51.Text;
                ini.IniWriteValue("UV Light 1", "hourOff1", hourOff1);
                this.progressBar1.Increment(25);

                String minOff1 = comboBox54.Text;
                ini.IniWriteValue("UV Light 1", "minOff1", minOff1);
                this.progressBar1.Increment(25);

                ////////UDP String GEneration

                UDP_Timers_Digit_00 = 'A'; // A = UDP TIMER PARAMETER 
                UDP_STRING_COMBINED[0] = UDP_Timers_Digit_00.ToString(); //UDP Fitst Letter set to A : 

                UDP_Timers_Digit_01 = 10; // 10 = UV Light 1 TIMER PARAMETER
                UDP_STRING_COMBINED[1] = UDP_Timers_Digit_01.ToString();//UDP TIMER number 1 in UDP String 2nd Character after A


                UDP_STRING_COMBINED[2] = hourOn1.ToString(); //UDP TIMER hourOn value

                UDP_STRING_COMBINED[3] = minOn1.ToString();//UDP TIMER minOn value

                UDP_STRING_COMBINED[4] = hourOff1.ToString();//UDP TIMER hourOff value

                UDP_STRING_COMBINED[5] = minOff1.ToString();//UDP TIMER minOff value

                UDP_STRING_COMBINED[6] = "0".ToString();//UDP TIMER duration value not applicable to this timer type
                UDP_STRING_COMBINED[7] = "0".ToString();//UDP TIMER fill SPARE last value with 0

                String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED);//UDP join all values to one string
                var builder = new StringBuilder();
                Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
                var result = String.Join(":", UDP_STRING_COMBINED.ToArray());//Result contains the NEW String with Deliminer

                ////UDP String Creation Ends  
                ini.IniWriteValue("UV Light 1", "Status", "true");
                ini.IniWriteValue("UV Light 1", "UDP_PACKET", result);//UDP string Write in Config file

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "UV Light 1 files generated succesfully \r\n";

            }

            else
            {
                ini.IniWriteValue("UV Light 1", "Status", "false");
                ini.IniWriteValue("UV Light 1", "hourOn1", "0");
                ini.IniWriteValue("UV Light 1", "minOn1", "0");
                ini.IniWriteValue("UV Light 1", "hourOff1", "0");
                ini.IniWriteValue("UV Light 1", "minOff1", "0");
                ini.IniWriteValue("UV Light 1", "UDP_PACKET", EMPTY_UDP);

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "UV Light 1 Timer is DISABLED \r\n";

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////GENERATE Uv_2TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
            if (ACTIVATE_UV2)
            {

                String hourOn1 = comboBox56.Text;
                ini.IniWriteValue("UV Light 2", "hourOn1", hourOn1);
                this.progressBar1.Increment(25);

                String minOn1 = comboBox57.Text;
                ini.IniWriteValue("UV Light 2", "minOn1", minOn1);
                this.progressBar1.Increment(25);

                String hourOff1 = comboBox58.Text;
                ini.IniWriteValue("UV Light 2", "hourOff1", hourOff1);
                this.progressBar1.Increment(25);

                String minOff1 = comboBox59.Text;
                ini.IniWriteValue("UV Light 2", "minOff1", minOff1);
                this.progressBar1.Increment(25);

                ////////UDP String GEneration

                UDP_Timers_Digit_00 = 'A'; // A = UDP TIMER PARAMETER 
                UDP_STRING_COMBINED[0] = UDP_Timers_Digit_00.ToString(); //UDP Fitst Letter set to A : 

                UDP_Timers_Digit_01 = 11; // 11 = UV Light 2 TIMER PARAMETER
                UDP_STRING_COMBINED[1] = UDP_Timers_Digit_01.ToString();//UDP TIMER number 1 in UDP String 2nd Character after A


                UDP_STRING_COMBINED[2] = hourOn1.ToString(); //UDP TIMER hourOn value

                UDP_STRING_COMBINED[3] = minOn1.ToString();//UDP TIMER minOn value

                UDP_STRING_COMBINED[4] = hourOff1.ToString();//UDP TIMER hourOff value

                UDP_STRING_COMBINED[5] = minOff1.ToString();//UDP TIMER minOff value

                UDP_STRING_COMBINED[6] = "0".ToString();//UDP TIMER duration value not applicable to this timer type
                UDP_STRING_COMBINED[7] = "0".ToString();//UDP TIMER fill SPARE last value with 0

                String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED);//UDP join all values to one string
                var builder = new StringBuilder();
                Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
                var result = String.Join(":", UDP_STRING_COMBINED.ToArray());//Result contains the NEW String with Deliminer

                ////UDP String Creation Ends  
                ini.IniWriteValue("UV Light 2", "Status", "true");
                ini.IniWriteValue("UV Light 2", "UDP_PACKET", result);//UDP string Write in Config file

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "UV Light 2 files generated succesfully \r\n";

            }

            else
            {
                ini.IniWriteValue("UV Light 2", "Status", "false");
                ini.IniWriteValue("UV Light 2", "hourOn1", "0");
                ini.IniWriteValue("UV Light 2", "minOn1", "0");
                ini.IniWriteValue("UV Light 2", "hourOff1", "0");
                ini.IniWriteValue("UV Light 2", "minOff1", "0");
                ini.IniWriteValue("UV Light 2", "UDP_PACKET", EMPTY_UDP);

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "UV Light 2 Timer is DISABLED \r\n";

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        }




        /*
        public void  GetUDP_Values(String[] AA )
        {

            String.Join(":", AA);
            var builder = new StringBuilder();
            Array.ForEach(AA, x => builder.Append(x));
            var result = String.Join(":", AA.ToArray());
           // return result.ToString();
        }

        */
        private void CreateUDP_Timers_String()
        {

            for (int i = 2; i <= 7; i++)// We start from location 1 , becasue location 0 already SET 

            {


                switch (i)
                {


                    // case 1:
                    //   UDP_STRING_COMBINED[i] = UDP_Timers_Digit_01.ToString();
                    // break;

                    case 2:
                        UDP_STRING_COMBINED[i] = UDP_Timers_Digit_02.ToString();
                        break;

                    case 3:
                        UDP_STRING_COMBINED[i] = UDP_Timers_Digit_03.ToString();
                        break;

                    case 4:
                        UDP_STRING_COMBINED[i] = UDP_Timers_Digit_04.ToString();
                        break;

                    case 5:
                        UDP_STRING_COMBINED[i] = UDP_Timers_Digit_05.ToString();
                        break;

                    case 6:
                        UDP_STRING_COMBINED[i] = UDP_Timers_Digit_06.ToString();
                        break;
                    case 7:
                        UDP_STRING_COMBINED[i] = UDP_Timers_Digit_07.ToString();
                        break;
                }


            }

            string.Join(":", UDP_STRING_COMBINED);
            var builder = new StringBuilder();
            Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
            var result = String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED.ToArray());
            richTextBox2.Text += result;
            /*
            for (int i = 0; i <= 7; i++)

            {
                if (i == 7) {
                    richTextBox2.Text += UDP_STRING_COMBINED[i].ToString();
                    
                }

                else
                {
                    richTextBox2.Text += UDP_STRING_COMBINED[i];
                    richTextBox2.Text += UDP_DELIMINER.ToString();
                }
            }
            */
            richTextBox1.Text += "String GEnerated \r\n";

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (RTC_checkBox.Checked == true)
            {
                RTC_ACTIVATE = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RTC Update activated \r\n";
            }
            else
            {
                RTC_ACTIVATE = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RTC Update dis activated \r\n";
            }

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (SLAVEADD_checkBox.Checked == true)
            {


                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " SLAVE ADDRESS  Update activated \r\n";
                SLAVE_ADD_ACTIVATE = true;
            }

            else
            {



                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " SLAVE ADDRESS  Update dis activated \r\n";
                SLAVE_ADD_ACTIVATE = false;
            }



        }



        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox62_SelectedIndexChanged(object sender, EventArgs e)
        {
            SLAVE_ADD1_Lable.BackColor = System.Drawing.Color.DarkOrange;
            SLAVE_ADD_1_6 = true;

        }

        private void comboBox55_SelectedIndexChanged(object sender, EventArgs e)
        {
            SLAVE_ADD2_Lable.BackColor = System.Drawing.Color.DarkOrange;
            SLAVE_ADD_7_12 = true;
        }

        private void comboBox61_SelectedIndexChanged(object sender, EventArgs e)
        {
            SLAVE_ADD_PH_Lable.BackColor = System.Drawing.Color.DarkOrange;
            SLAVE_ADD_PH = true;
        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            RTC_DAY_Lable.BackColor = System.Drawing.Color.DarkOrange;
            day = true;
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            RTC_MONTH_Lable.BackColor = System.Drawing.Color.DarkOrange;
            month = true;
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            RTC_YEAR_Lable.BackColor = System.Drawing.Color.DarkOrange;
            year = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            RTC_HOUR_Lable.BackColor = System.Drawing.Color.DarkOrange;
            hour = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            RTC_MINUTE_Lable.BackColor = System.Drawing.Color.DarkOrange;
            minute = true;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Load_Saved_RGB_Settings()
        {

            IniParser parser = new IniParser("config/rgb.ini");


            //// Load RGB 1 Stored values in rgb.ini file 



            newMessage = parser.GetSetting("RGB1", "Red");//// Load Red 1 Stored values in rgb.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            trackBar5.Value = Parameters_test1;
            label1.Text = String.Concat("", Parameters_test1);


            newMessage1 = parser.GetSetting("RGB1", "Green");//// Load Green 1 Stored values in rgb.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            trackBar4.Value = Parameters_test2;
            label2.Text = String.Concat("", Parameters_test2);



            newMessage2 = parser.GetSetting("RGB1", "Blue");//// Load Blue 1 Stored values in rgb.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            trackBar3.Value = Parameters_test3;
            label3.Text = String.Concat("", Parameters_test3);


            newMessage3 = parser.GetSetting("RGB1", "Status");//// Load RGB 1 STATUS (true or false) Stored values in rgb.ini file 


            if (newMessage3 == "TRUE")
            {
                checkBox1.Checked = true;
                ACTIVATE_RGB1 = true;
                RED1 = true;
                BLUE1 = true;
                GREEN1 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH1 activated \r\n";
                label76.BackColor = System.Drawing.Color.DarkOrange;
                RGB_COLOR1_panel52();

            }
            else
            {
                checkBox1.Checked = false;
                ACTIVATE_RGB1 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH1 disactivated \r\n";
                label76.BackColor = System.Drawing.Color.DarkGray;
                ACTIVATE_RGB1 = false;
                RED1 = false;
                BLUE1 = false;
                GREEN1 = false;
            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;

            //// Load RGB 2 Stored values in rgb.ini file 

            newMessage = parser.GetSetting("RGB2", "Red");//// Load Red 2 Stored values in rgb.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            trackBar6.Value = Parameters_test1;
            label31.Text = String.Concat("", Parameters_test1);


            newMessage1 = parser.GetSetting("RGB2", "Green");//// Load Green 2 Stored values in rgb.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            trackBar1.Value = Parameters_test2;
            label30.Text = String.Concat("", Parameters_test2);



            newMessage2 = parser.GetSetting("RGB2", "Blue");//// Load Blue 2 Stored values in rgb.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            trackBar2.Value = Parameters_test3;
            label4.Text = String.Concat("", Parameters_test3);

            newMessage3 = parser.GetSetting("RGB2", "Status");//// Load RGB 2 STATUS (true or false) Stored values in rgb.ini file 


            if (newMessage3 == "TRUE")
            {
                checkBox8.Checked = true;
                ACTIVATE_RGB2 = true;
                RED2 = true;
                BLUE2 = true;
                GREEN2 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH2 activated \r\n";
                label81.BackColor = System.Drawing.Color.DarkOrange;
                RGB_COLOR2_panel54();

            }
            else
            {
                checkBox8.Checked = false;
                ACTIVATE_RGB2 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH2 disactivated \r\n";
                label81.BackColor = System.Drawing.Color.DarkGray;
                ACTIVATE_RGB2 = false;
                RED2 = false;
                BLUE2 = false;
                GREEN2 = false;
            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;

            //// Load RGB 3 Stored values in rgb.ini file 

            newMessage = parser.GetSetting("RGB3", "Red");//// Load Red 3 Stored values in rgb.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            trackBar13.Value = Parameters_test1;
            label34.Text = String.Concat("", Parameters_test1);


            newMessage1 = parser.GetSetting("RGB3", "Green");//// Load Green 3 Stored values in rgb.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            trackBar11.Value = Parameters_test2;
            label33.Text = String.Concat("", Parameters_test2);



            newMessage2 = parser.GetSetting("RGB3", "Blue");//// Load Blue 3 Stored values in rgb.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            trackBar12.Value = Parameters_test3;
            label32.Text = String.Concat("", Parameters_test3);


            newMessage3 = parser.GetSetting("RGB3", "Status");//// Load RGB 3 STATUS (true or false) Stored values in rgb.ini file 


            if (newMessage3 == "TRUE")
            {
                checkBox9.Checked = true;
                ACTIVATE_RGB3 = true;
                RED3 = true;
                BLUE3 = true;
                GREEN3 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH3 activated \r\n";
                label77.BackColor = System.Drawing.Color.DarkOrange;
                RGB_COLOR3_panel53();

            }
            else
            {
                checkBox9.Checked = false;
                ACTIVATE_RGB3 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH3 disactivated \r\n";
                label77.BackColor = System.Drawing.Color.DarkGray;
                ACTIVATE_RGB3 = false;
                RED3 = false;
                BLUE3 = false;
                GREEN3 = false;
            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;

            //// Load RGB 4 Stored values in rgb.ini file 

            newMessage = parser.GetSetting("RGB4", "Red");//// Load Red 4 Stored values in rgb.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            trackBar9.Value = Parameters_test1;
            label37.Text = String.Concat("", Parameters_test1);


            newMessage1 = parser.GetSetting("RGB4", "Green");//// Load Green 4 Stored values in rgb.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            trackBar10.Value = Parameters_test2;
            label36.Text = String.Concat("", Parameters_test2);



            newMessage2 = parser.GetSetting("RGB4", "Blue");//// Load Blue 4 Stored values in rgb.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            trackBar8.Value = Parameters_test3;
            label35.Text = String.Concat("", Parameters_test3);


            newMessage3 = parser.GetSetting("RGB4", "Status");//// Load RGB 4 STATUS (true or false) Stored values in rgb.ini file 


            if (newMessage3 == "TRUE")
            {
                checkBox10.Checked = true;
                ACTIVATE_RGB4 = true;
                RED4 = true;
                BLUE4 = true;
                GREEN4 = true;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH4 activated \r\n";
                label78.BackColor = System.Drawing.Color.DarkOrange;
                RGB_COLOR4_panel55();

            }
            else
            {
                checkBox10.Checked = false;
                ACTIVATE_RGB4 = false;
                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " RGB CH4 disactivated \r\n";
                label78.BackColor = System.Drawing.Color.DarkGray;
                ACTIVATE_RGB4 = false;
                RED4 = false;
                BLUE4 = false;
                GREEN4 = false;
            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;
            richTextBox1.Text += (DateTime.Now);
            richTextBox1.Text += ("  ");
            richTextBox1.Text += " config/rgb.ini file loaded \r\n";

        }
        private void Load_Saved_TIMERS_Settings()
        {

            IniParser parser = new IniParser("config/timers.ini");


            //// Load Sunrise Stored values in timers.ini file 



            newMessage = parser.GetSetting("Sunrise", "hourOn1");//// Load Sunrise hourOn1 Stored values in timers.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            comboBox16.SelectedIndex = (Parameters_test1);



            newMessage1 = parser.GetSetting("Sunrise", "minOn1");//// Load Sunrise minOn1 Stored values in timers.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            comboBox13.SelectedIndex = Parameters_test2;




            newMessage2 = parser.GetSetting("Sunrise", "hourOff1");//// Load Sunrise hourOff1 Stored values in timers.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            comboBox14.SelectedIndex = Parameters_test3;


            newMessage4 = parser.GetSetting("Sunrise", "minOff1");//// Load Sunrise minOff1 Stored values in timers.ini file 
            Parameters_test4 = Convert.ToInt32(newMessage4);
            comboBox15.SelectedIndex = Parameters_test4;


            newMessage5 = parser.GetSetting("Sunrise", "duration");//// Load Sunrise duration Stored values in timers.ini file 
            Parameters_test5 = Convert.ToInt32(newMessage5);
            comboBox1.SelectedIndex = Parameters_test5 / 30;



            newMessage3 = parser.GetSetting("Sunrise", "Status");//// Load Sunrise STATUS (true or false) Stored values in timers.ini file 

            if (newMessage3 == "TRUE")
            {
                Sunrise_checkBox.Checked = true;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Sunrise Timer activated \r\n";
                ACTIVATE_SUNRISE = true;
                SunriseHON = true;
                SunriseMON = true;
                SunriseHOFF = true;
                SunriseMOFF = true;
                SRDUR = true;
            }
            else
            {
                Sunrise_checkBox.Checked = false;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Sunrise Timer CH1 disactivated \r\n";
                ACTIVATE_SUNRISE = false;
                SunriseHON = false;
                SunriseMON = false;
                SunriseHOFF = false;
                SunriseMOFF = false;
                SRDUR = false;

                SunriseHON_Lable.BackColor = System.Drawing.Color.CadetBlue;
                SunriseMON_Lable.BackColor = System.Drawing.Color.CadetBlue;
                SunriseMOFF_Lable.BackColor = System.Drawing.Color.CadetBlue;
                SunriseHOFF_Lable.BackColor = System.Drawing.Color.CadetBlue;
                SRDUR_Lable.BackColor = System.Drawing.Color.CadetBlue;

            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;
            Parameters_test4 = 0;
            Parameters_test5 = 0;



            //// Load Sunset Stored values in timers.ini file 

            newMessage = parser.GetSetting("Sunset", "hourOn1");//// Load Sunset hourOn1 Stored values in timers.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            comboBox8.SelectedIndex = (Parameters_test1);

            newMessage1 = parser.GetSetting("Sunset", "minOn1");//// Load Sunset minOn1 Stored values in timers.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            comboBox5.SelectedIndex = Parameters_test2;

            newMessage2 = parser.GetSetting("Sunset", "hourOff1");//// Load Sunset hourOff1 Stored values in timers.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            comboBox6.SelectedIndex = Parameters_test3;

            newMessage4 = parser.GetSetting("Sunset", "minOff1");//// Load Sunset minOff1 Stored values in timers.ini file 
            Parameters_test4 = Convert.ToInt32(newMessage4);
            comboBox7.SelectedIndex = Parameters_test4;

            newMessage5 = parser.GetSetting("Sunset", "duration");//// Load Sunset duration Stored values in timers.ini file 
            Parameters_test5 = Convert.ToInt32(newMessage5);
            comboBox2.SelectedIndex = Parameters_test5 / 30;


            newMessage3 = parser.GetSetting("Sunset", "Status");//// Load Sunset STATUS (true or false) Stored values in timers.ini file 

            if (newMessage3 == "TRUE")
            {
                Sunset_checkBox.Checked = true;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Sunset Timer activated \r\n";
                ACTIVATE_SUNSET = true;
                SunsetHON = true;
                SunsetMON = true;
                SunsetHOFF = true;
                SunsetMOFF = true;
                SSDUR = true;
            }
            else
            {
                Sunset_checkBox.Checked = false;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Sunset Timer CH1 disactivated \r\n";
                ACTIVATE_SUNSET = false;
                SunsetHON = false;
                SunsetMON = false;
                SunsetHOFF = false;
                SunsetMOFF = false;
                SSDUR = false;

                SunsetHON_Label.BackColor = System.Drawing.Color.CadetBlue;
                SunsetMON_Label.BackColor = System.Drawing.Color.CadetBlue;
                SunsetMOFF_Label.BackColor = System.Drawing.Color.CadetBlue;
                SunsetHOFF_Label.BackColor = System.Drawing.Color.CadetBlue;
                SSDUR_Lable.BackColor = System.Drawing.Color.CadetBlue;
            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;
            Parameters_test4 = 0;
            Parameters_test5 = 0;
            //// Load Day 1 Stored values in timers.ini file 

            newMessage = parser.GetSetting("Day 1", "hourOn1");//// Load Day 1 hourOn1 Stored values in timers.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            comboBox11.SelectedIndex = (Parameters_test1);

            newMessage1 = parser.GetSetting("Day 1", "minOn1");//// Load Day 1 minOn1 Stored values in timers.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            comboBox10.SelectedIndex = Parameters_test2;

            newMessage2 = parser.GetSetting("Day 1", "hourOff1");//// Load Day 1 hourOff1 Stored values in timers.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            comboBox9.SelectedIndex = Parameters_test3;

            newMessage4 = parser.GetSetting("Day 1", "minOff1");//// Load Day 1 minOff1 Stored values in timers.ini file 
            Parameters_test4 = Convert.ToInt32(newMessage4);
            comboBox12.SelectedIndex = Parameters_test4;

            newMessage3 = parser.GetSetting("Day 1", "Status");//// Load Day 1 STATUS (true or false) Stored values in timers.ini file 

            if (newMessage3 == "TRUE")
            {
                Day1_checkBox.Checked = true;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 1 Timer activated \r\n";
                ACTIVATE_DAY1 = true;
                Day1HON = true;
                Day1MON = true;
                Day1HOFF = true;
                Day1MOFF = true;

            }
            else
            {
                Day1_checkBox.Checked = false;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 1 Timer CH1 disactivated \r\n";
                ACTIVATE_DAY1 = false;
                Day1HON = false;
                Day1MON = false;
                Day1HOFF = false;
                Day1MOFF = false;


            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;
            Parameters_test4 = 0;

            //// Load Day 2 Stored values in timers.ini file 

            newMessage = parser.GetSetting("Day 2", "hourOn1");//// Load Day 2 hourOn1 Stored values in timers.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            comboBox22.SelectedIndex = (Parameters_test1);

            newMessage1 = parser.GetSetting("Day 2", "minOn1");//// Load Day 2 minOn1 Stored values in timers.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            comboBox23.SelectedIndex = Parameters_test2;

            newMessage2 = parser.GetSetting("Day 2", "hourOff1");//// Load Day 2 hourOff1 Stored values in timers.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            comboBox21.SelectedIndex = Parameters_test3;

            newMessage4 = parser.GetSetting("Day 2", "minOff1");//// Load Day 2 minOff1 Stored values in timers.ini file 
            Parameters_test4 = Convert.ToInt32(newMessage4);
            comboBox24.SelectedIndex = Parameters_test4;

            newMessage3 = parser.GetSetting("Day 2", "Status");//// Load Day 2 STATUS (true or false) Stored values in timers.ini file 

            if (newMessage3 == "TRUE")
            {
                Day2_checkBox.Checked = true;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 2 Timer activated \r\n";
                ACTIVATE_DAY2 = true;
                Day2HON = true;
                Day2MON = true;
                Day2HOFF = true;
                Day2MOFF = true;

            }
            else
            {
                Day2_checkBox.Checked = false;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 2 Timer CH1 disactivated \r\n";
                ACTIVATE_DAY2 = false;
                Day2HON = false;
                Day2MON = false;
                Day2HOFF = false;
                Day2MOFF = false;


            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;
            Parameters_test4 = 0;
            //// Load Day 3 Stored values in timers.ini file 

            newMessage = parser.GetSetting("Day 3", "hourOn1");//// Load Day 3 hourOn1 Stored values in timers.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            comboBox18.SelectedIndex = (Parameters_test1);

            newMessage1 = parser.GetSetting("Day 3", "minOn1");//// Load Day 3 minOn1 Stored values in timers.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            comboBox19.SelectedIndex = Parameters_test2;

            newMessage2 = parser.GetSetting("Day 3", "hourOff1");//// Load Day 3 hourOff1 Stored values in timers.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            comboBox17.SelectedIndex = Parameters_test3;

            newMessage4 = parser.GetSetting("Day 3", "minOff1");//// Load Day 3 minOff1 Stored values in timers.ini file 
            Parameters_test4 = Convert.ToInt32(newMessage4);
            comboBox20.SelectedIndex = Parameters_test4;

            newMessage3 = parser.GetSetting("Day 3", "Status");//// Load Day 3 STATUS (true or false) Stored values in timers.ini file 

            if (newMessage3 == "TRUE")
            {
                Day3_checkBox.Checked = true;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 3 Timer activated \r\n";
                ACTIVATE_DAY3 = true;
                Day3HON = true;
                Day3MON = true;
                Day3HOFF = true;
                Day3MOFF = true;

            }
            else
            {
                Day3_checkBox.Checked = false;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Day 3 Timer CH1 disactivated \r\n";
                ACTIVATE_DAY3 = false;
                Day3HON = false;
                Day3MON = false;
                Day3HOFF = false;
                Day3MOFF = false;


            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;
            Parameters_test4 = 0;

            //// Load Uv 1 Stored values in timers.ini file 

            newMessage = parser.GetSetting("UV Light 1", "hourOn1");//// Load Uv 1 hourOn1 Stored values in timers.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            comboBox53.SelectedIndex = (Parameters_test1);

            newMessage1 = parser.GetSetting("UV Light 1", "minOn1");//// Load Uv 1 minOn1 Stored values in timers.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            comboBox52.SelectedIndex = Parameters_test2;

            newMessage2 = parser.GetSetting("UV Light 1", "hourOff1");//// Load Uv 1 hourOff1 Stored values in timers.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            comboBox51.SelectedIndex = Parameters_test3;

            newMessage4 = parser.GetSetting("UV Light 1", "minOff1");//// Load Uv 1 minOff1 Stored values in timers.ini file 
            Parameters_test4 = Convert.ToInt32(newMessage4);
            comboBox54.SelectedIndex = Parameters_test4;

            newMessage3 = parser.GetSetting("UV Light 1", "Status");//// Load Uv 1 STATUS (true or false) Stored values in timers.ini file 

            if (newMessage3 == "TRUE")
            {
                Uv1_checkBox.Checked = true;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " UV Light 1 Timer activated \r\n";
                ACTIVATE_UV1 = true;
                Uv1HON = true;
                Uv1MON = true;
                Uv1HOFF = true;
                Uv1MOFF = true;

            }
            else
            {
                Uv1_checkBox.Checked = false;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " UV Light 1 Timer CH1 disactivated \r\n";
                ACTIVATE_UV1 = false;
                Uv1HON = false;
                Uv1MON = false;
                Uv1HOFF = false;
                Uv1MOFF = false;


            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;
            Parameters_test4 = 0;

            //// Load Uv 2 Stored values in timers.ini file 

            newMessage = parser.GetSetting("UV Light 2", "hourOn1");//// Load Uv 2 hourOn1 Stored values in timers.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            comboBox56.SelectedIndex = (Parameters_test1);

            newMessage1 = parser.GetSetting("UV Light 2", "minOn1");//// Load Uv 2 minOn1 Stored values in timers.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            comboBox57.SelectedIndex = Parameters_test2;

            newMessage2 = parser.GetSetting("UV Light 2", "hourOff1");//// Load Uv 2 hourOff1 Stored values in timers.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            comboBox58.SelectedIndex = Parameters_test3;

            newMessage4 = parser.GetSetting("UV Light 2", "minOff1");//// Load Uv 2 minOff1 Stored values in timers.ini file 
            Parameters_test4 = Convert.ToInt32(newMessage4);
            comboBox59.SelectedIndex = Parameters_test4;

            newMessage3 = parser.GetSetting("UV Light 2", "Status");//// Load Uv 2 STATUS (true or false) Stored values in timers.ini file 

            if (newMessage3 == "TRUE")
            {
                Uv2_checkBox.Checked = true;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " UV Light 2 Timer activated \r\n";
                ACTIVATE_UV2 = true;
                Uv2HON = true;
                Uv2MON = true;
                Uv2HOFF = true;
                Uv2MOFF = true;

            }
            else
            {
                Uv2_checkBox.Checked = false;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " UV Light 2 Timer CH1 disactivated \r\n";
                ACTIVATE_UV2 = false;
                Uv2HON = false;
                Uv2MON = false;
                Uv2HOFF = false;
                Uv2MOFF = false;


            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;
            Parameters_test4 = 0;
            //// Load Neon 1 Stored values in timers.ini file 

            newMessage = parser.GetSetting("Neon 1", "hourOn1");//// Load Neon 1 hourOn1 Stored values in timers.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            comboBox34.SelectedIndex = (Parameters_test1);

            newMessage1 = parser.GetSetting("Neon 1", "minOn1");//// Load Neon 1 minOn1 Stored values in timers.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            comboBox35.SelectedIndex = Parameters_test2;

            newMessage2 = parser.GetSetting("Neon 1", "hourOff1");//// Load Neon 1 hourOff1 Stored values in timers.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            comboBox33.SelectedIndex = Parameters_test3;

            newMessage4 = parser.GetSetting("Neon 1", "minOff1");//// Load Neon 1 minOff1 Stored values in timers.ini file 
            Parameters_test4 = Convert.ToInt32(newMessage4);
            comboBox36.SelectedIndex = Parameters_test4;

            newMessage3 = parser.GetSetting("Neon 1", "Status");//// Load Neon 1 STATUS (true or false) Stored values in timers.ini file 

            if (newMessage3 == "TRUE")
            {
                Neon1_checkBox.Checked = true;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Neon 1 Timer activated \r\n";
                ACTIVATE_NEON1 = true;
                Neon1HON = true;
                Neon1MON = true;
                Neon1HOFF = true;
                Neon1MOFF = true;

            }
            else
            {
                Neon1_checkBox.Checked = false;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Neon 1 Timer CH1 disactivated \r\n";
                ACTIVATE_NEON1 = false;
                Neon1HON = false;
                Neon1MON = false;
                Neon1HOFF = false;
                Neon1MOFF = false;


            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;
            Parameters_test4 = 0;

            //// Load Neon 2 Stored values in timers.ini file 

            newMessage = parser.GetSetting("Neon 2", "hourOn1");//// Load Neon 2 hourOn1 Stored values in timers.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            comboBox46.SelectedIndex = (Parameters_test1);

            newMessage1 = parser.GetSetting("Neon 2", "minOn1");//// Load Neon 2 minOn1 Stored values in timers.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            comboBox47.SelectedIndex = Parameters_test2;

            newMessage2 = parser.GetSetting("Neon 2", "hourOff1");//// Load Neon 2 hourOff1 Stored values in timers.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            comboBox45.SelectedIndex = Parameters_test3;

            newMessage4 = parser.GetSetting("Neon 2", "minOff1");//// Load Neon 2 minOff1 Stored values in timers.ini file 
            Parameters_test4 = Convert.ToInt32(newMessage4);
            comboBox48.SelectedIndex = Parameters_test4;

            newMessage3 = parser.GetSetting("Neon 2", "Status");//// Load Neon 2 STATUS (true or false) Stored values in timers.ini file 

            if (newMessage3 == "TRUE")
            {
                Neon2_checkBox.Checked = true;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Neon 2 Timer activated \r\n";
                ACTIVATE_NEON2 = true;
                Neon2HON = true;
                Neon2MON = true;
                Neon2HOFF = true;
                Neon2MOFF = true;

            }
            else
            {
                Neon2_checkBox.Checked = false;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Neon 2 Timer CH1 disactivated \r\n";
                ACTIVATE_NEON2 = false;
                Neon2HON = false;
                Neon2MON = false;
                Neon2HOFF = false;
                Neon2MOFF = false;


            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;
            Parameters_test4 = 0;


            //// Load Neon 3 Stored values in timers.ini file 

            newMessage = parser.GetSetting("Neon 3", "hourOn1");//// Load Neon 3 hourOn1 Stored values in timers.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            comboBox38.SelectedIndex = (Parameters_test1);

            newMessage1 = parser.GetSetting("Neon 3", "minOn1");//// Load Neon 3 minOn1 Stored values in timers.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            comboBox39.SelectedIndex = Parameters_test2;

            newMessage2 = parser.GetSetting("Neon 3", "hourOff1");//// Load Neon 3 hourOff1 Stored values in timers.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            comboBox37.SelectedIndex = Parameters_test3;

            newMessage4 = parser.GetSetting("Neon 3", "minOff1");//// Load Neon 3 minOff1 Stored values in timers.ini file 
            Parameters_test4 = Convert.ToInt32(newMessage4);
            comboBox40.SelectedIndex = Parameters_test4;

            newMessage3 = parser.GetSetting("Neon 3", "Status");//// Load Neon 3 STATUS (true or false) Stored values in timers.ini file 

            if (newMessage3 == "TRUE")
            {
                Neon3_checkBox.Checked = true;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Neon 3 Timer activated \r\n";
                ACTIVATE_NEON3 = true;
                Neon3HON = true;
                Neon3MON = true;
                Neon3HOFF = true;
                Neon3MOFF = true;

            }
            else
            {
                Neon3_checkBox.Checked = false;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Neon 3 Timer CH1 disactivated \r\n";
                ACTIVATE_NEON3 = false;
                Neon3HON = false;
                Neon3MON = false;
                Neon3HOFF = false;
                Neon3MOFF = false;


            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;
            Parameters_test4 = 0;

            //// Load Night 1 Stored values in timers.ini file 

            newMessage = parser.GetSetting("Night 1", "hourOn1");//// Load Night 1 hourOn1 Stored values in timers.ini file 
            Parameters_test1 = Convert.ToInt32(newMessage);
            comboBox42.SelectedIndex = (Parameters_test1);

            newMessage1 = parser.GetSetting("Night 1", "minOn1");//// Load Night 1 minOn1 Stored values in timers.ini file 
            Parameters_test2 = Convert.ToInt32(newMessage1);
            comboBox43.SelectedIndex = Parameters_test2;

            newMessage2 = parser.GetSetting("Night 1", "hourOff1");//// Load Night 1 hourOff1 Stored values in timers.ini file 
            Parameters_test3 = Convert.ToInt32(newMessage2);
            comboBox41.SelectedIndex = Parameters_test3;

            newMessage4 = parser.GetSetting("Night 1", "minOff1");//// Load Night 1 minOff1 Stored values in timers.ini file 
            Parameters_test4 = Convert.ToInt32(newMessage4);
            comboBox44.SelectedIndex = Parameters_test4;

            newMessage3 = parser.GetSetting("Night 1", "Status");//// Load Night 1 STATUS (true or false) Stored values in timers.ini file 

            if (newMessage3 == "TRUE")
            {
                Night1_checkBox.Checked = true;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Night 1 Timer activated \r\n";
                ACTIVATE_NIGHT1 = true;
                Night1HON = true;
                Night1MON = true;
                Night1HOFF = true;
                Night1MOFF = true;

            }
            else
            {
                Night1_checkBox.Checked = false;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " Night 1 Timer CH1 disactivated \r\n";
                ACTIVATE_NIGHT1 = false;
                Night1HON = false;
                Night1MON = false;
                Night1HOFF = false;
                Night1MOFF = false;


            }

            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;
            Parameters_test4 = 0;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Load_Saved_TIMERS_Settings();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {


            // if (ACTIVATE_SUNRISE || ACTIVATE_SUNSET || ACTIVATE_DAY1 || ACTIVATE_DAY2 || ACTIVATE_DAY3 ||ACTIVATE_NEON1 || ACTIVATE_NEON2 || ACTIVATE_NEON3 || ACTIVATE_NIGHT1 == true)
            // {
            Generate_timers_config_file();
            // CreateUDP_Timers_String();
            //    }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {


        }



        private void button16_Click(object sender, EventArgs e)
        {
            CreateUDP_Timers_String();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Load_SLAVE_ADDRESSES_settings();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Generate_AdvancedIO_config_file();
        }

        private void Generate_AdvancedIO_config_file()
        {

            //GENETATE Settings OF ALL AdvancedIO IN ONE FILE NAMED AdvancedIO.txt////////////////////////////////////////////////
            // Includes the following RTC Update data , Slave Address Data , IP address , UDP Port 

            IniFile ini = new IniFile("config/AdvancedIO.ini");// Create general file for all timer values CHGA 29/8/2016 

            ini.IniWriteValue("AdvancedIO", "File info ", "//File format created by Charles Galea 2018.");
            ini.IniWriteValue("AdvancedIO", "File Created ", DateTime.Now.ToString());
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////GENERATE RTC UPDATE FILE///////////////////////////////////////////////////////////////
            if (RTC_ACTIVATE)
            {

                String ADDRESS1 = Day_comboBox.Text;
                ini.IniWriteValue("RTC", "Day", ADDRESS1);
                this.progressBar1.Increment(25);

                String ADDRESS2 = Month_comboBox.Text;
                ini.IniWriteValue("RTC", "Month", ADDRESS2);
                this.progressBar1.Increment(25);

                String ADDRESS3 = Year_comboBox.Text;
                ini.IniWriteValue("RTC", "Year", ADDRESS3);
                this.progressBar1.Increment(25);

                String ADDRESS4 = Hour_comboBox.Text;
                ini.IniWriteValue("RTC", "Hour", ADDRESS4);
                this.progressBar1.Increment(25);

                String ADDRESS5 = Minute_comboBox.Text;
                ini.IniWriteValue("RTC", "Minute", ADDRESS5);
                this.progressBar1.Increment(25);

                ////////UDP String GEneration

                UDP_Timers_Digit_00 = 'A'; // A = UDP TIMER/SLAVES PARAMETER 
                UDP_STRING_COMBINED[0] = UDP_Timers_Digit_00.ToString(); //UDP Fitst Letter set to A : 

                UDP_Timers_Digit_01 = 12; // 12 = RTC  PARAMETER
                UDP_STRING_COMBINED[1] = UDP_Timers_Digit_01.ToString();//UDP TIMER number 1 in UDP String 2nd Character after A

                UDP_STRING_COMBINED[2] = ADDRESS1.ToString(); //UDP SLAVE 1 address

                UDP_STRING_COMBINED[3] = ADDRESS2.ToString();//UDP SLAVE 2 address

                UDP_STRING_COMBINED[4] = ADDRESS3.ToString();//UDP SLAVE 3 address

                UDP_STRING_COMBINED[5] = ADDRESS4.ToString();//NOT USED by UDP Slaves  type

                UDP_STRING_COMBINED[6] = ADDRESS5.ToString();//NOT USED by UDP Slaves  type
                UDP_STRING_COMBINED[7] = "0".ToString();//NOT USED by UDP Slaves  type

                String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED);//UDP join all values to one string
                var builder = new StringBuilder();
                Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
                var result = String.Join(":", UDP_STRING_COMBINED.ToArray());//Result contains the NEW String with Deliminer

                ////UDP String Creation Ends  
                ini.IniWriteValue("RTC", "Status", "true");
                ini.IniWriteValue("RTC", "UDP_PACKET", result);//UDP string Write in Config file

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "RTC Data generated succesfully \r\n";

            }

            else
            {
                ini.IniWriteValue("RTC", "Status", "false");
                ini.IniWriteValue("RTC", "Day", "0");
                ini.IniWriteValue("RTC", "Month", "0");
                ini.IniWriteValue("RTC", "Year", "0");
                ini.IniWriteValue("RTC", "Hour", "0");
                ini.IniWriteValue("RTC", "Minute", "0");
                ini.IniWriteValue("RTC", "UDP_PACKET", EMPTY_UDP);

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "RTC update is disabled \r\n";

            }
            //////////////////////////////GENERATE SLAVE UPDATE FILE///////////////////////////////////////////////////////////////
            if (SLAVE_ADD_ACTIVATE)
            {

                String RTC1 = comboBox62.Text;
                ini.IniWriteValue("Slaves", "ADD 01", RTC1);
                this.progressBar1.Increment(25);

                String RTC2 = comboBox55.Text;
                ini.IniWriteValue("Slaves", "ADD 02", RTC2);
                this.progressBar1.Increment(25);

                String RTC3 = comboBox61.Text;
                ini.IniWriteValue("Slaves", "ADD 03", RTC3);
                this.progressBar1.Increment(25);

                ////////UDP String GEneration

                UDP_Timers_Digit_00 = 'A'; // A = UDP TIMER/SLAVES PARAMETER 
                UDP_STRING_COMBINED[0] = UDP_Timers_Digit_00.ToString(); //UDP Fitst Letter set to A : 

                UDP_Timers_Digit_01 = 11; // 11 = SLAVES  PARAMETER
                UDP_STRING_COMBINED[1] = UDP_Timers_Digit_01.ToString();//UDP TIMER number 1 in UDP String 2nd Character after A

                UDP_STRING_COMBINED[2] = RTC1.ToString(); //UDP SLAVE 1 address

                UDP_STRING_COMBINED[3] = RTC2.ToString();//UDP SLAVE 2 address

                UDP_STRING_COMBINED[4] = RTC3.ToString();//UDP SLAVE 3 address

                UDP_STRING_COMBINED[5] = "0".ToString();//NOT USED by UDP Slaves  type

                UDP_STRING_COMBINED[6] = "0".ToString();//NOT USED by UDP Slaves  type
                UDP_STRING_COMBINED[7] = "0".ToString();//NOT USED by UDP Slaves  type

                String.Join(UDP_DELIMINER.ToString(), UDP_STRING_COMBINED);//UDP join all values to one string
                var builder = new StringBuilder();
                Array.ForEach(UDP_STRING_COMBINED, x => builder.Append(x));
                var result = String.Join(":", UDP_STRING_COMBINED.ToArray());//Result contains the NEW String with Deliminer

                ////UDP String Creation Ends  
                ini.IniWriteValue("Slaves", "Status", "true");
                ini.IniWriteValue("Slaves", "UDP_PACKET", result);//UDP string Write in Config file


                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Slaves addresses generated succesfully \r\n";

            }

            else
            {
                ini.IniWriteValue("Slaves", "Status", "false");
                ini.IniWriteValue("Slaves", "ADD 01", "0");
                ini.IniWriteValue("Slaves", "ADD 02", "0");
                ini.IniWriteValue("Slaves", "ADD 03", "0");
                ini.IniWriteValue("Slaves", "UDP_PACKET", EMPTY_UDP);

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += "Slaves addresses are disabled \r\n";

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }



void Load_SLAVE_ADDRESSES_settings() {

            IniParser parser = new IniParser("config/AdvancedIO.ini");


            //// Load SLAVES Stored values in AdvancedIO.ini file 


            newMessage3 = parser.GetSetting("Slaves", "Status");//// Load Sunrise STATUS (true or false) Stored values in timers.ini file 

            if (newMessage3 == "TRUE")
            {

                




                newMessage1 = parser.GetSetting("Slaves", "ADD 01");//// Load Sunrise minOn1 Stored values in timers.ini file 
                Parameters_test2 = Convert.ToInt32(newMessage1);
                comboBox62.SelectedIndex = Parameters_test2;




                newMessage2 = parser.GetSetting("Slaves", "ADD 02");//// Load Sunrise hourOff1 Stored values in timers.ini file 
                Parameters_test3 = Convert.ToInt32(newMessage2);
                comboBox55.SelectedIndex = Parameters_test3;


                newMessage4 = parser.GetSetting("Slaves", "ADD 03");//// Load Sunrise minOff1 Stored values in timers.ini file 
                Parameters_test4 = Convert.ToInt32(newMessage4);
                comboBox61.SelectedIndex = Parameters_test4;


                SLAVEADD_checkBox.Checked = true;
                SLAVE_ADD_1_6 = true;
                SLAVE_ADD_7_12 = true;
                SLAVE_ADD_PH = true;


                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " SLAVE Update activated & Settings loaded \r\n";

            }
            else
            {
               

 
                SLAVE_ADD_1_6 = false;
                SLAVE_ADD_7_12 = false;
                SLAVE_ADD_PH = false;
                SLAVEADD_checkBox.Checked =false;

                SLAVE_ADD1_Lable.BackColor = System.Drawing.Color.CadetBlue;
                SLAVE_ADD2_Lable.BackColor = System.Drawing.Color.CadetBlue;
                SLAVE_ADD_PH_Lable.BackColor = System.Drawing.Color.CadetBlue;
                Slave_ADD_Lable.BackColor = System.Drawing.Color.CadetBlue;

                richTextBox1.Text += (DateTime.Now);
                richTextBox1.Text += ("  ");
                richTextBox1.Text += " SLAVE Update dis activated & Settings not loaded \r\n";

            }


            Parameters_test1 = 0;
            Parameters_test2 = 0;
            Parameters_test3 = 0;
            Parameters_test4 = 0;
            Parameters_test5 = 0;

    }
    

        private void Day1HON_Label_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            List<DateTime[]> list = new List<DateTime[]>();
            DateTime[] array1 = new[] { DateTime.Now, DateTime.Now };
            DateTime[] array2 = new[] { DateTime.Today, DateTime.UtcNow };

            list.Add(array1);
            list.Add(array2);

            int R = array2[1].Day;

            Day_comboBox.SelectedIndex = R-1;
            RTC_DAY_Lable.BackColor = System.Drawing.Color.DarkOrange;
            day = true;

            R = array2[1].Month;

            Month_comboBox.SelectedIndex = R - 1;
            RTC_MONTH_Lable.BackColor = System.Drawing.Color.DarkOrange;
            month = true;

            R = array2[1].Year;

            Year_comboBox.SelectedIndex = R - 2014;
            RTC_YEAR_Lable.BackColor = System.Drawing.Color.DarkOrange;
            year = true;

            R = array2[1].Hour;

            Hour_comboBox.SelectedIndex = R ;
            RTC_HOUR_Lable.BackColor = System.Drawing.Color.DarkOrange;
            hour = true;

            R = array2[1].Minute;

            Minute_comboBox.SelectedIndex = R ;
            RTC_MINUTE_Lable.BackColor = System.Drawing.Color.DarkOrange;
            minute = true;



        }
    }
}