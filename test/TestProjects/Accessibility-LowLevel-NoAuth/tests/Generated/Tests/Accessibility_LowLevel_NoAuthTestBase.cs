// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Accessibility_LowLevel_NoAuth;
using Azure.Core.TestFramework;

namespace Accessibility_LowLevel_NoAuth.Tests
{
    public partial class Accessibility_LowLevel_NoAuthTestBase : RecordedTestBase<Accessibility_LowLevel_NoAuthTestEnvironment>
    {
        public Accessibility_LowLevel_NoAuthTestBase(bool isAsync) : base(isAsync)
        {
        }

        protected AccessibilityClient CreateAccessibilityClient(Uri endpoint)
        {
            AccessibilityClientOptions options = InstrumentClientOptions(new AccessibilityClientOptions());
            AccessibilityClient client = new AccessibilityClient(endpoint, options);
            return InstrumentClient(client);
        }
    }
}
