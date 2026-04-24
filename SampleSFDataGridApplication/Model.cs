using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSFDataGridApplication
{
    class EmployeeInfo : INotifyPropertyChanged
    {
        int _id;
        string _firstName;
        string _lastName;
        private string _title;
        double? _salary;
        int _reportsTo;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; RaisePropertyChanged("FirstName"); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; RaisePropertyChanged("LastName"); }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; RaisePropertyChanged("ID"); }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged("ID"); }
        }

        public double? Salary
        {
            get { return _salary; }
            set { _salary = value; RaisePropertyChanged("Salary"); }
        }

        public int ReportsTo
        {
            get { return _reportsTo; }
            set { _reportsTo = value; RaisePropertyChanged("ReportsTo"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
