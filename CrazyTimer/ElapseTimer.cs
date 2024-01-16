namespace CrazyTimer
{
    public enum TimeType
    {
        Hour,
        Day,
        Month,
        Year,
    }

    public class ElapseTimer
    {
        public int Hour { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public bool SetValue(string input, TimeType type)
        {
            if (!int.TryParse(input, out var number))
            {
                return false;
            }

            switch (type)
            {
                case TimeType.Hour:
                    if (number >= 23 || number < 0)
                        return false;
                    Hour = number;
                    break;
                case TimeType.Day:
                    if (number < 0 || number > 31)
                        return false;
                    Day = number;
                    break;
                case TimeType.Month:
                    if (number < 1 || number > 12)
                        return false;
                    Month = number;
                    break;
                case TimeType.Year:
                    if (number < DateTime.Now.Year)
                        return false;
                    Year = number;
                    break;
                default:
                    break;
            }

            return true;
        }

        public bool CalcElapseSeconds(out double result)
        {
            result = 0;
            var valid = false;

            try
            {
                var target = new DateTime(Year, Month, Day, Hour, 0, 0);
                result = (target - DateTime.Now).TotalSeconds;
                valid = true;
            }
            catch (Exception)
            {
            }

            return valid;
        }
    }
}
