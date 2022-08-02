using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using wpf_todo_app.Core;
using wpf_todo_app.Model;
using wpf_todo_app.Pages;
using wpf_todo_app.Services;

namespace wpf_todo_app.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private DateModel _selectedCalendarDay;
        private readonly PageService _pageService;

        public ObservableCollection<DateModel> CalendarDaysItems { get; set; }
        public Page PageSource { get; set; }

        public DateModel SelectedCalendarDay
        {
            get { return _selectedCalendarDay; }
            set
            {
                _selectedCalendarDay = value;
                OnPropertyChanged();

                if (_selectedCalendarDay != null)
                {
                    _pageService.ChangePage(_selectedCalendarDay.TargetPage);
                }
            }
        }

        public MainViewModel(PageService pageService)
        {
            _pageService = pageService;

            CreateTestCalendarDaysItems();

            _pageService.PageChanged += (page) => PageSource = page;
            _pageService.ChangePage(new PageTemplate());
        }

        //Test fabric-method
        public void CreateTestCalendarDaysItems()
        {
            CalendarDaysItems = new ObservableCollection<DateModel>();

            CalendarDaysItems.Add(new DateModel
            {
                DayOfWeek = "Пн",
                DateOfMonth = 1,
                TargetPage = new PageTemplate()
            });

            CalendarDaysItems.Add(new DateModel
            {
                DayOfWeek = "Вт",
                DateOfMonth = 2,
                TargetPage = new PageTemplate()
            });

            CalendarDaysItems.Add(new DateModel
            {
                DayOfWeek = "Ср",
                DateOfMonth = 3,
                TargetPage = new PageTemplate()
            });

            CalendarDaysItems.Add(new DateModel
            {
                DayOfWeek = "Чт",
                DateOfMonth = 4,
                TargetPage = new PageTemplate()
            });

            CalendarDaysItems.Add(new DateModel
            {
                DayOfWeek = "Пт",
                DateOfMonth = 5,
                TargetPage = new PageTemplate()
            });

            CalendarDaysItems.Add(new DateModel
            {
                DayOfWeek = "Сб",
                DateOfMonth = 6,
                TargetPage = new PageTemplate()
            });

            CalendarDaysItems.Add(new DateModel
            {
                DayOfWeek = "Вс",
                DateOfMonth = 7,
                TargetPage = new PageTemplate()
            });
        }

    }
}
