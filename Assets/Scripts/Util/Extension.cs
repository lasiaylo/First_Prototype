﻿using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Util {
    public static class Extension {
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
    }
}