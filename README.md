# FluentAssertions for DateTime, DateTimeOffset and TimeSpan

Fluent syntax for
* DateTime
* DateTimeOffset
* TimeSpan

<pre>
  dateTime.Should().Be(3.February(2001).At(12, 0)));
  
  dateTimeOffset.Should().BeExactly(3.February(2001).WithOffset(1.Hours()));
  
  timeSpan.Should().BeGreaterThan(11.Hours());
</pre>
