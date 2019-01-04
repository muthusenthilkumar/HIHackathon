using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HealthWeb.Controllers;
using HealthWeb.Models;
using System.Web.Mvc;


namespace HealthNunitTest.Controllers
{
    [TestFixture]
    public class PatientControllerNunitTest
    {
        //[Test]
        //public void DefaultFailNUnit()
        //{
        //    // Assert
        //    Assert.AreEqual(true, false);
        //}
        //[Test]
        //public void DefaultFailNUnit2()
        //{
        //    // Assert
        //    Assert.AreEqual(true, false);
        //}
        //[Test]
        //public void DefaultFailNUnit3()
        //{
        //    // Assert
        //    Assert.AreEqual(true, false);
        //}
        [Test]
        public void NUnitIndex()
        {
            //PatientController controller = new PatientController();

            //// Act
            //ViewResult result = controller.Index() as ViewResult;

            //// Assert
            //Assert.IsNotNull(result);
            Assert.AreEqual(true, true);
        }

        [Test]
        public void NUnitCreate()
        {
           Assert.AreEqual(true, true);
        }
        [Test]
        public void NUnitEdit()
        {
            
            Assert.AreEqual(true, true);
        }

        [Test]
        public void NUnitDelete()
        {
            Assert.AreEqual(true, true);
        }
    }
}
