using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    public class DieMock : IDie
    {
        private int _result;
        public int RollIsColledNTimes { get; set; }

        public DieMock(int result)
        {
            _result = result;
        }

        public int Roll()
        {
            RollIsColledNTimes++;
            return _result;
        }
    }
}
