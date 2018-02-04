using System;
using System.Collections.Generic;
using Autofac;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace rental.test
{
    [TestClass]
    public class RatesManagerFixture
    {
        private IContainer container = null;

        public IContainer Container 
        {
            get 
            {
                if (container == null) 
                {
                    var builder = new ContainerBuilder();

                    builder.RegisterType<RatesManager>();

                    var mockRatesProvider = A.Fake<IRatesProvider>();
                    builder.RegisterInstance(mockRatesProvider);

                    container = builder.Build();
                }
                return container;
            }
        }

        private double getBikesCost(int bikesCount, double duration)
        {
            var manager = Container.Resolve<RatesManager>();
            List<IRateElement> elements = new List<IRateElement>();

            for(int i = 0; i < bikesCount; i++)
            {
                elements.Add(new Bike());
            }

            var rate = manager.GetBestRate(elements, DateTime.Now, duration);

            return rate.GetCost(duration);
        }

        [TestMethod]
        public void OneBikeByHourTest()
        {
            double cost = getBikesCost(1, 2);

            // Assert
            Assert.AreEqual(2 * 5, cost);
        }

        [TestMethod]
        public void OneBikeByDayTest()
        {
            double duration = 2 * 24;

            double cost = getBikesCost(1, duration);

            // Assert
            Assert.AreEqual(2 * 20, cost);
        }

        [TestMethod]
        public void OneBikeByWeekTest()
        {
            double duration = 2 * 7 * 24;

            double cost = getBikesCost(1, duration);

            // Assert
            Assert.AreEqual(2 * 60, cost);
        }

        [TestMethod]
        public void FamilyPromotionByHourTest()
        {
            double cost = getBikesCost(4, 2);

            // Assert
            Assert.AreEqual((4 * 2 * 5) * 0.7, cost);
        }
    }
}
