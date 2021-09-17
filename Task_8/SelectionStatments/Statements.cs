using System;

namespace SelectionStatments
{
    public static class Statements
    {
        public static void WriteLargestWithNestedIfElse(int first, int second, int third)
        {
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine($"Number {first} is the largest");
                }
                else
                {
                    Console.WriteLine($"Number {third} is the largest");
                }
            }
            else if (second > third)
            {
                Console.WriteLine($"Number {second} is the largest");
            }
            else
            {
                Console.WriteLine($"Number {third} is the largest");
            }
        }

        public static void WriteLargestWithIfElseAndTernaryOperator(int first, int second, int third)
        {
            if (first > second)
            {
                Console.WriteLine((first > third) ? $"Number {first} is the largest" : $"Number {third} is the largest");
            }
            else
            {
                Console.WriteLine((second > third) ? $"Number {second} is the largest" : $"Number {third} is the largest");
            }
        }

        public static void WriteLargestWithIfElseAndConditionLogicalOperators(int first, int second, int third)
        {
            if (first > second && first > third)
            {
                Console.WriteLine($"Number {first} is the largest");
            }
            else if (second > first && second > third)
            {
                Console.WriteLine($"Number {second} is the largest");
            }
            else
            {
                Console.WriteLine($"Number {third} is the largest");
            }
        }

        public static void HowOldAreYouReactionWithCascadedIfElse(int userAge)
        {
            if (userAge >= 65)
            {
                Console.WriteLine("Enjoy your retirement!");
            }
            else if (userAge >= 21)
            {
                Console.WriteLine("Fancy an alcoholic beverage?");
            }
            else if (userAge >= 18)
            {
                Console.WriteLine("You're old enough to drive.");
            }
            else
            {
                Console.WriteLine("You are too young to drive, drink, or retire.");
            }
        }

        public static void WriteInformationAboutDailyDownloadsWithCascadedIfElse(int countOfDailyDownloads)
        {
            if (countOfDailyDownloads <= 0)
            {
                Console.WriteLine("No downloads.");
            }
            else if (countOfDailyDownloads < 100)
            {
                Console.WriteLine("Daily downloads: 1-100.");
            }
            else if (countOfDailyDownloads < 1000)
            {
                Console.WriteLine("Daily downloads: 100-1,000.");
            }
            else if (countOfDailyDownloads < 10000)
            {
                Console.WriteLine("Daily downloads: 1,000-10,000.");
            }
            else if (countOfDailyDownloads < 100000)
            {
                Console.WriteLine("Daily downloads: 10,000-100,000.");
            }
            else
            {
                Console.WriteLine("Daily downloads: 100,000+.");
            }
        }

        public static void WriteTheInformationAboutDayWithIfElse(DayOfWeek dayOfWeek)
        {
            if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("The weekend.");
            }
            else if (dayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("The first day of the work week.");
            }
            else if (dayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("The last day of the work week.");
            }
            else if (dayOfWeek == DayOfWeek.Tuesday || dayOfWeek == DayOfWeek.Wednesday || dayOfWeek == DayOfWeek.Thursday)
            {
                Console.WriteLine("The middle of the work week.");
            }
        }

        public static void WriteTheInformationAboutDayWithSwitchStatement(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("The weekend.");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("The first day of the work week.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the work week.");
                    break;
                default:
                    Console.WriteLine("The middle of the work week.");
                    break;
            }
        }

        public static string GetTypeOfIntegerWithCascadedIfElse(object arg)
        {
            var result = string.Empty;

            if (arg is sbyte)
            {
                result = $"{arg} is sbyte.";
            }
            else if (arg is byte)
            {
                result = $"{arg} is byte.";
            }
            else if (arg is short)
            {
                result = $"{arg} is short.";
            }
            else if (arg is int)
            {
                result = $"{arg} is int.";
            }
            else if (arg is long)
            {
                result = $"{arg} is long.";
            }
            else if (arg is ushort)
            {
                result = $"{arg} is ushort.";
            }
            else if (arg is uint)
            {
                result = $"{arg} is uint.";
            }
            else if (arg is ulong)
            {
                result = $"{arg} is ulong.";
            }
            else
            {
                result = $"{arg} is not integer.";
            }

            return result;
        }

        public static string GetTypeOfIntegerWithSwitchStatement(object arg)
        {
            var result = string.Empty;

            switch (arg)
            {
                case byte _:
                    result = $"{arg} is byte.";
                    break;
                case sbyte _:
                    result = $"{arg} is sbyte.";
                    break;
                case short _:
                    result = $"{arg} is short.";
                    break;
                case int _:
                    result = $"{arg} is int.";
                    break;
                case long _:
                    result = $"{arg} is long.";
                    break;
                case ushort _:
                    result = $"{arg} is ushort.";
                    break;
                case uint _:
                    result = $"{arg} is uint.";
                    break;
                case ulong _:
                    result = $"{arg} is ulong.";
                    break;
                default:
                    result = $"{arg} is not integer.";
                    break;
            }

            return result;
        }

        public static string GetTypeOfIntegerWithSwitchExpression(object arg)
        {
            var result = arg switch
            {
                sbyte _ => $"{arg} is sbyte.",
                byte _ => $"{arg} is byte.",
                short _ => $"{arg} is short.",
                int _ => $"{arg} is int.",
                long _ => $"{arg} is long.",
                ushort _ => $"{arg} is ushort.",
                uint _ => $"{arg} is uint.",
                ulong _ => $"{arg} is ulong.",
                _ => $"{arg} is not integer."
            };

            return result;
        }

        public static void WriteTheInformationAboutSeasonsWithSwitchStatement(Month month)
        {
            switch (month)
            {
                case Month.January:
                case Month.December:
                case Month.February:
                    Console.WriteLine("It's winter now.");
                    break;
                case Month.March:
                case Month.April:
                case Month.May:
                    Console.WriteLine("It's spring now.");
                    break;
                case Month.June:
                case Month.July:
                case Month.August:
                    Console.WriteLine("It's summer now.");
                    break;
                case Month.September:
                case Month.October:
                case Month.November:
                    Console.WriteLine("It's autumn now.");
                    break;
                default: 
                    Console.WriteLine("Sorry, the month was entered incorrectly.");
                    break;
            }
        }

        public static byte GetLengthWithCascadedIfElse(int number)
        {
            byte result;

            if (number / 10 == 0)
            {
                result = 1;
            }
            else if (number / 100 == 0)
            {
                result = 2;
            }
            else if (number / 1000 == 0)
            {
                result = 3;
            }
            else if (number / 10000 == 0)
            {
                result = 4;
            }
            else if (number / 100000 == 0)
            {
                result = 5;
            }
            else if (number / 1000000 == 0)
            {
                result = 6;
            }
            else if (number / 10000000 == 0)
            {
                result = 7;
            }
            else if (number / 100000000 == 0)
            {
                result = 8;
            }
            else if (number / 1000000000 == 0)
            {
                result = 9;
            }
            else
            {
                result = 10;
            }

            return result;
        }

        public static byte GetLengthWithSwitchExpression(int number)
        {
            byte result = number switch
            {
                _ when number / 10 == 0 => 1,
                _ when number / 100 == 0 => 2,
                _ when number / 1000 == 0 => 3,
                _ when number / 10000 == 0 => 4,
                _ when number / 100000 == 0 => 5,
                _ when number / 1000000 == 0 => 6,
                _ when number / 10000000 == 0 => 7,
                _ when number / 100000000 == 0 => 8,
                _ when number / 1000000000 == 0 => 9,
                _ => 10
            };

            return result;
        }

        public static Month? GetMonthWithCascadedIfElse(int month)
        {
            Month? result;

            if (month == 1)
            {
                result = Month.January;
            }
            else if (month == 2)
            {
                result = Month.February;
            }
            else if (month == 3)
            {
                result = Month.March;
            }
            else if (month == 4)
            {
                result = Month.April;
            }
            else if (month == 5)
            {
                result = Month.May;
            }
            else if (month == 6)
            {
                result = Month.June;
            }
            else if (month == 7)
            {
                result = Month.July;
            }
            else if (month == 8)
            {
                result = Month.August;
            }
            else if (month == 9)
            {
                result = Month.September;
            }
            else if (month == 10)
            {
                result = Month.October;
            }
            else if (month == 11)
            {
                result = Month.November;
            }
            else if (month == 12)
            {
                result = Month.December;
            }
            else
            {
                result = null;
            }

            return result;
        }

        public static Month? GetMonthWithSwitchStatement(int month)
        {
            Month? result;

            switch (month)
            {
                case 1:
                    result = Month.January;
                    break;
                case 2:
                    result = Month.February;
                    break;
                case 3:
                    result = Month.March;
                    break;
                case 4:
                    result = Month.April;
                    break;
                case 5:
                    result = Month.May;
                    break;
                case 6:
                    result = Month.June;
                    break;
                case 7:
                    result = Month.July;
                    break;
                case 8:
                    result = Month.August;
                    break;
                case 9:
                    result = Month.September;
                    break;
                case 10:
                    result = Month.October;
                    break;
                case 11:
                    result = Month.November;
                    break;
                case 12:
                    result = Month.December;
                    break;
                default:
                    result = null;
                    break;
            }

            return result;
        }

        public static Month? GetMonthWithSwitchExpression(int month)
        {
            return month switch
            {
                1 => Month.January,
                2 => Month.February,
                3 => Month.March,
                4 => Month.April,
                5 => Month.May,
                6 => Month.June,
                7 => Month.July,
                8 => Month.August,
                9 => Month.September,
                10 => Month.October,
                11 => Month.November,
                12 => Month.December,
                _ => null
            };
        }
    }
}
