namespace Cars.Tests.JustMock
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using System.Collections.Generic;
    using Cars.Models;


    [TestClass]
    public class CarsControllerTests
    {
        private ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
        {
        }

        public CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IfTryToGetCarDetailsWithWrongIdShoultThrowError()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };
            
            var model = (Car)this.GetModel(() => this.controller.Details(100));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A4", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void SearchingShouldReturnCorrectResult()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var cars = (IList<Car>)this.GetModel(() => this.controller.Search("BMW"));

            Assert.AreEqual(2, cars.Count);
            Assert.AreEqual(2, cars[0].Id);
            Assert.AreEqual("BMW", cars[0].Make);
            Assert.AreEqual("325i", cars[0].Model);
            Assert.AreEqual(2008, cars[0].Year);
        }

        [TestMethod]
        public void SortingByYearShouldReturnCorrectResult()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));

            Assert.AreEqual(4, cars.Count);
            Assert.AreEqual(1, cars[0].Id);
            Assert.AreEqual("Audi", cars[0].Make);
            Assert.AreEqual("A4", cars[0].Model);
            Assert.AreEqual(2005, cars[0].Year);
        }

        [TestMethod]
        public void SortingByMakeShouldReturnCorrectResult()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.AreEqual(4, cars.Count);
            Assert.AreEqual(1, cars[0].Id);
            Assert.AreEqual("Audi", cars[0].Make);
            Assert.AreEqual("A4", cars[0].Model);
            Assert.AreEqual(2005, cars[0].Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortingWithoutParameterShouldThrowException()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort(""));
        }


        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
