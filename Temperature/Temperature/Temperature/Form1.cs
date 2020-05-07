using DirectX.Capture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature
{
    public partial class Form1 : Form
    {
        //Webcam
        private Capture capture = null;
        private bool _captureInProgress;

        //Search chamber parameter
        static List<Temperature_Data> temperatureList = new List<Temperature_Data> { };
        Queue<string> temperatureString = new Queue<string> { };
        double targetTemperature = 0;
        private bool StartButtonPressed = false;//true = 按下START//false = 按下STOP//
        System.Timers.Timer duringTimer = new System.Timers.Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_temperatureAdd_Click(object sender, EventArgs e)
        {
            if (StartButtonPressed == false)
            {
                if (!_captureInProgress)
                {
                    _captureInProgress = true;
                    OnOffCamera();
                }

                Temperature_Data.initialTemperature = Int16.Parse(textBox_temperatureFrom.Text);
                Temperature_Data.finalTemperature = Int16.Parse(textBox_temperatureTo.Text);
                //Temperature_Data.temperatureChannel = columns_serial.Substring(columns_serial.IndexOf("Temperature") + 11, columns_serial.IndexOf("=") - columns_serial.IndexOf("Temperature") - 11);
                if (textBox_temperatureAddrange.Text.Contains("-"))
                    Temperature_Data.addTemperature = float.Parse("-" + textBox_temperatureAddrange.Text);
                else
                    Temperature_Data.addTemperature = float.Parse(textBox_temperatureAddrange.Text);

                float addTemperatureInt = Temperature_Data.addTemperature;

                if (addTemperatureInt < 0)
                {
                    for (float i = Temperature_Data.initialTemperature; i >= Temperature_Data.finalTemperature; i += addTemperatureInt)
                    {
                        double conditionList = Convert.ToDouble(i);
                        temperatureList.Add(new Temperature_Data(conditionList, false, false));
                    }
                }
                else
                {
                    for (float i = Temperature_Data.initialTemperature; i <= Temperature_Data.finalTemperature; i += addTemperatureInt)
                    {
                        double conditionList = Convert.ToDouble(i);
                        temperatureList.Add(new Temperature_Data(conditionList, false, false));
                    }
                }

                int duringTimeInt = Temperature_Data.temperatureDuringtime;
                if (textBox_Timer.Text.Contains("m"))
                    duringTimeInt = Int16.Parse(textBox_Timer.Text.Replace("m","")) * 60000;
                else
                    duringTimeInt = Int16.Parse(textBox_Timer.Text);

                if (duringTimeInt > 0)
                {
                    // Create a timer and set a two second interval.
                    duringTimer.Interval = duringTimeInt;

                    // Hook up the Elapsed event for the timer. 
                    duringTimer.Elapsed += new System.Timers.ElapsedEventHandler(duringTimedEvent);

                    // Have the timer fire repeated events (true is the default)
                    duringTimer.AutoReset = true;

                    // Start the timer
                    duringTimer.Enabled = true;
                }

                timer_log.Start();
                StartButtonPressed = true;
                button_temperatureAdd.Text = "Stop";
            }
            else
            {
                duringTimer.Enabled = false;
                timer_log.Stop();
                StartButtonPressed = false;
                button_temperatureAdd.Text = "Start";
            }
        }

        private void duringTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Jes();
            UpdateUI("Timer_matched", label_Command);
            Console.WriteLine("Timer: ~~~~~~~~~Timer matched. Take a picture.~~~~~~~~~");
        }


        private void OnOffCamera()//啟動攝影機//
        {
            if (_captureInProgress == true)
            {
                Camstart();
            }

            if (_captureInProgress == false && capture != null)
            {
                capture.Stop();
                capture.Dispose();
            }
        }

        private void Camstart()
        {
            try
            {
                Filters filters = new Filters();
                Filter f;

                List<string> video = new List<string> { };
                for (int c = 0; c < filters.VideoInputDevices.Count; c++)
                {
                    f = filters.VideoInputDevices[c];
                    video.Add(f.Name);
                }

                List<string> audio = new List<string> { };
                for (int j = 0; j < filters.AudioInputDevices.Count; j++)
                {
                    f = filters.AudioInputDevices[j];
                    audio.Add(f.Name);
                }

                int scam, saud, VideoNum, AudioNum = 0;
                scam = 0;
                saud = 0;
                VideoNum = 0;
                AudioNum = 0;

                if (filters.VideoInputDevices.Count < VideoNum ||
                    filters.AudioInputDevices.Count < AudioNum)
                {
                    MessageBox.Show("Please reset video or audio device and select OK.", "Camera Status Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //button_Setting.PerformClick();
                }
                else
                {
                    capture = new Capture(filters.VideoInputDevices[scam], filters.AudioInputDevices[saud]);
                    try
                    {
                        capture.FrameSize = new Size(2304, 1296);
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message.ToString(), "Webcam does not support 2304*1296!\n\r");
                        try
                        {
                            capture.FrameSize = new Size(1920, 1080);
                        }
                        catch (Exception ex1)
                        {
                            Console.Write(ex1.Message.ToString(), "Webcam does not support 1920*1080!\n\r");
                            try
                            {
                                capture.FrameSize = new Size(1280, 720);
                            }
                            catch (Exception ex2)
                            {
                                Console.Write(ex2.Message.ToString(), "Webcam does not support 1280*720!\n\r");
                                try
                                {
                                    capture.FrameSize = new Size(640, 480);
                                }
                                catch (Exception ex3)
                                {
                                    Console.Write(ex3.Message.ToString(), "Webcam does not support 640*480!\n\r");
                                    try
                                    {
                                        capture.FrameSize = new Size(320, 240);
                                    }
                                    catch (Exception ex4)
                                    {
                                        Console.Write(ex4.Message.ToString(), "Webcam does not support 320*240!\n\r");
                                    }
                                }
                            }
                        }
                    }
                    capture.CaptureComplete += new EventHandler(OnCaptureComplete);
                }

                if (capture.PreviewWindow == null)
                {
                    try
                    {
                        capture.PreviewWindow = panelVideo;
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message.ToString(), "Please set the supported resolution!\n\r");
                    }
                }
                else
                {
                    capture.PreviewWindow = null;
                }
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Camera is disconnected unexpectedly!\r\nPlease go to Settings to reload the device list.", "Connection Error");
            };
        }

        private void OnCaptureComplete(object sender, EventArgs e)
        {
            // Demonstrate the Capture.CaptureComplete event.
            // Debug.WriteLine("Capture complete.");
        }

        #region -- 拍照 --
        private void Jes() => Invoke(new EventHandler(delegate { Myshot(); }));

        private void Myshot()
        {
            //debug_text = string.Concat(debug_text, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff,") + "Start the Myshot function," + "\r\n");
            capture.FrameEvent2 += new Capture.HeFrame(CaptureDone);
            capture.GrapImg();
            //debug_text = string.Concat(debug_text, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff,") + "Stop the Myshot function," + "\r\n");
        }

        // 複製原始圖片
        protected Bitmap CloneBitmap(Bitmap source)
        {
            //debug_text = string.Concat(debug_text, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff,") + "CloneBitmap function," + "\r\n");
            return new Bitmap(source);
        }

        private void CaptureDone(System.Drawing.Bitmap e)
        {
            //debug_text = string.Concat(debug_text, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff,") + "Start the CaptureDone function," + "\r\n");
            capture.FrameEvent2 -= new Capture.HeFrame(CaptureDone);
            string fName = Application.StartupPath;
            //string ngFolder = "Schedule" + Global.Schedule_Num + "_NG";

            //圖片印字
            Bitmap newBitmap = CloneBitmap(e);
            //newBitmap = CloneBitmap(e);
            panelVideo.Image = newBitmap;

            Graphics bitMap_g = Graphics.FromImage(panelVideo.Image);//底圖
            Font Font = new Font("Microsoft JhengHei Light", 16, FontStyle.Bold);
            Brush FontColor = new SolidBrush(Color.Red);

            Font.Dispose();
            FontColor.Dispose();
            bitMap_g.Dispose();

            string t = fName + "\\" + "pic-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "(" + label_Command.Text + ").png";
            panelVideo.Image.Save(t);
            //debug_text = string.Concat(debug_text, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff,") + "Save the CaptureDone Picture," + "\r\n");
            //debug_text = string.Concat(debug_text, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff,") + "Stop the CaptureDone function," + "\r\n");
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Filters filters = new Filters();
                Filter f;

                List<string> cameraDeviceList = new List<string> { };
                for (int c = 0; c < filters.VideoInputDevices.Count; c++)
                {
                    f = filters.VideoInputDevices[c];
                    comboBox_CameraDevice.Items.Add(f.Name);
                    cameraDeviceList.Add(f.Name);
                }
                string cameraDevice = String.Join(",", cameraDeviceList.ToArray());

                if (comboBox_CameraDevice.Text == "" && filters.VideoInputDevices.Count > 0)
                {
                    comboBox_CameraDevice.SelectedIndex = filters.VideoInputDevices.Count - 1;
                }

                for (int j = 0; j < filters.AudioInputDevices.Count; j++)
                {
                    f = filters.AudioInputDevices[j];
                    comboBox_CameraAudio.Items.Add(f.Name);
                }

                if (comboBox_CameraAudio.Text == "" && filters.AudioInputDevices.Count > 0)
                {
                    comboBox_CameraAudio.SelectedIndex = filters.AudioInputDevices.Count - 1;
                }

                comboBox_Tempsymbol.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString(), "Please set the camera!\n\r");
            }
        }

        private void timer_log_Tick(object sender, EventArgs e)
        {
            if (temperatureString.Count() > 0)
            {
                string tempStr = temperatureString.Dequeue();
                string tempSubstring = String.Format(tempStr);
                double digit = 10;
                double currentTemperature = Math.Round(Convert.ToDouble(Convert.ToInt32(tempSubstring)) / digit, 0, MidpointRounding.AwayFromZero);
                foreach (Temperature_Data item in temperatureList)
                {
                    if (item.temperatureList == currentTemperature &&
                        item.temperatureShot == true)
                    {
                        targetTemperature = currentTemperature;
                        Thread.Sleep(10);
                        Jes();
                        label_Command.Text = "Condition_" + targetTemperature + "_SHOT_" + currentTemperature;
                        Console.WriteLine("Temperature: " + currentTemperature + "~~~~~~~~~Temperature matched. Take a picture.~~~~~~~~~");
                    }
                    else if (item.temperatureList == currentTemperature &&
                             item.temperaturePause == true)
                    {
                        targetTemperature = currentTemperature;
                        label_Command.Text = "Condition_" + targetTemperature + "_PAUSE_" + currentTemperature;
                        Console.WriteLine("Temperature: " + currentTemperature + "~~~~~~~~~Temperature matched. Pause the schedule.~~~~~~~~~");
                    }
                    else
                    {
                        Console.WriteLine("Temperature: " + currentTemperature + "~~~~~~~~~Temperature didn't match. Do nothing.~~~~~~~~~");
                    }
                }
            }
        }

        private void numericUpDown_temperatureNow_ValueChanged(object sender, EventArgs e)
        {
            string tempStr = numericUpDown_temperatureNow.Value.ToString("0000");
            string tempSubstring = String.Format(tempStr);
            double digit = 10;
            double currentTemperature = Math.Round(Convert.ToDouble(Convert.ToInt32(tempSubstring)) / digit, 0, MidpointRounding.AwayFromZero);
            if (targetTemperature != currentTemperature)
            {
                temperatureString.Enqueue(tempStr);
                targetTemperature = currentTemperature;
            }
        }

        private void checkBox_Shot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Shot.Checked == true)
            {
                foreach (Temperature_Data item in temperatureList)
                {
                    item.temperatureShot = true;
                }
            }
            else
            {
                foreach (Temperature_Data item in temperatureList)
                {
                    item.temperatureShot = false;
                }
            }
        }

        private void checkBox_Pause_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Pause.Checked == true)
            {
                foreach (Temperature_Data item in temperatureList)
                {
                    item.temperaturePause = true;
                }
            }
            else
            {
                foreach (Temperature_Data item in temperatureList)
                {
                    item.temperaturePause = false;
                }
            }
        }

        //執行緒控制label.text
        private delegate void UpdateUICallBack(string value, Control ctl);
        private void UpdateUI(string value, Control ctl)
        {
            if (InvokeRequired)
            {
                UpdateUICallBack uu = new UpdateUICallBack(UpdateUI);
                Invoke(uu, value, ctl);
            }
            else
            {
                ctl.Text = value;
            }
        }

        private string generate_empty_data(int ch)
        {
            if ((ch < 1) || (ch > 12))
                return "";

            string return_str = "\x02"+"4";
            if (ch < 10)
            {
                return_str += (char)(ch + '0');
            }
            else
            {
                return_str += (char)(ch + 'A' - 10);
            }

            return_str += "01010000";
            return_str += "\x18\x18\x18\x18\r";

            return return_str;
        }

        private string generate_temperature_data(int ch, float temperature, bool Celsius = true)
        {

            if ((ch < 1) || (ch > 12))
                return "";

            string return_str = "\x02" + "4";
            if (ch < 10)
            {
                return_str += (char)(ch + '0');
            }
            else
            {
                return_str += (char)(ch + 'A' - 10);
            }

            if(Celsius)
            {
                return_str += "01";
            }
            else
            {
                return_str += "02";
            }

            int output_temp = (int)Math.Round(temperature * 10, 0);

            if(output_temp >= 0) // polarity
            {
                return_str += "0";
            }
            else
            {
                return_str += "1";
            }

            return_str += "1"; // dp is fixed to 1

            return_str += String.Format("{0,8:00000000}", Math.Abs(output_temp));

            return_str += "\r";

            return return_str;
        }

        List<int> temperature_list = new List<int>();

        private void button_create_Click(object sender, EventArgs e)
        {
            float from_value = float.Parse(textBox_temperatureFrom.Text);
            float to_value = float.Parse(textBox_temperatureTo.Text);
            float add_value = float.Parse(textBox_temperatureAddrange.Text);
            float current_value = 0;

            string t = Application.StartupPath + "\\_TemperatureLog_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            StreamWriter MYFILE = new StreamWriter(t, false, Encoding.UTF8);

            if (from_value < to_value)
            {
                current_value = from_value;
                while (current_value <= to_value)
                {
                    string Temperaturelog;

                    for (int channel = 1; channel < 13; channel++)
                    {
                        if (temperature_list.Contains(channel))
                        {
                            Temperaturelog = generate_temperature_data(channel, (float)current_value);
                        }
                        else
                        {
                            Temperaturelog = generate_empty_data(channel);
                        }
                        MYFILE.Write(Temperaturelog);
                    }
                    current_value += add_value;
                }
            }
            else
            {
                current_value = from_value;
                while (current_value >= to_value)
                {
                    string Temperaturelog;

                    for (int channel = 1; channel < 13; channel++)
                    {
                        if (temperature_list.Contains(channel))
                        {
                            Temperaturelog = generate_temperature_data(channel, (float)current_value);
                        }
                        else
                        {
                            Temperaturelog = generate_empty_data(channel);
                        }
                        MYFILE.Write(Temperaturelog);
                    }
                    current_value -= add_value;
                }
            }

            MYFILE.Close();
        }

        private void checkBox_ch1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ch1.Checked == true)
                temperature_list.Add(1);
            else
                temperature_list.Remove(1); 
        }

        private void checkBox_ch2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ch2.Checked == true)
                temperature_list.Add(2);
            else
                temperature_list.Remove(2);
        }

        private void checkBox_ch3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ch3.Checked == true)
                temperature_list.Add(3);
            else
                temperature_list.Remove(3);
        }

        private void checkBox_ch4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ch4.Checked == true)
                temperature_list.Add(4);
            else
                temperature_list.Remove(4);
        }

        private void checkBox_ch5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ch5.Checked == true)
                temperature_list.Add(5);
            else
                temperature_list.Remove(5);
        }

        private void checkBox_ch6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ch6.Checked == true)
                temperature_list.Add(6);
            else
                temperature_list.Remove(6);
        }

        private void checkBox_ch7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ch7.Checked == true)
                temperature_list.Add(7);
            else
                temperature_list.Remove(7);
        }

        private void checkBox_ch8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ch8.Checked == true)
                temperature_list.Add(8);
            else
                temperature_list.Remove(8);
        }

        private void checkBox_ch9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ch9.Checked == true)
                temperature_list.Add(9);
            else
                temperature_list.Remove(9);
        }

        private void checkBox_cha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cha.Checked == true)
                temperature_list.Add(10);
            else
                temperature_list.Remove(10);
        }

        private void checkBox_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_chb.Checked == true)
                temperature_list.Add(11);
            else
                temperature_list.Remove(11);
        }

        private void checkBox_chc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_chc.Checked == true)
                temperature_list.Add(12);
            else
                temperature_list.Remove(12);
        }
    }


    class Temperature_Data
    {
        public Temperature_Data(double list, bool shot, bool pause)
        {
            temperatureList = list;
            temperatureShot = shot;
            temperaturePause = pause;
        }

        public static string temperatureChannel
        {
            get; set;
        }

        public static float addTemperature
        {
            get; set;
        }

        public static int initialTemperature
        {
            get; set;
        }

        public static int finalTemperature
        {
            get; set;
        }

        public static int temperatureDuringtime
        {
            get; set;
        }

        public double temperatureList
        {
            get; set;
        }

        public bool temperatureShot
        {
            get; set;
        }

        public bool temperaturePause
        {
            get; set;
        }
    }
}
