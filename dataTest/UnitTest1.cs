using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutAccounting;
using dataBaseConnection;
using dataBaseConnection;
using OutAccounting.forms;
using OutAccounting.other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System;

namespace dataTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            dataBase dataBase = new dataBase();
            dataBase.openConnection();
            dataBase.closeConnection();

        }
    }
}
