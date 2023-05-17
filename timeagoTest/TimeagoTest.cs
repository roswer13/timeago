namespace timeagoTest;

public class TimeagoTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BadLocaleException()
    {
        var dateTime = DateTime.Now;
        var result = TimeAgo.Format(dateTime: dateTime, locale: "de");
        Assert.That(actual: result, Is.EqualTo(expected: string.Empty));
    }

    [Test]
    public void LessThanOneMinute()
    {
        var random = new Random();
        var seconds = random.Next(1, 44);
        var dateTime = DateTime.Now - TimeSpan.FromSeconds(seconds);
        var result = TimeAgo.Format(dateTime: dateTime);
        Assert.That(actual: result, Is.EqualTo(expected: "a moment"));
    }

    [Test]
    public void AboutAMinute()
    {
        var random = new Random();
        var seconds = random.Next(45, 90);
        var dateTime = DateTime.Now - TimeSpan.FromSeconds(seconds);
        var result = TimeAgo.Format(dateTime: dateTime);
        Assert.That(actual: result, Is.EqualTo(expected: "a minute"));
    }

    [Test]
    public void Minutes()
    {
        var random = new Random();
        var minutes = random.Next(1, 44);
        var dateTime = DateTime.Now - TimeSpan.FromMinutes(minutes);
        var result = TimeAgo.Format(dateTime: dateTime);
        Assert.That(actual: result, Is.EqualTo(expected: $"{minutes} minutes"));
    }

    [Test]
    public void AboutAnHour()
    {
        var random = new Random();
        var minutes = random.Next(45, 89);
        var dateTime = DateTime.Now - TimeSpan.FromMinutes(minutes);
        var result = TimeAgo.Format(dateTime: dateTime);
        Assert.That(actual: result, Is.EqualTo(expected: "about an hour"));
    }

    [Test]
    public void Hours()
    {
        var random = new Random();
        var hours = random.Next(1, 23);
        var dateTime = DateTime.Now - TimeSpan.FromHours(hours);
        var result = TimeAgo.Format(dateTime: dateTime);
        Assert.That(actual: result, Is.EqualTo(expected: $"{hours} hours"));
    }

    [Test]
    public void ADay()
    {
        var random = new Random();
        var hours = random.Next(24, 47);
        var dateTime = DateTime.Now - TimeSpan.FromHours(hours);
        var result = TimeAgo.Format(dateTime: dateTime);
        Assert.That(actual: result, Is.EqualTo(expected: "a day"));
    }

    [Test]
    public void Days()
    {
        var random = new Random();
        var days = random.Next(1, 29);
        var dateTime = DateTime.Now - TimeSpan.FromDays(days);
        var result = TimeAgo.Format(dateTime: dateTime);
        Assert.That(actual: result, Is.EqualTo(expected: $"{days} days"));
    }

    [Test]
    public void AboutAMonth()
    {
        var random = new Random();
        var days = random.Next(30, 59);
        var dateTime = DateTime.Now - TimeSpan.FromDays(days);
        var result = TimeAgo.Format(dateTime: dateTime);
        Assert.That(actual: result, Is.EqualTo(expected: "about a month"));
    }

    [Test]
    public void Months()
    {
        var random = new Random();
        var days = random.Next(60, 364);
        var months = days / 30;
        var dateTime = DateTime.Now - TimeSpan.FromDays(days);
        var result = TimeAgo.Format(dateTime: dateTime);
        Assert.That(actual: result, Is.EqualTo(expected: $"{months} months"));
    }

    [Test]
    public void Years()
    {
        var random = new Random();
        var days = random.Next(365, 1000);
        var years = days / 365;
        var dateTime = DateTime.Now - TimeSpan.FromDays(days);
        var result = TimeAgo.Format(dateTime: dateTime);
        Assert.That(actual: result, Is.EqualTo(expected: $"{years} years"));
    }
}