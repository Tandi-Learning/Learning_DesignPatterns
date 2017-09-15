using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tests
{
    [TestFixture]
    public class Grouper_Tests
    {
        [Test]
        public void Grouping_one_by_one_produces_group_size_one()
        {
            var measurements = CreateMeasurementOfSize(1);

            var grouper = new SizeGrouper(1);
            var groupedResults = grouper.Group(measurements);

            Assert.AreEqual(1, groupedResults.Count);
        }

        [Test]
        public void Grouping_two_by_one_produces_group_size_two()
        {
            var measurements = CreateMeasurementOfSize(2);

            var grouper = new SizeGrouper(1);
            var groupedResults = grouper.Group(measurements);

            Assert.AreEqual(2, groupedResults.Count);
        }

        [Test]
        public void Grouping_four_by_two_produces_group_size_two()
        {
            var measurements = CreateMeasurementOfSize(4);

            var grouper = new SizeGrouper(2);
            var groupedResults = grouper.Group(measurements);

            Assert.AreEqual(2, groupedResults.Count);
        }

        private List<Measurement> CreateMeasurementOfSize(int size)
        {
            var result = new List<Measurement>();
            for (int i = 0; i < size; i++)
            {
                result.Add(new Measurement { HighValue = 10, LowValue = 1 });
            }
            return result;
        }
    }
}
