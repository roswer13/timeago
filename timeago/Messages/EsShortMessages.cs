namespace timeago.Messages;

public class EsShortMessages : LookupMessages
{
    public override string PrefixAgo() => "";

    public override string PrefixFromNow() => "";

    public override string SuffixAgo() => "";

    public override string SuffixFromNow() => "";

    public override string LessThanOneMinute(int seconds) => "ahora";

    public override string AboutAMinute(int minutes) => "1 min";

    public override string Minutes(int minutes) => $"{minutes} min";

    public override string AboutAnHour(int minutes) => "~1 hr";

    public override string Hours(int hours) => $"{hours} hr";

    public override string ADay(int hours) => "~1 día";

    public override string Days(int days) => $"{days} días";

    public override string AboutAMonth(int days) => "~1 mes";

    public override string Months(int months) => $"{months} meses";

    public override string AboutAYear(int year) => "~1 año";

    public override string Years(int years) => $"{years} años";

    public override string WordSeparator() => " ";
}