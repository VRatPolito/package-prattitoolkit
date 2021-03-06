
/*
 * Custom template by Gabriele P.
 */
using System;

namespace VRatPolito.PrattiToolkit
{
    [Serializable]
    public struct RangedFloat
    {
        public float minValue;
        public float maxValue;

        public bool InRange(float value)
        {
            return value <= maxValue && value >= minValue;
        }
    }
}