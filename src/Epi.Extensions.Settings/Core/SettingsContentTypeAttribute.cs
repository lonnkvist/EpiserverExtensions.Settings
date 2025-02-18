﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SettingsContentTypeAttribute.cs" company="none">
//      Copyright © 2019 Linus Ekström, Jeroen Stemerdink.
//      Permission is hereby granted, free of charge, to any person obtaining a copy
//      of this software and associated documentation files (the "Software"), to deal
//      in the Software without restriction, including without limitation the rights
//      to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//      copies of the Software, and to permit persons to whom the Software is
//      furnished to do so, subject to the following conditions:
// 
//      The above copyright notice and this permission notice shall be included in all
//      copies or substantial portions of the Software.
// 
//      THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//      IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//      FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//      AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//      LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//      OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//      SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Epi.Extensions.Settings.Core
{
    using System;

    using EPiServer.DataAnnotations;

    /// <summary>
    /// Class SettingsContentTypeAttribute. This class cannot be inherited.
    /// Implements the <see cref="EPiServer.DataAnnotations.ContentTypeAttribute" />
    /// </summary>
    /// <seealso cref="EPiServer.DataAnnotations.ContentTypeAttribute" />
    [AttributeUsage(validOn: AttributeTargets.Class)]
    public sealed class SettingsContentTypeAttribute : ContentTypeAttribute
    {
        /// <summary>
        /// Gets or sets the settings instance unique identifier.
        /// </summary>
        /// <value>The settings instance unique identifier.</value>
        public string SettingsInstanceGuid { get; set; }

        /// <summary>
        /// Gets or sets the name of the settings.
        /// </summary>
        /// <value>The name of the settings.</value>
        public string SettingsName { get; set; }
    }
}