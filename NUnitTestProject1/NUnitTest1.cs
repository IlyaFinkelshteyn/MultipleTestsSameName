﻿using System;
using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void ClassicNunitTestMethod()
        {
            Assert.True(1 == 1);
        }
    }
}