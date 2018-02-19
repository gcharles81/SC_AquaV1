///////GENETATE GENERAL STATUS OF ALL TIMERS IN ONE FILE NAMED TIMSTS.txt////////////////////////////////////////////////

	
	IniFile ini = new IniFile("config/timers.ini");// Create general file for all timer values CHGA 29/8/2016 

    ini.IniWriteValue("Info", "File info ", "//File format created by Charles Galea 2016.");
    ini.IniWriteValue("Info", "File Created ", DateTime.Now.ToString());
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

 if ((CheckStatus1 == true) & (SunriseHON == true) & (SunriseMON == true)& (SunriseHOFF == true)& (SunriseMOFF == true)& (SRDUR == true) ){
        			
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

			richTextBox1.Text += (DateTime::Now );
		    richTextBox1.Text += ("  ");		
			richTextBox1.Text += " Sunrise files generated succesfully \r\n";

			 }

			 else {
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");
			 richTextBox1.Text += " Sunrise Timer is DISABLED \r\n";

			 }
		 
			 if ((CheckStatus2 == true) & (SunsetHON == true) & (SunsetMON == true)&(SunsetHOFF == true)&(SunsetMOFF == true )&(SSDUR == true)){
			
			

			StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/Sunset/SSHON.txt");
			String hourOn1 = comboBox8.Text;
			outFile.Write(hourOn1);
			outFile.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile2 = gcnew  StreamWriter("upload/timers/Sunset/SSMON.txt");
			String minOn1 = comboBox5.Text;
			outFile2.Write(minOn1);
			outFile2.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile3 = gcnew  StreamWriter("upload/timers/Sunset/SSHOFF.txt");
			String hourOff1 = comboBox6.Text;
			outFile3.Write(hourOff1);
			outFile3.Close();
			this.progressBar1.Increment(25);

				 StreamWriter^ outFile4 = gcnew  StreamWriter("upload/timers/Sunset/SSMOFF.txt");
			String minOff1 = comboBox7.Text;
			outFile4.Write(minOff1);
			outFile4.Close();
			this.progressBar1.Increment(25);


		
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Sunset files generated succesfully \r\n";

			 }

			 else {
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");
				 richTextBox1.Text += " Sunset Timer is DISABLED \r\n";

			 }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////GENERATE DAY 1 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
 if ((Day1_Enable == true) & (Day1HON == true) & (Day1MON == true)&(Day1HOFF == true)&(Day1MOFF == true )){
			
	 		StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/LedDay1/D1TIME.txt");
			outFile.Write("//");
			outFile.Write(DateTime::Now );
		    outFile.Write("\n");
			outFile.Write("//File format created by Charles Galea 2014.");
		    outFile.Write("\n");
			outFile.Write("//This file consists of hours and minutes when timers go on & off.");
		    outFile.Write("\n");
			outFile.Write("//It is supported on AquaSmartControl V2 onwards ");
			outFile.Write("\n");
			outFile.Write("//24 hour format");
			outFile.Write("\n");
			outFile.Write("\n");

			outFile.Write("//DAY 1 TIMER  (ON) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("D1HON = ");
			String hourOn1 = comboBox11.Text;
			outFile.Write(hourOn1);
			outFile.Write("\n");
			outFile.Write("\n");
	
			outFile.Write("//DAY 1 TIMER  (ON) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("D1MON = ");
			String minOn1 = comboBox10.Text;
			outFile.Write(minOn1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//DAY 1 TIMER  (OFF) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("D1HOFF = ");
			String hourOff1 = comboBox9.Text;
			outFile.Write(hourOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//DAY 1 TIMER  (OFF) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("D1MOFF = ");
			String minOff1 = comboBox12.Text;
			outFile.Write(minOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Close();

			this.progressBar1.Increment(20);

			richTextBox1.Text += (DateTime::Now );
			richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Day1 files generated succesfully \r\n";

			
	 /*
			StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/LedDay1/D1HON.txt");
			String hourOn1 = comboBox11.Text;
			outFile.Write(hourOn1);
			outFile.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile2 = gcnew  StreamWriter("upload/timers/LedDay1/D1MON.txt");
			String minOn1 = comboBox10.Text;
			outFile2.Write(minOn1);
			outFile2.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile3 = gcnew  StreamWriter("upload/timers/LedDay1/D1HOFF.txt");
			String hourOff1 = comboBox9.Text;
			outFile3.Write(hourOff1);
			outFile3.Close();
			this.progressBar1.Increment(25);

				 StreamWriter^ outFile4 = gcnew  StreamWriter("upload/timers/LedDay1/D1MOFF.txt");
			String minOff1 = comboBox12.Text;
			outFile4.Write(minOff1);
			outFile4.Close();
			this.progressBar1.Increment(25);


		
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Day1 files generated succesfully \r\n";
			*/
			 }

			 else {
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");
				 richTextBox1.Text += " Day1 Timer is DISABLED \r\n";

			 }	
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////GENERATE DAY 2 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
 if ((Day2_Enable == true) & (Day2HON == true) & (Day2MON == true)&(Day2HOFF == true)&(Day2MOFF == true )){
			
	        StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/LedDay2/D2TIME.txt");
			///////////////////////////////////////////////////////////////////////////////////////	
			outFile.Write("//");
			outFile.Write(DateTime::Now );
		    outFile.Write("\n");
			outFile.Write("//File format created by Charles Galea 2014.");
		    outFile.Write("\n");
			outFile.Write("//This file consists of hours and minutes when timers go on & off.");
		    outFile.Write("\n");
			outFile.Write("//It is supported on AquaSmartControl V2 onwards ");
			outFile.Write("\n");
			outFile.Write("//24 hour format");
			outFile.Write("\n");
			outFile.Write("\n");

			outFile.Write("//DAY 2 TIMER  (ON) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("D2HON = ");
			String hourOn1 = comboBox22.Text;
			outFile.Write(hourOn1);
			outFile.Write("\n");
			outFile.Write("\n");
	
			outFile.Write("//DAY 2 TIMER  (ON) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("D2MON = ");
			String minOn1 = comboBox23.Text;
			outFile.Write(minOn1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//DAY 2 TIMER  (OFF) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("D2HOFF = ");
			String hourOff1 = comboBox21.Text;
			outFile.Write(hourOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//DAY 2 TIMER  (OFF) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("D2MOFF = ");
			String minOff1 = comboBox24.Text;
			outFile.Write(minOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Close();

			this.progressBar1.Increment(20);

			richTextBox1.Text += (DateTime::Now );
			richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Day2 files generated succesfully \r\n";


/*
			StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/LedDay2/D2HON.txt");
			String hourOn1 = comboBox22.Text;
			outFile.Write(hourOn1);
			outFile.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile2 = gcnew  StreamWriter("upload/timers/LedDay2/D2MON.txt");
			String minOn1 = comboBox23.Text;
			outFile2.Write(minOn1);
			outFile2.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile3 = gcnew  StreamWriter("upload/timers/LedDay2/D2HOFF.txt");
			String hourOff1 = comboBox21.Text;
			outFile3.Write(hourOff1);
			outFile3.Close();
			this.progressBar1.Increment(25);

				 StreamWriter^ outFile4 = gcnew  StreamWriter("upload/timers/LedDay2/D2MOFF.txt");
			String minOff1 = comboBox24.Text;
			outFile4.Write(minOff1);
			outFile4.Close();
			this.progressBar1.Increment(25);


		
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Day2 files generated succesfully \r\n";
*/

			 }

			 else {
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");
				 richTextBox1.Text += " Day2 Timer is DISABLED \r\n";

			 }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

///////////////////////////////GENERATE DAY 3 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
 if ((Day3_Enable == true) & (Day3HON == true) & (Day3MON == true)&(Day3HOFF == true)&(Day3MOFF == true )){
				        StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/LedDay3/D3TIME.txt");
			///////////////////////////////////////////////////////////////////////////////////////	
			outFile.Write("//");
			outFile.Write(DateTime::Now );
		    outFile.Write("\n");
			outFile.Write("//File format created by Charles Galea 2014.");
		    outFile.Write("\n");
			outFile.Write("//This file consists of hours and minutes when timers go on & off.");
		    outFile.Write("\n");
			outFile.Write("//It is supported on AquaSmartControl V2 onwards ");
			outFile.Write("\n");
			outFile.Write("//24 hour format");
			outFile.Write("\n");
			outFile.Write("\n");

			outFile.Write("//DAY 3 TIMER  (ON) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("D3HON = ");
			String hourOn1 = comboBox18.Text;
			outFile.Write(hourOn1);
			outFile.Write("\n");
			outFile.Write("\n");
	
			outFile.Write("//DAY 3 TIMER  (ON) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("D3MON = ");
			String minOn1 = comboBox19.Text;
			outFile.Write(minOn1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//DAY 3 TIMER  (OFF) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("D3HOFF = ");
			String hourOff1 = comboBox17.Text;
			outFile.Write(hourOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//DAY 3 TIMER  (OFF) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("D3MOFF = ");
			String minOff1 = comboBox20.Text;
			outFile.Write(minOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Close();

			this.progressBar1.Increment(20);

			richTextBox1.Text += (DateTime::Now );
			richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Day3 files generated succesfully \r\n";
			/*

			StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/LedDay3/D3HON.txt");
			String hourOn1 = comboBox18.Text;
			outFile.Write(hourOn1);
			outFile.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile2 = gcnew  StreamWriter("upload/timers/LedDay3/D3MON.txt");
			String minOn1 = comboBox19.Text;
			outFile2.Write(minOn1);
			outFile2.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile3 = gcnew  StreamWriter("upload/timers/LedDay3/D3HOFF.txt");
			String hourOff1 = comboBox17.Text;
			outFile3.Write(hourOff1);
			outFile3.Close();
			this.progressBar1.Increment(25);

				 StreamWriter^ outFile4 = gcnew  StreamWriter("upload/timers/LedDay3/D3MOFF.txt");
			String minOff1 = comboBox20.Text;
			outFile4.Write(minOff1);
			outFile4.Close();
			this.progressBar1.Increment(25);


		
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Day3 files generated succesfully \r\n";
			*/
			 }

			 else {
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");
				 richTextBox1.Text += " Day3 Timer is DISABLED \r\n";

			 }	
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			 


//////////////////////////////GENERATE NEON_1 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
 if ((Neon1_Enable == true) & (Neon1HON == true) & (Neon1MON == true)&(Neon1HOFF == true)&(Neon1MOFF == true )){
			
	 StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/Neon1/NE1TIME.txt");
			///////////////////////////////////////////////////////////////////////////////////////	
			outFile.Write("//");
			outFile.Write(DateTime::Now );
		    outFile.Write("\n");
			outFile.Write("//File format created by Charles Galea 2014.");
		    outFile.Write("\n");
			outFile.Write("//This file consists of hours and minutes when timers go on & off.");
		    outFile.Write("\n");
			outFile.Write("//It is supported on AquaSmartControl V2 onwards ");
			outFile.Write("\n");
			outFile.Write("//24 hour format");
			outFile.Write("\n");
			outFile.Write("\n");

			outFile.Write("//NEON 1 TIMER  (ON) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("NE1HON = ");
			String hourOn1 = comboBox34.Text;
			outFile.Write(hourOn1);
			outFile.Write("\n");
			outFile.Write("\n");
	
			outFile.Write("//NEON 1 TIMER  (ON) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("NE1MON = ");
			String minOn1 = comboBox35.Text;
			outFile.Write(minOn1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//NEON 1 TIMER  (OFF) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("NE1HOFF = ");
			String hourOff1 = comboBox33.Text;
			outFile.Write(hourOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//NEON 1 TIMER  (OFF) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("NE1MOFF = ");
			String minOff1 = comboBox36.Text;
			outFile.Write(minOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Close();

			this.progressBar1.Increment(20);

			richTextBox1.Text += (DateTime::Now );
			richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Neon1 files generated succesfully \r\n";		
	 /*
			StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/Neon1/Ne1HON.txt");
			String hourOn1 = comboBox34.Text;
			outFile.Write(hourOn1);
			outFile.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile2 = gcnew  StreamWriter("upload/timers/Neon1/Ne1MON.txt");
			String minOn1 = comboBox35.Text;
			outFile2.Write(minOn1);
			outFile2.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile3 = gcnew  StreamWriter("upload/timers/Neon1/Ne1HOFF.txt");
			String hourOff1 = comboBox33.Text;
			outFile3.Write(hourOff1);
			outFile3.Close();
			this.progressBar1.Increment(25);

			StreamWriter^ outFile4 = gcnew  StreamWriter("upload/timers/Neon1/Ne1MOFF.txt");
			String minOff1 = comboBox36.Text;
			outFile4.Write(minOff1);
			outFile4.Close();
			this.progressBar1.Increment(25);


		
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Neon1 files generated succesfully \r\n";
*/
			 }

			 else {
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");
				 richTextBox1.Text += " Neon1 Timer is DISABLED \r\n";

			 }	
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////GENERATE NEON_2 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
 if ((Neon2_Enable == true) & (Neon2HON == true) & (Neon2MON == true)&(Neon2HOFF == true)&(Neon2MOFF == true )){
	     StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/Neon2/NE2TIME.txt");
			///////////////////////////////////////////////////////////////////////////////////////	
			outFile.Write("//");
			outFile.Write(DateTime::Now );
		    outFile.Write("\n");
			outFile.Write("//File format created by Charles Galea 2014.");
		    outFile.Write("\n");
			outFile.Write("//This file consists of hours and minutes when timers go on & off.");
		    outFile.Write("\n");
			outFile.Write("//It is supported on AquaSmartControl V2 onwards ");
			outFile.Write("\n");
			outFile.Write("//24 hour format");
			outFile.Write("\n");
			outFile.Write("\n");

			outFile.Write("//NEON 2 TIMER  (ON) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("NE2HON = ");
			String hourOn1 = comboBox46.Text;
			outFile.Write(hourOn1);
			outFile.Write("\n");
			outFile.Write("\n");
	
			outFile.Write("//NEON 2 TIMER  (ON) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("NE2MON = ");
			String minOn1 = comboBox47.Text;
			outFile.Write(minOn1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//NEON 2 TIMER  (OFF) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("NE2HOFF = ");
			String hourOff1 = comboBox45.Text;
			outFile.Write(hourOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//NEON 2 TIMER  (OFF) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("NE2MOFF = ");
			String minOff1 = comboBox48.Text;
			outFile.Write(minOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Close();

			this.progressBar1.Increment(20);

			richTextBox1.Text += (DateTime::Now );
			richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Neon2 files generated succesfully \r\n";		
			
	 /*
			StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/Neon2/Ne2HON.txt");
			String hourOn1 = comboBox46.Text;
			outFile.Write(hourOn1);
			outFile.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile2 = gcnew  StreamWriter("upload/timers/Neon2/Ne2MON.txt");
			String minOn1 = comboBox47.Text;
			outFile2.Write(minOn1);
			outFile2.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile3 = gcnew  StreamWriter("upload/timers/Neon2/Ne2HOFF.txt");
			String hourOff1 = comboBox45.Text;
			outFile3.Write(hourOff1);
			outFile3.Close();
			this.progressBar1.Increment(25);

				 StreamWriter^ outFile4 = gcnew  StreamWriter("upload/timers/Neon2/Ne2MOFF.txt");
			String minOff1 = comboBox48.Text;
			outFile4.Write(minOff1);
			outFile4.Close();
			this.progressBar1.Increment(25);


		
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Neon2 files generated succesfully \r\n";
*/
			 }

			 else {
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");
				 richTextBox1.Text += " Neon2 Timer is DISABLED \r\n";

			 }	
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////GENERATE NEON_3 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
 if ((Neon3_Enable == true) & (Neon3HON == true) & (Neon3MON == true)&(Neon3HOFF == true)&(Neon3MOFF == true )){
			        StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/Neon3/NE3TIME.txt");
			///////////////////////////////////////////////////////////////////////////////////////	
			outFile.Write("//");
			outFile.Write(DateTime::Now );
		    outFile.Write("\n");
			outFile.Write("//File format created by Charles Galea 2014.");
		    outFile.Write("\n");
			outFile.Write("//This file consists of hours and minutes when timers go on & off.");
		    outFile.Write("\n");
			outFile.Write("//It is supported on AquaSmartControl V2 onwards ");
			outFile.Write("\n");
			outFile.Write("//24 hour format");
			outFile.Write("\n");
			outFile.Write("\n");

			outFile.Write("//NEON 3 TIMER  (ON) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("NE3HON = ");
			String hourOn1 = comboBox39.Text;
			outFile.Write(hourOn1);
			outFile.Write("\n");
			outFile.Write("\n");
	
			outFile.Write("//NEON 3 TIMER  (ON) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("NE3MON = ");
			String minOn1 = comboBox39.Text;
			outFile.Write(minOn1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//NEON 3 TIMER  (OFF) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("NE3HOFF = ");
			String hourOff1 = comboBox37.Text;
			outFile.Write(hourOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//NEON 3 TIMER  (OFF) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("NE3MOFF = ");
			String minOff1 = comboBox40.Text;
			outFile.Write(minOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Close();

			this.progressBar1.Increment(20);

			richTextBox1.Text += (DateTime::Now );
			richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Neon3 files generated succesfully \r\n";	
	/*		

			StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/Neon3/Ne3HON.txt");
			String hourOn1 = comboBox38.Text;
			outFile.Write(hourOn1);
			outFile.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile2 = gcnew  StreamWriter("upload/timers/Neon3/Ne3MON.txt");
			String minOn1 = comboBox39.Text;
			outFile2.Write(minOn1);
			outFile2.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile3 = gcnew  StreamWriter("upload/timers/Neon3/Ne3HOFF.txt");
			String hourOff1 = comboBox37.Text;
			outFile3.Write(hourOff1);
			outFile3.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile4 = gcnew  StreamWriter("upload/timers/Neon3/Ne3MOFF.txt");
			String minOff1 = comboBox40.Text;
			outFile4.Write(minOff1);
			outFile4.Close();
			this.progressBar1.Increment(25);


		
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Neon3 files generated succesfully \r\n";
*/
			 }

			 else {
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");
				 richTextBox1.Text += " Neon3 Timer is DISABLED \r\n";

			 }	
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////GENERATE NIGHT_1 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
 if ((Night1_Enable == true) & (Night1HON == true) & (Night1MON == true)&(Night1HOFF == true)&(Night1MOFF == true )){
		        StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/Night1/NI1TIME.txt");
			///////////////////////////////////////////////////////////////////////////////////////	
			outFile.Write("//");
			outFile.Write(DateTime::Now );
		    outFile.Write("\n");
			outFile.Write("//File format created by Charles Galea 2014.");
		    outFile.Write("\n");
			outFile.Write("//This file consists of hours and minutes when timers go on & off.");
		    outFile.Write("\n");
			outFile.Write("//It is supported on AquaSmartControl V2 onwards ");
			outFile.Write("\n");
			outFile.Write("//24 hour format");
			outFile.Write("\n");
			outFile.Write("\n");

			outFile.Write("//NIGHT 1 TIMER  (ON) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("NI1HON = ");
			String hourOn1 = comboBox42.Text;
			outFile.Write(hourOn1);
			outFile.Write("\n");
			outFile.Write("\n");
	
			outFile.Write("//NIGHT 1 TIMER  (ON) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("NI1MON = ");
			String minOn1 = comboBox43.Text;
			outFile.Write(minOn1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//NIGHT 1 TIMER  (OFF) HOUR VALUE");
			outFile.Write("\n");
			outFile.Write("NI1HOFF = ");
			String hourOff1 = comboBox41.Text;
			outFile.Write(hourOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//NIGHT 1 TIMER  (OFF) MINUTE VALUE");
			outFile.Write("\n");
			outFile.Write("NI1MOFF = ");
			String minOff1 = comboBox44.Text;
			outFile.Write(minOff1);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Close();

			this.progressBar1.Increment(20);

			richTextBox1.Text += (DateTime::Now );
			richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Night1 files generated succesfully \r\n";	
			
	 /*
			StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/Night1/Ni1HON.txt");
			String hourOn1 = comboBox42.Text;
			outFile.Write(hourOn1);
			outFile.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile2 = gcnew  StreamWriter("upload/timers/Night1/Ni1MON.txt");
			String minOn1 = comboBox43.Text;
			outFile2.Write(minOn1);
			outFile2.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile3 = gcnew  StreamWriter("upload/timers/Night1/Ni1HOFF.txt");
			String hourOff1 = comboBox41.Text;
			outFile3.Write(hourOff1);
			outFile3.Close();
			this.progressBar1.Increment(25);

				 StreamWriter^ outFile4 = gcnew  StreamWriter("upload/timers/Night1/Ni1MOFF.txt");
			String minOff1 = comboBox44.Text;
			outFile4.Write(minOff1);
			outFile4.Close();
			this.progressBar1.Increment(25);


		
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Night1 files generated succesfully \r\n";
*/
			 }

			 else {
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");
				 richTextBox1.Text += " Night1 Timer is DISABLED \r\n";

			 }	
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////GENERATE UV_1 TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
 if ((Uv1_Enable == true) & (Uv1HON == true) & (Uv1MON == true)&(Uv1HOFF == true)&(Uv1MOFF == true )){
			
			

			StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/Uv1/Uv1HON.txt");
			String hourOn1 = comboBox53.Text;
			outFile.Write(hourOn1);
			outFile.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile2 = gcnew  StreamWriter("upload/timers/Uv1/Uv1MON.txt");
			String minOn1 = comboBox52.Text;
			outFile2.Write(minOn1);
			outFile2.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile3 = gcnew  StreamWriter("upload/timers/Uv1/Uv1HOFF.txt");
			String hourOff1 = comboBox51.Text;
			outFile3.Write(hourOff1);
			outFile3.Close();
			this.progressBar1.Increment(25);

				 StreamWriter^ outFile4 = gcnew  StreamWriter("upload/timers/Uv1/Uv1MOFF.txt");
			String minOff1 = comboBox54.Text;
			outFile4.Write(minOff1);
			outFile4.Close();
			this.progressBar1.Increment(25);


		
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Uv1 files generated succesfully \r\n";

			 }

			 else {
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");
				 richTextBox1.Text += " Uv1 Timer is DISABLED \r\n";

			 }	
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////GENERATE Uv_2TEXT FILES ON & OFF///////////////////////////////////////////////////////////////
 if ((Uv2_Enable == true) & (Uv2HON == true) & (Uv2MON == true)&(Uv2HOFF == true)&(Uv2MOFF == true )){
			
			

			StreamWriter^ outFile = gcnew  StreamWriter("upload/timers/Uv2/Uv2HON.txt");
			String hourOn1 = comboBox56.Text;
			outFile.Write(hourOn1);
			outFile.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile2 = gcnew  StreamWriter("upload/timers/Uv2/Uv2MON.txt");
			String minOn1 = comboBox57.Text;
			outFile2.Write(minOn1);
			outFile2.Close();
			this.progressBar1.Increment(25);

			 StreamWriter^ outFile3 = gcnew  StreamWriter("upload/timers/Uv2/Uv2HOFF.txt");
			String hourOff1 = comboBox58.Text;
			outFile3.Write(hourOff1);
			outFile3.Close();
			this.progressBar1.Increment(25);

				 StreamWriter^ outFile4 = gcnew  StreamWriter("upload/timers/Uv2/Uv2MOFF.txt");
			String minOff1 = comboBox59.Text;
			outFile4.Write(minOff1);
			outFile4.Close();
			this.progressBar1.Increment(25);


		
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Uv2 files generated succesfully \r\n";

			 }

			 else {
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");
				 richTextBox1.Text += " Uv2 Timer is DISABLED \r\n";

			 }	
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////GENERATE SLAVE UPDATE FILE///////////////////////////////////////////////////////////////
 if ((CheckStatus12 == true) & (RGB1_6 == true) & (RGB7_12 == true)& (PH_TEMP == true) ){
			
	 		StreamWriter^ outFile = gcnew  StreamWriter("upload/Slaves/SLV_NUM.txt");
			outFile.Write("//");
			outFile.Write(DateTime::Now );
		    outFile.Write("\n");
			outFile.Write("//File format created by Charles Galea 2014.");
		    outFile.Write("\n");
			outFile.Write("//This file consists of Slave numbers attached to main controllers.");
		    outFile.Write("\n");
			outFile.Write("//It is supported on AquaSmartControl V2 onwards ");
			
			outFile.Write("\n");
			outFile.Write("\n");

			outFile.Write("//RGB SLAVE CHANNEL 1 to 6 SLAVE NUMBER");
			outFile.Write("\n");
			outFile.Write("SLAVE1 = ");
			String slv1 = comboBox62.Text;
			outFile.Write(slv1);
			outFile.Write("\n");
			outFile.Write("\n");
	
			outFile.Write("//RGB SLAVE CHANNEL 7 to 12 SLAVE NUMBER");
			outFile.Write("\n");
			outFile.Write("SLAVE2 = ");
			String slv2 = comboBox55.Text;
			outFile.Write(slv2);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//PH & TEMP SLAVE NUMBER");
			outFile.Write("\n");
			outFile.Write("SLAVE3 = ");
			String slv3 = comboBox61.Text;
			outFile.Write(slv3);
			outFile.Write("\n");
			outFile.Write("\n");
			
			
			
			outFile.Close();

			this.progressBar1.Increment(20);

			richTextBox1.Text += (DateTime::Now );
			richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Slave update file generated succesfully \r\n";


			 }

			 else {
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");
			richTextBox1.Text += " update is DISABLED \r\n";

			 }	
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////GENERATE RTC UPDATE FILE///////////////////////////////////////////////////////////////
 if ((CheckStatus11 == true) & (day == true) & (month == true)& (year == true)& (hour == true)& (minute == true) ){
			
	 		StreamWriter^ outFile = gcnew  StreamWriter("upload/RTC.txt");
			outFile.Write("//");
			outFile.Write(DateTime::Now );
		    outFile.Write("\n");
			outFile.Write("//File format created by Charles Galea 2014.");
		    outFile.Write("\n");
			outFile.Write("//This file consists of RTC update date.");
		    outFile.Write("\n");
			outFile.Write("//It is supported on AquaSmartControl V2 onwards ");
			
			outFile.Write("\n");
			outFile.Write("\n");

			outFile.Write("//RTC DAY");
			outFile.Write("\n");
			outFile.Write("DAY = ");
			String RTCD = comboBox31.Text;
			outFile.Write(RTCD);
			outFile.Write("\n");
			outFile.Write("\n");
	
			outFile.Write("//RTC MONTH");
			outFile.Write("\n");
			outFile.Write("MONTH = ");
			String RTCMO = comboBox29.Text;
			outFile.Write(RTCMO);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//RTC YEAR");
			outFile.Write("\n");
			outFile.Write("YEAR = ");
			String RTCY = comboBox30.Text;
			outFile.Write(RTCY);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Write("//RTC HOUR");
			outFile.Write("\n");
			outFile.Write("HOUR = ");
			String RTCH = comboBox4.Text;
			outFile.Write(RTCH);
			outFile.Write("\n");
			outFile.Write("\n");

			outFile.Write("//RTC MINUTE");
			outFile.Write("\n");
			outFile.Write("MINUTE = ");
			String RTCM = comboBox3.Text;
			outFile.Write(RTCM);
			outFile.Write("\n");
			outFile.Write("\n");
			
			outFile.Close();

			this.progressBar1.Increment(20);

			richTextBox1.Text += (DateTime::Now );
			richTextBox1.Text += ("  ");			
			richTextBox1.Text += " Slave update file generated succesfully \r\n";
		

			 }

			 else {
			 richTextBox1.Text += (DateTime::Now );
			 richTextBox1.Text += ("  ");
			richTextBox1.Text += " update is DISABLED \r\n";
			

			 }	