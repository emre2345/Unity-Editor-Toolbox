﻿using System;

namespace UnityEngine
{    
    /// <summary>
    /// Disables property if provided condition is met.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class DisableIfAttribute : ComparisonAttribute
    {
        public DisableIfAttribute(string comparedPropertyName, object comparedValue) : base(comparedPropertyName, comparedValue)
        { }
    }
}