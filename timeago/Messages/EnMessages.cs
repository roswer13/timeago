namespace timeago.Messages;

public class EnMessages : LookupMessages
{
    public override string PrefixAgo() => "";

    public override string PrefixFromNow() => "";

    public override string SuffixAgo() => "ago";

    public override string SuffixFromNow() => "from now";

    public override string LessThanOneMinute(int seconds) => "a moment";

    public override string AboutAMinute(int minutes) => "a minute";

    public override string Minutes(int minutes) => $"{minutes} minutes";

    public override string AboutAnHour(int minutes) => "about an hour";

    public override string Hours(int hours) => $"{hours} hours";

    public override string ADay(int hours) => "a day";

    public override string Days(int days) => $"{days} days";

    public override string AboutAMonth(int days) => "about a month";

    public override string Months(int months) => $"{months} months";

    public override string AboutAYear(int year) => "about a year";

    public override string Years(int years) => $"{years} years";

    public override string WordSeparator() => " ";
}