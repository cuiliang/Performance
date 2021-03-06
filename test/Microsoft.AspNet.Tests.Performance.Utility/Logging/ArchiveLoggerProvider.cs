// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNet.Tests.Performance.Utility.Helpers;
using Microsoft.Framework.Logging;

namespace Microsoft.AspNet.Tests.Performance.Utility.Logging
{
    public class ArchiveLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string name)
        {
            return new ArchiveLogger(name, PathHelper.GetArtifactFolder());
        }

        public void Dispose()
        {
        }
    }
}