using System.Collections.Generic;

namespace AmateurBandLib
{
    public sealed class AmateurBand
    {
        public string Name { get; }
        public long LowerBoundHz { get; set; }
        public long UpperBoundHz { get; set; }

        private AmateurBand(string name, long lowerBound, long upperBound)
        {
            Name = name;
            LowerBoundHz = lowerBound;
            UpperBoundHz = upperBound;
        }

        public static readonly AmateurBand LF_2200m = new AmateurBand("2200m", 135.7.KHz(), 137.8.KHz());
        public static readonly AmateurBand MF_630m = new AmateurBand("630m", 472.KHz(), 479.KHz());
        public static readonly AmateurBand MF_160m = new AmateurBand("160m", 1.8.MHz(), 2.MHz());
        public static readonly AmateurBand HF_80m = new AmateurBand("80m", 3.5.MHz(), 4.MHz());
        public static readonly AmateurBand HF_60m = new AmateurBand("60m", 5.3515.MHz(), 5.3665.MHz());
        public static readonly AmateurBand HF_40m = new AmateurBand("40m", 7.MHz(), 7.3.MHz());
        public static readonly AmateurBand HF_30m = new AmateurBand("30m", 10.1.MHz(), 10.15.MHz());
        public static readonly AmateurBand HF_20m = new AmateurBand("20m", 14.MHz(), 14.35.MHz());
        public static readonly AmateurBand HF_17m = new AmateurBand("17m", 18.068.MHz(), 18.168.MHz());
        public static readonly AmateurBand HF_15m = new AmateurBand("15m", 21.MHz(), 21.45.MHz());
        public static readonly AmateurBand HF_12m = new AmateurBand("12m", 24.89.MHz(), 24.99.MHz());
        public static readonly AmateurBand HF_11m = new AmateurBand("11m", 26.965.MHz(), 27.405.MHz());
        public static readonly AmateurBand HF_10m = new AmateurBand("10m", 28.MHz(), 29.7.MHz());
        public static readonly AmateurBand VHF_8m = new AmateurBand("8m", 40.MHz(), 44.MHz());
        public static readonly AmateurBand VHF_6m = new AmateurBand("6m", 50.MHz(), 54.MHz());
        public static readonly AmateurBand VHF_5m = new AmateurBand("5m", 54.MHz(), 69.9.MHz());
        public static readonly AmateurBand VHF_4m = new AmateurBand("4m", 70.MHz(), 70.5.MHz());
        public static readonly AmateurBand VHF_2m = new AmateurBand("2m", 144.MHz(), 148.MHz());
        public static readonly AmateurBand VHF_1_25m = new AmateurBand("1.25m", 220.MHz(), 225.MHz());
        public static readonly AmateurBand UHF_70cm = new AmateurBand("70cm", 420.MHz(), 450.MHz());
        public static readonly AmateurBand UHF_33cm = new AmateurBand("33cm", 902.MHz(), 928.MHz());
        public static readonly AmateurBand UHF_23cm = new AmateurBand("23cm", 1.24.GHz(), 1.3.GHz());
        public static readonly AmateurBand UHF_13cm = new AmateurBand("13cm", 2.3.GHz(), 2.45.GHz());
        public static readonly AmateurBand SHF_9cm = new AmateurBand("9cm", 3.3.GHz(), 3.5.GHz());
        public static readonly AmateurBand SHF_5cm = new AmateurBand("5cm", 5.65.GHz(), 5.925.GHz());
        public static readonly AmateurBand SHF_3cm = new AmateurBand("3cm", 10.GHz(), 10.5.GHz());
        public static readonly AmateurBand SHF_1_2cm = new AmateurBand("1.2cm", 24.GHz(), 24.25.GHz());
        public static readonly AmateurBand EHF_6mm = new AmateurBand("6mm", 47.GHz(), 47.2.GHz());
        public static readonly AmateurBand EHF_4mm = new AmateurBand("4mm", 75.5.GHz(), 81.5.GHz());
        public static readonly AmateurBand EHF_2_5mm = new AmateurBand("2.5mm", 122.25.GHz(), 123.GHz());
        public static readonly AmateurBand EHF_2mm = new AmateurBand("2mm", 134.GHz(), 141.GHz());
        public static readonly AmateurBand EHF_1mm = new AmateurBand("1mm", 241.GHz(), 250.GHz());

        public static IEnumerable<AmateurBand> All => new[] {
                LF_2200m,
                MF_630m, MF_160m,
                HF_80m, HF_60m, HF_40m, HF_30m, HF_20m, HF_17m, HF_15m, HF_12m, HF_11m, HF_10m,
                VHF_8m, VHF_6m, VHF_5m, VHF_4m, VHF_2m, VHF_1_25m,
                UHF_70cm, UHF_33cm, UHF_23cm, UHF_13cm,
                SHF_9cm, SHF_5cm, SHF_3cm, SHF_1_2cm,
                EHF_6mm, EHF_4mm, EHF_2_5mm, EHF_2mm, EHF_1mm };

        public static AmateurBand FromHz(long frequency)
        {
            foreach (var band in All)
            {
                if (frequency.Between(band.LowerBoundHz, band.UpperBoundHz))
                {
                    return band;
                }
            }

            return null;
        }
    }
}
