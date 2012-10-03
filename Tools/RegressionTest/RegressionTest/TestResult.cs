﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegressionTest
{
    public class TestResult
    {
        public short alternative;
        public short output;
        public short diffCode;
        public short cmakeCode;
        public short msbuildCode;

        public TestResult()
        {
            output = -1;
            diffCode = -1;
            cmakeCode = -1;
            msbuildCode = -1;
            alternative = -1;
        }

        public bool AllSuccess()
        {
            return output == 0 && /*diffCode == 0 &&*/ cmakeCode == 0 && msbuildCode == 0 && alternative == 0;
        }
    }
}
