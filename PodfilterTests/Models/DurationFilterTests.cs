﻿using Podfilter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PodfilterTests.Models
{
    public class DurationFilterTests
    {
        public static readonly TimeSpan ShortDuration = new TimeSpan(0, 5, 0);
        public static readonly TimeSpan MediumDuration = new TimeSpan(1, 1, 1);
        public static readonly TimeSpan LongDuration = new TimeSpan(3, 40, 50);

        private static IEnumerable<object[]> GenerateAllTimeTestCombinations()
        {
            return new List<object[]>
            {
                new object[]{ MediumDuration, ShortDuration, DurationFilter.DurationFilterMethods.Equals, false },
                new object[]{ MediumDuration, MediumDuration, DurationFilter.DurationFilterMethods.Equals, true },
                new object[]{ MediumDuration, LongDuration, DurationFilter.DurationFilterMethods.Equals, false },

                new object[]{ MediumDuration, ShortDuration, DurationFilter.DurationFilterMethods.Greater, false },
                new object[]{ MediumDuration, MediumDuration, DurationFilter.DurationFilterMethods.Greater, false },
                new object[]{ MediumDuration, LongDuration, DurationFilter.DurationFilterMethods.Greater, true },

                new object[]{ MediumDuration, ShortDuration, DurationFilter.DurationFilterMethods.GreaterEquals, false },
                new object[]{ MediumDuration, MediumDuration, DurationFilter.DurationFilterMethods.GreaterEquals, true },
                new object[]{ MediumDuration, LongDuration, DurationFilter.DurationFilterMethods.GreaterEquals, true },

                new object[]{ MediumDuration, ShortDuration, DurationFilter.DurationFilterMethods.Smaller, true },
                new object[]{ MediumDuration, MediumDuration, DurationFilter.DurationFilterMethods.Smaller, false },
                new object[]{ MediumDuration, LongDuration, DurationFilter.DurationFilterMethods.Smaller, false },

                new object[]{ MediumDuration, ShortDuration, DurationFilter.DurationFilterMethods.SmallerEquals, true },
                new object[]{ MediumDuration, MediumDuration, DurationFilter.DurationFilterMethods.SmallerEquals, true },
                new object[]{ MediumDuration, LongDuration, DurationFilter.DurationFilterMethods.SmallerEquals, false },
            };
        }

        [Theory]
        [MemberData(nameof(GenerateAllTimeTestCombinations))]
        public void PassesFilter_WithValidMethodAndArgumentAndParameter_ReturnsBool(TimeSpan argument, TimeSpan toTest,
            DurationFilter.DurationFilterMethods method, bool expected)
        {
            var filter = new DurationFilter(method, argument);
            var result = filter.PassesFilter(toTest);

            Assert.Equal(expected, result);
        }
    }
}
