﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EG_2020_3956_Desktop_01
{
   
    public partial class AddUserWindow : Window
    {
        public AddUserWindow(AddUserVM vm)

        {
            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => Close();
        }
    }
}
