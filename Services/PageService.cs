using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace wpf_todo_app.Services
{
    public class PageService
    {
        public event Action<Page> PageChanged;
        public void ChangePage(Page page) => PageChanged?.Invoke(page);
    }
}
