using System;

namespace ArithmeticSequenceTask
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (number == int.MaxValue && add > 0)
            {
                throw new OverflowException("The obtained result out of range of integer values.");
            }

            if (number == int.MinValue && add < 0)
            {
                throw new OverflowException("The obtained result out of range of integer values.");
            }

            if (count < 0)
            {
                throw new ArgumentException("invalid argument", nameof(count));
            }

            var result = 0;

            for (int i = 0; i < count; i++)
            {
                result += number + (add * i);
            }

            return result;
        }
    }
}
