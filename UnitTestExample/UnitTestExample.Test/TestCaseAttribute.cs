using System;

namespace UnitTestExample.Test
{
    internal class TestCaseAttribute : Attribute
    {
        private string v1;
        private bool v2;

        public TestCaseAttribute(string v1, bool v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}