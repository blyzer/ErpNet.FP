﻿using System;
using System.Collections.Generic;
using ErpNet.FP.Print.Core;

namespace ErpNet.FP.Print.Drivers.BgDaisy
{
    /// <summary>
    /// Implements the Bulgarian Daisy Json driver.
    /// </summary>
    /// <seealso cref="ErpNet.FP.IFiscalPrinter" />
    public class BgDaisyJsonFiscalPrinter : IFiscalPrinter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BgDaisyJsonFiscalPrinter"/> class.
        /// </summary>
        public BgDaisyJsonFiscalPrinter(IChannel channel, IDictionary<string, string> options = null)
        {
            //...

        }

        public DeviceInfo DeviceInfo => throw new NotImplementedException();

        public bool IsReady()
        {
            throw new NotImplementedException();
        }

        public PrintInfo PrintMoneyDeposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public PrintInfo PrintMoneyWithdraw(decimal amount)
        {
            throw new NotImplementedException();
        }

        public PrintInfo PrintReceipt(Receipt receipt)
        {
            throw new NotImplementedException();
        }

        public PrintInfo PrintReversalReceipt(Receipt reversalReceipt)
        {
            throw new NotImplementedException();
        }

        public PrintInfo PrintZeroingReport()
        {
            throw new NotImplementedException();
        }

        public void SetupPrinter()
        {
            throw new NotImplementedException();
        }
    }
}