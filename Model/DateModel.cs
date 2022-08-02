using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace wpf_todo_app.Model
{
    public class DateModel
    {
        public string DayOfWeek { get; set; }
        public int DateOfMonth { get; set; }
        public Page TargetPage { get; set; }
    }
}
