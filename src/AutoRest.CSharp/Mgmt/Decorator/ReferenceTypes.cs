﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace AutoRest.CSharp.Mgmt.Decorator
{
    internal static class ReferenceTypes
    {
        public static bool IsMgmtReferenceType(Type frameworkType)
        {
            return frameworkType.IsSubclassOf(typeof(ResourceIdentifier)) ||
                frameworkType == typeof(ResourceType) ||
                frameworkType == typeof(Location) ||
                frameworkType == typeof(ResourceIdentifier);
        }
    }
}
