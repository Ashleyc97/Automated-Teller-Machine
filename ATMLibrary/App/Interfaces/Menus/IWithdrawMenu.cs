﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibrary.App.Interfaces.Menus
{
    public interface IWithdrawMenu
    {
        Task DisplayWithdrawMenu();
        Task SelectWithdrawOption(int _option);
    }
}
