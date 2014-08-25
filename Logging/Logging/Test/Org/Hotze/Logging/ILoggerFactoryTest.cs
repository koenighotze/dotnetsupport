using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Org.Hotze.Logging
{
    [TestFixture]
    public class ILoggerFactoryTest
    {
        [Test]
        public void testGetLoggerReturnsDifferentLoggers()
        {
            Assert.AreNotSame(ILoggerFactory.getLogger("foo"),
                              ILoggerFactory.getLogger("bar"),
                              "Must not the same instance for the same name");
        }


        [Test]
        public void testGetLoggerReturnsSameInstance()
        {            
            Assert.AreSame(ILoggerFactory.getLogger("foo"), 
                           ILoggerFactory.getLogger("foo"),
                           "Must return the same instance for the same name");            
        }
        
        [Test]
        public void testGetLoggerByTypeUsesName()
        {                        
            Assert.AreSame(ILoggerFactory.getLogger(typeof(ILoggerFactoryTest)),
                           ILoggerFactory.getLogger("ILoggerFactoryTest"),
                           "Must use type name");
        }
    }
}
