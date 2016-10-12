namespace gmreburn
{
    using System;

    public static class SystemTime
    {
        private static DateTime? utcNow;
        private static DateTime? now;

        /// <summary>
        /// Get or Set the DateTime object. Setting Now to null will cause the default DateTime object implementation to be used.
        /// </summary>
        public static DateTime? Now
        {
            get { return now ?? DateTime.Now; }
            set { now = value; }
        }

        /// <summary>
        /// Get or Set the datetime object. Setting UtcNow to null will cause the default DateTime object implementation to be used.
        /// </summary>
        public static DateTime UtcNow
        {
            get { return utcNow ?? DateTime.Now; }
            set { utcNow = value; }
        }
    }
}