/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class GetTotalQueueReportResponseUnmarshaller
    {
        public static GetTotalQueueReportResponse Unmarshall(UnmarshallerContext context)
        {
			GetTotalQueueReportResponse getTotalQueueReportResponse = new GetTotalQueueReportResponse();

			getTotalQueueReportResponse.HttpResponse = context.HttpResponse;
			getTotalQueueReportResponse.RequestId = context.StringValue("GetTotalQueueReport.RequestId");
			getTotalQueueReportResponse.Metrics = context.StringValue("GetTotalQueueReport.Metrics");

			List<string> getTotalQueueReportResponse_data = new List<string>();
			for (int i = 0; i < context.Length("GetTotalQueueReport.Data.Length"); i++) {
				getTotalQueueReportResponse_data.Add(context.StringValue("GetTotalQueueReport.Data["+ i +"]"));
			}
			getTotalQueueReportResponse.Data = getTotalQueueReportResponse_data;
        
			return getTotalQueueReportResponse;
        }
    }
}
