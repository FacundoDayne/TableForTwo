using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableForTwo
{
    internal class ReservationInformation
    {
        public int ID = 0;
        public string UserName;
        public DateTime Date;
        public int TableNumber;
        public int Members;
        public int StartTime;
        public int EndTime;

        public ReservationInformation(string UserName, DateTime Date, int TableNumber, int Members, int StartTime, int EndTime)
        {
            this.UserName = UserName;
            this.Date = Date;
            this.TableNumber = TableNumber;
            this.Members = Members;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
        }
    }
}
