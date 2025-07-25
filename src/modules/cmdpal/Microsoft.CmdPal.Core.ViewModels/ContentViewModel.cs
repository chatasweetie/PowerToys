// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CmdPal.Core.ViewModels;

public abstract partial class ContentViewModel(WeakReference<IPageContext> context) :
    ExtensionObjectViewModel(context)
{
    public bool OnlyControlOnPage { get; internal set; }
}
