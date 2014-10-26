using System;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    public class Call : IComparable<Call>
    {
        private DateTime date;
        private string dialedNumber;
        private TimeSpan duration = TimeSpan.Zero;

        public Call(DateTime date, string dialedNumber, TimeSpan duration)
        {
            this.Date = date;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get { return this.date; }
            set 
            {
                if (value == null)
                    throw new ArgumentNullException("Date and time cannot be null!");
               
                this.date = value; 
            }
        }

        public string DialedNumber
        {
            get { return this.dialedNumber; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Dialed number cannot be null!");
                
                this.dialedNumber = value; 
            }
        }

        public TimeSpan Duration
        {
            get { return this.duration; }
            set 
            { 
                if (value == TimeSpan.Zero)
                    throw new ArgumentNullException("Duration time cannot be null!");
                
                this.duration = value; 
            }
        }

        public int CompareTo(Call other)
        {
            return (int)(this.Duration - other.Duration).TotalSeconds;
        }

        public override string ToString()
        {
            StringBuilder callInfo = new StringBuilder();
            
            callInfo.Append(string.Format("Number: {0} | Duration: {1} | Date: {2}",
                this.DialedNumber, this.Duration, this.Date));

            return callInfo.ToString();
        }
    }
}