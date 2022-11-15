using FluentAssertions;
using HotToursLogic.Models;

namespace HotToursLogic.Tests
{
    public class TestsClass
    {
        [Fact]
        public void AddButton()
        {
            Logic cal = new();
            var result = cal.Tours;
            Tour mylist1 = new()
            {
                Direction = "Франция",
                Date = DateTime.Parse("01.10.2002"),
                Nights = 5,
                Price = 100,
                Qty = 2,
                Wifi = true,
                Dop = 100,
                Sum = 1100
            };
            cal.Add(mylist1);
            Assert.Equal(mylist1, result[0]);
        }

        [Fact]
        public void ChangeButton()
        {
            Logic cal = new();
            var result = cal.Tours;
            Tour mylist1 = new()
            {
                Direction = "Франция",
                Date = DateTime.Parse("01.10.2002"),
                Nights = 5,
                Price = 100,
                Qty = 2,
                Wifi = true,
                Dop = 100,
                Sum = 1100
            };
            cal.Add(mylist1);
            Tour mylist2 = new()
            {
                Direction = "Испания",
                Date = DateTime.Parse("01.10.2002"),
                Nights = 5,
                Price = 100,
                Qty = 2,
                Wifi = true,
                Dop = 200,
                Sum = 1200
            };
            cal.Edit(mylist2,0);
            Assert.Equal(mylist2, result[0]);
        }

        [Fact]
        public void DeleteButton()
        {
            Logic cal = new();
            var result = cal.Tours;
            Tour mylist1 = new()
            {
                Direction = "Франция",
                Date = DateTime.Parse("01.10.2002"),
                Nights = 5,
                Price = 100,
                Qty = 2,
                Wifi = true,
                Dop = 100,
                Sum = 1100
            };
            cal.Add(mylist1);
            cal.Delete(mylist1);
            Assert.Empty(result);
        }
    }
}