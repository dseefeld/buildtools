// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Cci.Differs
{
    // These enums are priority so be careful about changing the order see ElementDiffer.Diff for the reason.
    public enum DifferenceType
    {
        Unknown,
        Unchanged,
        Added,
        Removed,
        Changed,
    }
}
