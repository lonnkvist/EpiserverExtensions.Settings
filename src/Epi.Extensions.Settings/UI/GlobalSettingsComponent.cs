﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSettingsComponent.cs" company="none">
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

namespace Epi.Extensions.Settings.UI
{
    using EPiServer.Shell.ViewComposition;

    /// <summary>
    /// Component that provides a tree based navigation for global settings.
    /// Implements the <see cref="EPiServer.Shell.ViewComposition.ComponentDefinitionBase" />
    /// </summary>
    /// <seealso cref="EPiServer.Shell.ViewComposition.ComponentDefinitionBase" />
    [Component]
    public sealed class GlobalSettingsComponent : ComponentDefinitionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSettingsComponent"/> class.
        /// </summary>
        public GlobalSettingsComponent()
            : base("epi-cms/component/MainNavigationComponent")
        {
            this.LanguagePath = "/episerver/cms/components/globalsettings";
            this.Title = "Global settings";
            this.SortOrder = 100;
            this.Settings.Add(new Setting("repositoryKey", value: GlobalSettingsRepositoryDescriptor.RepositoryKey));
        }
    }
}