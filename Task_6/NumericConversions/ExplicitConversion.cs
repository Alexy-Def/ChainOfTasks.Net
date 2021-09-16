namespace NumericConversions
{
    public static class ExplicitConversion
    {
        public static int LongToInt(long longValue)
        {
            return (int)longValue;
        }

        public static int FloatToInt(float floatValue)
        {
            int value = (int)floatValue;
            return value;
        }

        public static int DoubleToInt(double doubleValue)
        {
            int value = (int)doubleValue;
            return value;
        }

        public static int DecimalToInt(decimal decimalValue)
        {
            int value = (int)decimalValue;
            return value;
        }

        public static long FloatToLong(float floatValue)
        {
            long value = (long)floatValue;
            return value;
        }

        public static long DoubleToLong(double doubleValue)
        {
            long value = (long)doubleValue;
            return value;
        }

        public static long DecimalToLong(decimal decimalValue)
        {
            long value = (long)decimalValue;
            return value;
        }

        public static byte ShortToByte(short shortValue)
        {
            byte value = (byte)shortValue;
            return value;
        }

        public static byte IntToByte(int intValue)
        {
            byte value = (byte)intValue;
            return value;
        }

        public static short IntToShort(int intValue)
        {
            short value = (short)intValue;
            return value;
        }
    }
}
