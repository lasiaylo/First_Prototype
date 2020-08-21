using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Util {
    public static class Extension {
        private static float _tolerance = 0.01f; 
        public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T> {
            if (val.CompareTo(min) < 0) return min;
            if (val.CompareTo(max) > 0) return max;
            return val;
        }

        public static T ClampMax<T>(this T val, T max) where T : IComparable<T> {
            return val.CompareTo(max) > 0 ? max : val;
        }

        public static T ClampMin<T>(this T val, T min) where T : IComparable<T> {
            return val.CompareTo(min) < 0 ? min : val;
        }

        public static bool IsZero(this Vector3 val) {
            return Math.Abs(val.magnitude) < _tolerance;
        }

        public static bool IsZero(this Vector2 val) {
            return Math.Abs(val.magnitude) < _tolerance;
        }

        public static Vector2 Xz(this Vector3 val) {
            return new Vector2(val.x, val.z);
        }
    }
}