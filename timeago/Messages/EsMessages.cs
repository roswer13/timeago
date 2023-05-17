namespace timeago.Messages;

public class EsMessages : LookupMessages
{
    public override string PrefixAgo() => "hace";

    public override string PrefixFromNow() => "dentro de";

    public override string SuffixAgo() => "";

    public override string SuffixFromNow() => "";

    public override string LessThanOneMinute(int seconds) => "ahora";

    public override string AboutAMinute(int minutes) => "un minuto";

    public override string Minutes(int minutes) => $"{minutes} minutos";

    public override string AboutAnHour(int minutes) => "una hora";

    public override string Hours(int hours) => $"{hours} horas";

    public override string ADay(int hours) => "un día";

    public override string Days(int days) => $"{days} días";

    public override string AboutAMonth(int days) => "un mes";

    public override string Months(int months) => $"{months} meses";

    public override string AboutAYear(int year) => "un año";

    public override string Years(int years) => $"{years} años";

    public override string WordSeparator() => " ";
}