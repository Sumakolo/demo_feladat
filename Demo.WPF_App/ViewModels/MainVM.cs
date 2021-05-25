using Demo.Data;
using Demo.Logic;
using Demo.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo.WPF_App.ViewModels
{
    class MainVM : ViewModelBase
    {
        EmployeeRepository employeeRepository;
        EmployeeLogic empLogic;
        private ObservableCollection<Employee> employees;

        /// <summary>
        /// Property for a collection for employees.
        /// </summary>
        public ObservableCollection<Employee> Employees 
        {
            get { return this.employees; }
            set { this.Set(ref this.employees, value); }
        }
        public ICommand LoadUsers { get; set; }

        /// <summary>
        /// Constructor for the MainVM viewmodel.
        /// </summary>
        public MainVM()
        {
            employeeRepository = new EmployeeRepository();
            empLogic = new EmployeeLogic(employeeRepository);
            this.LoadUsers = new RelayCommand(() => this.Employees = new ObservableCollection<Employee>(this.empLogic.GetAll()));
        }
    }
}
