using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitleSlider
{
    public class Node
    {
        public int Pointer;
        int StartTime;
        int EndTime;
        public String Value;

        public void setStart(String value)
        {
            this.StartTime = convert(value);
        }

        public String getStart()
        {
            return convert(this.StartTime);
        }

        public void setEnd(String value)
        {
            this.EndTime = convert(value);
        }

        public String getEnd()
        {
            return convert(this.EndTime);
        }

        private int convert(String value)
        {
            char[] separator = { ':' };
            String[] values = Form1.mySplit(":", value, 3, true);
            int hour = int.Parse(values[0]);
            int minute = int.Parse(values[1]);
            separator[0] = ',';
            values = Form1.mySplit(",", values[2], 2, true);
            int second = int.Parse(values[0]);
            int milisecond = int.Parse(values[1]);
            return (hour * 3600000) + (minute * 60000) + (second * 1000) + milisecond;
        }

        private String convert(int value)
        {
            int milisecond = value % 1000;
            int second = (value / 1000) % 60;
            int minute = (value / 60000) % 60;
            int hour = value / 3600000;
            String rvalue = (hour < 10 ? "0" + hour.ToString() : hour.ToString()) + ":";
            rvalue += (minute < 10 ? "0" + minute.ToString() : minute.ToString()) + ":";
            rvalue += (second < 10 ? "0" + second.ToString() : second.ToString()) + ",";
            rvalue += milisecond < 10 ? "00" + milisecond.ToString() : (milisecond < 100 ? "0" + milisecond.ToString() : milisecond.ToString());
            return rvalue;
        }

        public bool increase(int value)
        {
            int temp = value + this.EndTime;
            if (temp > 360000000)
            {
                return false;
            }
            else
            {
                this.StartTime += value;
                this.EndTime = temp;
                return true;
            }
        }

        public bool decrease(int value)
        {
            if (value > this.StartTime)
            {
                return false;
            }
            else
            {
                this.StartTime -= value;
                this.EndTime -= value;
                return true;
            }
        }

        public String print()
        {
            String rvalue = this.Pointer.ToString() + "\r\n";
            rvalue += this.getStart() + " --> " + this.getEnd() + "\r\n";
            rvalue += this.Value + "\r\n\r\n";
            return rvalue;
        }
    }
}
