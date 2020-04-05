using System;
using System.Collections.Generic;
using System.Text;

namespace cash_counter
{
    interface bank
    {
        int depositCash(int cash, int ubalance);//user deposit cash
        int withdrawCash(int cash, int ubalance);//user withdraw cash
    }
}
