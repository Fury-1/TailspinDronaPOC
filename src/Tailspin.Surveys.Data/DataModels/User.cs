﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Tailspin.Surveys.Data.DataModels
{
    public class User
    {
        public Guid Id { get; set; }

        public Guid TenantId { get; set; }

        public virtual Tenant Tenant { get; set; }

        public string ObjectId { get; set; }

        public string DisplayName { get; set; }

        public string Email { get; set; }

        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

        public DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow;
    }
}
