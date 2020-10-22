namespace AmateurBandLib
{
    public static class ExtensionMethods
    {
        public static long KHz(this int v) => 1000 * v;
        public static long KHz(this double v) => (long)(1000 * v);
        public static long MHz(this int v) => v * 1000000;
        public static long MHz(this double v) => (long)(v * 1000000);
        public static long GHz(this int v) => v * 1000000000;
        public static long GHz(this double v) => (long)(v * 1000000000);
        public static bool Between(this long v, long lower, long upper) => v >= lower && v <= upper;
    }
}
