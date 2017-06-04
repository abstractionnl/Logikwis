using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFluent;
using Xunit;

namespace Logikwis.Test
{
    public class ArrayItemPickerTest
    {
        [Fact]
        public void WhenListIsEmptyReturnEmptyList()
        {
            var list = new List<int>();
            var returned = list.PickList();

            Check.That(returned).IsEmpty();
        }

        [Fact]
        public void WithOneItemReturnOnePickedItemAndOtherShouldBeEmpty()
        {
            var list = new List<int>() { 1 };
            var returned = list.PickList().ToList();

            Check.That(returned).HasSize(1);
            Check.That(returned.ElementAt(0).Current).Equals(1);
            Check.That(returned.ElementAt(0).Others).IsEmpty();
        }

        [Fact]
        public void WitTwoItemsReturnTwoPickedItemsAndOtherShouldContainNonReturned()
        {
            var list = new List<int>() { 1, 2 };
            var returned = list.PickList().ToList();

            Check.That(returned).HasSize(2);

            Check.That(returned.ElementAt(0).Others).Contains(list.Except(new[] {returned.ElementAt(0).Current}));
            Check.That(returned.ElementAt(1).Others).Contains(list.Except(new[] { returned.ElementAt(1).Current }));
        }

        [Theory]
        [InlineData(0), InlineData(1), InlineData(2), InlineData(147)]
        public void ListShouldEqualInputSize(int size)
        {
            var input = Enumerable.Range(0, size);
            var returned = input.PickList().ToList();

            Check.That(returned).HasSize(size);
        }

        [Theory]
        [InlineData(0), InlineData(1), InlineData(2), InlineData(147)]
        public void OthersShouldEqualInputSizeMinusOne(int size)
        {
            var input = Enumerable.Range(0, size);
            var returned = input.PickList().ToList();

            foreach (var item in returned)
                Check.That(item.Others).HasSize(size - 1);
        }
    }
}
