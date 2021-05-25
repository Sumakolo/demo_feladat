using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Logic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Demo.Data;
using Demo.Repository;
using GalaSoft.MvvmLight.Command;

namespace Demo.WPF_App.ViewModels
{
    class RegisterVM : ViewModelBase
    {
        private EmployeeRepository employeeRepository;
        private EmployeeLogic employeeLogic;
        

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

        /// <summary>
        /// Binded string property to check if the user wrote his password correctly.
        /// </summary>
        public string EmpPassCheck { get; set; }

        public ICommand AddCommand { get; set; }

        /// <summary>
        /// Constructor for the RegisterVM viewmodel.
        /// </summary>
        public RegisterVM()
        {
            this.employeeRepository = new EmployeeRepository();
            this.employeeLogic = new EmployeeLogic(employeeRepository);
            this.AddCommand = new RelayCommand(() => this.employeeLogic.Create(EmpUserName, EmpPassword,EmpPassCheck));
            
        }
    }
}
