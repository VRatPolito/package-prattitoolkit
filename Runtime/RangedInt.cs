using System;

namespace VRatPolito.PrattiToolkit
{
    [Serializable]
    public struct RangedInt
    {
        public int minValue;
        public int maxValue;

        public RangedInt(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }
    }
}