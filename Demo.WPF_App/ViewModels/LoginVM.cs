using Demo.Logic;
using Demo.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo.WPF_App.ViewModels
{
    class LoginVM : ViewModelBase
    {
        EmployeeRepository employeeRepository;
        EmployeeLogic empLogic;
        private string empUserName;
        private string empPassword;

        /// <summary>
        /// Binded employee username property.
        /// </summary>
        public string EmpUserName
        {
            get { return empUserName; }
            set { this.Set(ref this.empUserName, value); }
        }

        /// <summary>
        /// Binded employee password property.
        /// </summary>
        public string EmpPassword
        {
            get { return empPassword; }
            set { this.Set(ref this.empPassword, value); }
        }

        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// Constructor for the LoginVM viewmodel.
        /// </summary>
        public LoginVM()
        {
            employeeRepository = new EmployeeRepository();
            empLogic = new EmployeeLogic(employeeRepository);
            this.LoginCommand = new RelayCommand(() => this.empLogic.GetEmployee(EmpUserName, EmpPassword));
        }
    }
}
