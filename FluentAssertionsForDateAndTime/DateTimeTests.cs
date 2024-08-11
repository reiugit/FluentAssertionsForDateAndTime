using FluentAssertions;
using FluentAssertions.Extensions;

namespace FluentAssertionsForDateAndTime;

public class DateTimeTests
{
    [Fact]
    public void DateTimeTests_ShouldBe_Fluent()
    {
        // var dateTime = new DateTime(2001, 2, 3);
        var dateTime = 3.February(2001);

        dateTime.Should().BeIn(DateTimeKind.Unspecified);
        dateTime.AsLocal().Should().BeIn(DateTimeKind.Local);
        DateTime.UtcNow.Should().BeIn(DateTimeKind.Utc);

        dateTime.Should().Be(3.February(2001));
        dateTime.Should().BeSameDateAs(3.February(2001));

        dateTime.Should().BeOnOrAfter(3.February(2001));
        dateTime.Should().BeOnOrBefore(3.February(2001));
        dateTime.Should().BeAfter(2.February(2001));
        dateTime.Should().BeBefore(4.February(2001));

        dateTime.Should().BeOneOf(
            2.February(2001),
            3.February(2001),
            4.February(2001));

        dateTime.Should().HaveDay(3);

        dateTime.Should().BeLessThan(25.Hours()).Before(4.February(2001));

        // DateTimeOffset:
        var dateTimeOffset = 3.February(2001).WithOffset(1.Hours());

        dateTimeOffset.Should().HaveOffset(1.Hours());

        dateTimeOffset.Should().Be(3.February(2001));
        dateTimeOffset.Should().BeExactly(3.February(2001).WithOffset(1.Hours()));
        dateTimeOffset.Should().Be(3.February(2001).WithOffset(1.Hours()));

        dateTimeOffset.Should().BeCloseTo(4.February(2001), 25.Hours());

        // Time:
        var time = 12.Hours(30.Minutes());
        time.Minutes.Should().Be(30);

        // TimeSpan:
        var timeSpan = 12.Hours();
        timeSpan.Should().BeGreaterThan(11.Hours());
    }
}
