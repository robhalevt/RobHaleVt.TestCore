using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RobHaleVt.TestCore
{
    /// <summary>
    /// Contains extension methods for <see cref="Random"/>
    /// </summary>
    public static class RandomExtensions
    {
        /// <summary>
        /// Returns a random Boolean value
        /// </summary>
        public static bool NextBool(this Random random)
        {
            return random.Next(0, 2).Equals(1);
        }

        /// <summary>
        /// Returns a non-negative <see cref="byte"/> value
        /// </summary>
        public static byte NextByte(this Random random)
        {
            return random.NextByte(byte.MinValue, byte.MaxValue);
        }

        /// <summary>
        /// Returns a non-negative <see cref="byte"/> that is less than the specified maximum
        /// </summary>
        /// <param name="random"></param>
        /// <param name="maxValue">The inclusive, upper bound of the random number returned. <paramref name="maxValue"/>
        /// must be greater than or equal to zero</param>
        /// <returns></returns>
        public static byte NextByte(this Random random, byte maxValue)
        {
            return random.NextByte(byte.MinValue, maxValue);
        }

        /// <summary>
        /// Returns a non-negative <see cref="byte"/> value within a specified range
        /// </summary>
        /// <param name="random"></param>
        /// <param name="minValue">The inclusive, lower bound of the random number returned.</param>
        /// <param name="maxValue">The inclusive, upper bound of the random number returned. <paramref name="maxValue"/>
        /// must be greater than or equal to <paramref name="minValue"/></param>
        public static byte NextByte(this Random random, byte minValue, byte maxValue)
        {
            int randomInt = random.Next(minValue, maxValue + 1);
            return (byte)randomInt;
        }

        /// <summary>
        /// Returns a non-negative <see cref="sbyte"/> value
        /// </summary>
        public static sbyte NextSByte(this Random random)
        {
            return random.NextSByte(sbyte.MinValue, sbyte.MaxValue);
        }

        /// <summary>
        /// Returns a random <see cref="sbyte"/> that is less than the specified maximum
        /// </summary>
        /// <param name="random"></param>
        /// <param name="maxValue">The inclusive, upper bound of the random number returned. <paramref name="maxValue"/>
        /// must be greater than or equal to zero</param>
        /// <returns></returns>
        public static sbyte NextSByte(this Random random, sbyte maxValue)
        {
            return random.NextSByte(sbyte.MinValue, maxValue);
        }

        /// <summary>
        /// Returns a random <see cref="sbyte"/> value within a specified range
        /// </summary>
        /// <param name="random"></param>
        /// <param name="minValue">The inclusive, lower bound of the random number returned.</param>
        /// <param name="maxValue">The inclusive, upper bound of the random number returned. <paramref name="maxValue"/>
        /// must be greater than or equal to <paramref name="minValue"/></param>
        public static sbyte NextSByte(this Random random, sbyte minValue, sbyte maxValue)
        {
            int randomInt = random.Next(minValue, maxValue + 1);
            return (sbyte)randomInt;
        }

        /// <summary>
        /// Returns a random <see cref="string"/> with a length less than <paramref name="maxLength"/>
        /// </summary>
        /// <param name="random"></param>
        /// <param name="maxLength">The length of the returned value</param>
        public static string NextString(this Random random, int maxLength)
        {
            var sb = new StringBuilder();

            for (int i = 1; i <= maxLength; i++)
            {
                sb.Append(random.NextChar());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Returns a random, printable ASCII character
        /// </summary>
        /// <param name="random"></param>
        public static char NextChar(this Random random)
        {
            return (char) random.Next(32, 127 + 1);
        }

        /// <summary>
        /// Returns a random <see cref="long"/> value
        /// </summary>
        public static long NextLong(this Random random)
        {
            return BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0);
        }

        /// <summary>
        /// Returns a random <see cref="ulong"/> value
        /// </summary>
        public static ulong NextULong(this Random random)
        {
            return BitConverter.ToUInt64(Guid.NewGuid().ToByteArray(), 0);
        }

        /// <summary>
        /// Returns a random floating point number
        /// </summary>
        /// <param name="random"></param>
        public static float NextFloat(this Random random)
        {
            return (float)random.NextDouble();
        }

        /// <summary>
        /// Returns a random <see cref="ushort"/>
        /// </summary>
        /// <param name="random"></param>
        public static ushort NextUShort(this Random random)
        {
            return (ushort) random.Next(ushort.MinValue, ushort.MaxValue);
        }

        /// <summary>
        /// Returns a random <see cref="ushort"/> that is less than the specified maximum
        /// </summary>
        /// <param name="random"></param>
        /// <param name="maxValue">The exclusive, upper bound of the random number returned. <paramref name="maxValue"/>
        /// must be greater than or equal to zero</param>
        public static ushort NextUShort(this Random random, ushort maxValue)
        {
            return (ushort) random.Next(ushort.MinValue, maxValue);
        }

        /// <summary>
        /// Returns a random <see cref="ushort"/> value within a specified range
        /// </summary>
        /// <param name="random"></param>
        /// <param name="minValue">The inclusive, lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive, upper bound of the random number returned. <paramref name="maxValue"/>
        /// must be greater than or equal to <paramref name="minValue"/></param>
        public static ushort NextUShort(this Random random, ushort minValue, ushort maxValue)
        {
            return (ushort) random.Next(minValue, maxValue);
        }

        /// <summary>
        /// Returns a random <see cref="short"/>
        /// </summary>
        /// <param name="random"></param>
        public static short NextShort(this Random random)
        {
            return (short)random.Next(short.MinValue, short.MaxValue);
        }

        /// <summary>
        /// Returns a random <see cref="short"/> that is less than the specified maximum
        /// </summary>
        /// <param name="random"></param>
        /// <param name="maxValue">The exclusive, upper bound of the random number returned. <paramref name="maxValue"/>
        /// must be greater than or equal to zero</param>
        public static short NextShort(this Random random, short maxValue)
        {
            return (short) random.Next(short.MinValue, maxValue);
        }

        /// <summary>
        /// Returns a random <see cref="short"/> value within a specified range
        /// </summary>
        /// <param name="random"></param>
        /// <param name="minValue">The inclusive, lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive, upper bound of the random number returned. <paramref name="maxValue"/>
        /// must be greater than or equal to <paramref name="minValue"/></param>
        public static short NextShort(this Random random, short minValue, short maxValue)
        {
            return (short)random.Next(minValue, maxValue);
        }

        /// <summary>
        /// Returns a random <see cref="uint"/>
        /// </summary>
        /// <param name="random"></param>
        public static uint NextUInt(this Random random)
        {
            return (uint) random.Next();
        }

        /// <summary>
        /// Returns a random <see cref="uint"/> that is less than the specified maximum
        /// </summary>
        /// <param name="random"></param>
        /// <param name="maxValue">The exclusive, upper bound of the random number returned. <paramref name="maxValue"/>
        /// must be greater than or equal to zero</param>
        public static uint NextUInt(this Random random, uint maxValue)
        {
            return (uint) random.Next((int) uint.MinValue, (int) maxValue);
        }

        /// <summary>
        /// Returns a random <see cref="uint"/> value within a specified range
        /// </summary>
        /// <param name="random"></param>
        /// <param name="minValue">The inclusive, lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive, upper bound of the random number returned. <paramref name="maxValue"/>
        /// must be greater than or equal to <paramref name="minValue"/></param>
        public static uint NextUInt(this Random random, uint minValue, uint maxValue)
        {
            var minimumIntValue = (int) minValue;
            var maximumIntValue = (int) maxValue;

            if (minValue > int.MaxValue)
            {
                minimumIntValue = int.MaxValue;
            }

            if (maxValue > int.MaxValue)
            {
                maximumIntValue = int.MaxValue;
            }

            return (uint) random.Next(minimumIntValue, maximumIntValue);
        }

        /// <summary>
        /// Returns a random value for an Enum
        /// </summary>
        /// <typeparam name="T">The Enum</typeparam>
        /// <param name="random"></param>
        /// <exception cref="System.ArgumentException">Type provided is not an Enum</exception>
        public static T NextEnum<T>(this Random random)
        {
            return random.NextEnum(new List<T>());
        }

        /// <summary>
        /// Returns a random value for an Enum excluding any values provided
        /// </summary>
        /// <typeparam name="T">The Enum</typeparam>
        /// <param name="random">The random.</param>
        /// <param name="excluded">An group of enum values to exclude from being returned</param>
        /// <returns>A random value from the enum</returns>
        /// <exception cref="ArgumentException">Type provided is not an Enum</exception>
        public static T NextEnum<T>(this Random random, IEnumerable<T> excluded)
        {
            var type = typeof(T);

            if (!type.IsEnum)
            {
                throw new ArgumentException("Type provided is not an Enum", type.Name);
            }

            var values = Enum.GetValues(type);

            var valuesToManipulate = new List<T>();
            foreach (T value in values)
            {
                valuesToManipulate.Add(value);
            }

            foreach (var value in excluded)
            {
                valuesToManipulate.Remove(value);
            }

            return valuesToManipulate.ElementAt(random.Next(valuesToManipulate.Count));
        }
    }
}
