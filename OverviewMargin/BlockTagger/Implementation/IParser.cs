// Copyright (c) Microsoft Corporation
// All rights reserved

namespace Microsoft.VisualStudio.Extensions.BlockTagger.Implementation
{
    using Text;

    public delegate bool AbortCheck();

    public interface IParser
    {
        CodeBlock Parse(ITextSnapshot snapshot, AbortCheck abort);
    }
}
