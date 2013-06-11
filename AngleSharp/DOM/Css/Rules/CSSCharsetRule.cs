﻿using System;

namespace AngleSharp.DOM.Css
{
    /// <summary>
    /// Represents the CSS @charset rule.
    /// </summary>
    sealed class CSSCharsetRule : CSSRule
    {
        #region Properties

        /// <summary>
        /// Gets the encoding information set by this rule.
        /// </summary>
        public string Encoding { get; internal set; }

        #endregion
    }
}
