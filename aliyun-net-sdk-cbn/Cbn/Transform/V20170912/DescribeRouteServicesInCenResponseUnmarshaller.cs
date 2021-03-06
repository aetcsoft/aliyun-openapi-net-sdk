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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class DescribeRouteServicesInCenResponseUnmarshaller
    {
        public static DescribeRouteServicesInCenResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRouteServicesInCenResponse describeRouteServicesInCenResponse = new DescribeRouteServicesInCenResponse();

			describeRouteServicesInCenResponse.HttpResponse = context.HttpResponse;
			describeRouteServicesInCenResponse.RequestId = context.StringValue("DescribeRouteServicesInCen.RequestId");
			describeRouteServicesInCenResponse.TotalCount = context.IntegerValue("DescribeRouteServicesInCen.TotalCount");
			describeRouteServicesInCenResponse.PageNumber = context.IntegerValue("DescribeRouteServicesInCen.PageNumber");
			describeRouteServicesInCenResponse.PageSize = context.IntegerValue("DescribeRouteServicesInCen.PageSize");

			List<DescribeRouteServicesInCenResponse.DescribeRouteServicesInCen_RouteServiceEntry> describeRouteServicesInCenResponse_routeServiceEntries = new List<DescribeRouteServicesInCenResponse.DescribeRouteServicesInCen_RouteServiceEntry>();
			for (int i = 0; i < context.Length("DescribeRouteServicesInCen.RouteServiceEntries.Length"); i++) {
				DescribeRouteServicesInCenResponse.DescribeRouteServicesInCen_RouteServiceEntry routeServiceEntry = new DescribeRouteServicesInCenResponse.DescribeRouteServicesInCen_RouteServiceEntry();
				routeServiceEntry.CenId = context.StringValue("DescribeRouteServicesInCen.RouteServiceEntries["+ i +"].CenId");
				routeServiceEntry.Host = context.StringValue("DescribeRouteServicesInCen.RouteServiceEntries["+ i +"].Host");
				routeServiceEntry.HostRegionId = context.StringValue("DescribeRouteServicesInCen.RouteServiceEntries["+ i +"].HostRegionId");
				routeServiceEntry.AccessRegionId = context.StringValue("DescribeRouteServicesInCen.RouteServiceEntries["+ i +"].AccessRegionId");
				routeServiceEntry.UpdateInterval = context.StringValue("DescribeRouteServicesInCen.RouteServiceEntries["+ i +"].UpdateInterval");
				routeServiceEntry.Status = context.StringValue("DescribeRouteServicesInCen.RouteServiceEntries["+ i +"].Status");

				List<string> routeServiceEntry_cidrs = new List<string>();
				for (int j = 0; j < context.Length("DescribeRouteServicesInCen.RouteServiceEntries["+ i +"].Cidrs.Length"); j++) {
					routeServiceEntry_cidrs.Add(context.StringValue("DescribeRouteServicesInCen.RouteServiceEntries["+ i +"].Cidrs["+ j +"]"));
				}
				routeServiceEntry.Cidrs = routeServiceEntry_cidrs;

				describeRouteServicesInCenResponse_routeServiceEntries.Add(routeServiceEntry);
			}
			describeRouteServicesInCenResponse.RouteServiceEntries = describeRouteServicesInCenResponse_routeServiceEntries;
        
			return describeRouteServicesInCenResponse;
        }
    }
}
