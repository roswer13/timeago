namespace timeago.Messages;

public class EnShortMessages : LookupMessages
{
    public override string PrefixAgo() => "";

    public override string PrefixFromNow() => "";

    public override string SuffixAgo() => "";

    public override string SuffixFromNow() => "";

    public override string LessThanOneMinute(int seconds) => "now";

    public override string AboutAMinute(int minutes) => "1m";

    public override string Minutes(int minutes) => $"{minutes}m";

    public override string AboutAnHour(int minutes) => "~1h";

    public override string Hours(int hours) => $"{hours}h";

    public override string ADay(int hours) => "~1d";

    public override string Days(int days) => $"{days}d";

    public override string AboutAMonth(int days) => "~1mo";

    public override string Months(int months) => $"{months}mo";

    public override string AboutAYear(int year) => "~1y";

    public override string Years(int years) => $"{years}y";

    public override string WordSeparator() => " ";
}