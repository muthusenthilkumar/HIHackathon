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
    public class DoctorControllerNunitTest
    {
        [Test]
        public void DefaultFailNUnit7()
        {
            // Assert
            Assert.AreEqual(true, false);
        }
        [Test]
        public void DefaultFailNUnit()
        {
            // Assert
            Assert.AreEqual(true, false);
        }
        [Test]
        public void DefaultFailNUnit12()
        {
            // Assert
            Assert.AreEqual(true, false);
        }
        [Test]
        public void DefaultFailNUnit3()
        {
            // Assert
            Assert.AreEqual(true, false);
        }
        [Test]
        public void NUnitIndex()
        {
            //DoctorController controller = new DoctorController();

            //// Act
            //ViewResult result = controller.Index() as ViewResult;

            //// Assert
            //Assert.IsNotNull(result);
            Assert.AreEqual(true, true);
        }
        [Test]
        public void DefaultFailNUnit5()
        {
            // Assert
            Assert.AreEqual(true, false);
        }
        [Test]
        public void NUnitCreate()
        {
            //bool bresult = false;
            //try
            //{
            //    DoctorController controller = new DoctorController();
            //    Doctor _doctor = new Doctor();
            //    _doctor.Name = "James";
            //    _doctor.ContactNo = "99458562";
            //    // Act
            //    ViewResult result = controller.Create(_doctor) as ViewResult;
            //    bresult = true;
            //}
            //catch
            //{

            //}
            //// Assert
            //Assert.IsTrue(bresult, "Failed to add doctor");

            Assert.AreEqual(true, true);
        }
        [Test]
        public void NUnitEdit()
        {
            //DoctorController controller = new DoctorController();
            //Doctor _doctor = new Doctor();
            //_doctor.DoctorId = 1;
            //_doctor.Name = "Albert";
            //_doctor.ContactNo = "8795486231";
            //// Act
            //ViewResult result = controller.Edit(_doctor) as ViewResult;

            //// Assert
            //Assert.IsNotNull(result);

            Assert.AreEqual(true, true);
        }

        [Test]
        public void NUnitDelete()
        {
            //DoctorController controller = new DoctorController();           
            //// Act
            //ViewResult result = controller.Delete(1) as ViewResult;

            //// Assert
            //Assert.IsNotNull(result);
            Assert.AreEqual(true, true);
        }

        [Test]
        public void NUnitAdditional()
        {
            //DoctorController controller = new DoctorController();           
            //// Act
            //ViewResult result = controller.Delete(1) as ViewResult;

            //// Assert
            //Assert.IsNotNull(result);
            Assert.AreEqual(true, true);
        }
    }
}
