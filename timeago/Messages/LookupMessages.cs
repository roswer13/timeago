namespace timeago.Messages;

public abstract class LookupMessages
{
    /// Example: `PrefixAgo()` 1 min `SuffixAgo()`
    public abstract string PrefixAgo();

    /// Example: `PrefixFromNow()` 1 min `SuffixFromNow()`
    public abstract string PrefixFromNow();

    /// Example: `PrefixAgo()` 1 min `SuffixAgo()`
    public abstract string SuffixAgo();

    /// Example: `PrefixFromNow()` 1 min `SuffixFromNow()`
    public abstract string SuffixFromNow();

    /// Format when time is less than a minute
    public abstract string LessThanOneMinute(int seconds);

    /// Format when time is about a minute
    public abstract string AboutAMinute(int minutes);

    /// Format when time is in minutes
    public abstract string Minutes(int minutes);

    /// Format when time is about an hour
    public abstract string AboutAnHour(int minutes);

    /// Format when time is in hours
    public abstract string Hours(int hours);

    /// Format when time is a day
    public abstract string ADay(int hours);

    /// Format when time is in days
    public abstract string Days(int days);

    /// Format when time is about a month
    public abstract string AboutAMonth(int days);

    /// Format when time is in months
    public abstract string Months(int months);

    /// Format when time is about a year
    public abstract string AboutAYear(int year);

    /// Format when time is about a year
    public abstract string Years(int years);

    /// word separator when words are concatenated
    public abstract string WordSeparator();
}