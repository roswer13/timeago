using timeago.Messages;

public class TimeAgo
{
    private const string Default = "en";

    private static readonly Dictionary<string, LookupMessages> LookupMessagesMap = new()
    {
        {"en", new EnMessages()},
        {"en_short", new EnShortMessages()},
        {"es", new EsMessages()},
        {"es_short", new EsShortMessages()},
    };

    public static string Format(DateTime dateTime, string? locale = "en")
    {
        var localeSetting = locale ?? Default;

        LookupMessages? messages;

        try
        {
            messages = LookupMessagesMap[localeSetting];
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(
                $"Locale {localeSetting} has not been added, using {Default} as fallback. To add a locale use [setLocaleMessages]. Exception: {ex}"
            );
            return string.Empty;
        }

        var timeSpan = DateTime.Now.Subtract(dateTime);

        if (timeSpan < TimeSpan.FromSeconds(45))
            return messages.LessThanOneMinute(seconds: timeSpan.Seconds);

        if (timeSpan < TimeSpan.FromSeconds(90))
            return messages.AboutAMinute(minutes: timeSpan.Minutes);

        if (timeSpan < TimeSpan.FromMinutes(45))
            return messages.Minutes(minutes: timeSpan.Minutes);

        if (timeSpan < TimeSpan.FromMinutes(90))
            return messages.AboutAnHour(minutes: timeSpan.Minutes);

        if (timeSpan < TimeSpan.FromHours(24))
            return messages.Hours(hours: timeSpan.Hours);

        if (timeSpan < TimeSpan.FromHours(48))
            return messages.ADay(hours: timeSpan.Hours);

        if (timeSpan < TimeSpan.FromDays(30))
            return messages.Days(days: timeSpan.Days);

        if (timeSpan < TimeSpan.FromDays(60))
            return messages.AboutAMonth(days: timeSpan.Days);

        return timeSpan < TimeSpan.FromDays(365)
            ? messages.Months(months: timeSpan.Days / 30)
            : messages.Years(years: timeSpan.Days / 365);
    }
}