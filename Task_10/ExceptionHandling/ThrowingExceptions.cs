using System;

namespace ExceptionHandling
{
    public static class ThrowingExceptions
    {
        public static void CheckParameterAndThrowException(object obj)
        {
            try
            {
                if (obj is null)
                {
                    throw new ArgumentNullException(nameof(obj), "obj is null.");
                }
            }
            finally
            {
                Console.WriteLine("ArgumentNullException");
            }
        }

        public static void CheckBothParametersAndThrowException(object obj1, object obj2)
        {
            try
            {
                if (obj1 == null)
                {
                    throw new ArgumentNullException(nameof(obj1), "obj is null.");
                }
                else if (obj2 == null)
                {
                    throw new ArgumentNullException(nameof(obj2), "obj is null.");
                }
            }
            finally
            {
                Console.WriteLine("ArgumentNullException");
            }
        }

        public static string CheckStringAndThrowException(string str)
        {
            try
            {
                if (string.IsNullOrEmpty(str))
                {
                    throw new ArgumentNullException(nameof(str), "obj is null.");
                }
            }
            finally
            {
                Console.WriteLine("ArgumentNullException");
            }

            return str;
        }

        public static string CheckBothStringsAndThrowException(string str1, string str2)
        {
            try
            {
                if (string.IsNullOrEmpty(str1))
                {
                    throw new ArgumentNullException(nameof(str1), "obj is null.");
                }
                else if (string.IsNullOrEmpty(str2))
                {
                    throw new ArgumentNullException(nameof(str2), "obj is null.");
                }
            }
            finally
            {
                Console.WriteLine("ArgumentNullException");
            }

            return string.Concat(str1, str2);
        }

        public static int CheckEvenNumberAndThrowException(int evenNumber)
        {
            try
            {
                if (evenNumber % 2 != 0)
                {
                    throw new ArgumentException("evenNumber parameter is invalid.", nameof(evenNumber));
                }
            }
            finally
            {
                Console.WriteLine("ArgumentException");
            }

            return evenNumber;
        }

        public static int CheckCandidateAgeAndThrowException(int candidateAge, bool isCandidateWoman)
        {
            try
            {
                if (((candidateAge < 16 || candidateAge > 63) && !isCandidateWoman) || ((candidateAge < 16 || candidateAge > 58) && isCandidateWoman))
                {
                    throw new ArgumentOutOfRangeException(nameof(candidateAge), "candidateAge is out of range.");
                }
            }
            finally
            {
                Console.WriteLine("ArgumentOutOfRangeException");
            }

            return candidateAge;
        }

        public static string GenerateUserCode(int day, int month, string username)
        {
            try
            {
                if (day < 1 || day > 31)
                {
                    throw new ArgumentOutOfRangeException(nameof(day), "day is out of range.");
                }
                else if (month < 1 || month > 12)
                {
                    throw new ArgumentOutOfRangeException(nameof(month), "month is out of range.");
                }
                else if (string.IsNullOrEmpty(username))
                {
                    throw new ArgumentNullException(nameof(username), "obj is null.");
                }
            }
            finally
            {
                Console.WriteLine("ArgumentNullException or ArgumentOutOfRangeException");
            }

            return $"{username}-{day}{month}";
        }
    }
}
