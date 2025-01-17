﻿/*
 * Copyright (c) 2021 eBay Inc.
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *  http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *
 */

using System;
namespace EbayEventNotificationSDK
{
    public static class Constants
    {
        public static readonly String KeyPattern = @"-----BEGIN PUBLIC KEY-----(.*?)-----END PUBLIC KEY-----";
        public static readonly String Algorithm = "{0}WITH{1}";
        public static readonly String Production = "PRODUCTION";
        public static readonly String Sandbox = "SANDBOX";
    }
}
