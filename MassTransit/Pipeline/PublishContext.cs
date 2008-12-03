// Copyright 2007-2008 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Pipeline
{
	using System.Collections.Generic;

	public class PublishContext :
		IPublishContext
	{
		private readonly HashSet<IEndpoint> _endpoints = new HashSet<IEndpoint>();
		private readonly MessagePipeline _pipeline;

		public PublishContext(MessagePipeline pipeline)
		{
			_pipeline = pipeline;
		}

		public void AddEndpointToPublish(IEndpoint endpoint)
		{
			if (!_endpoints.Contains(endpoint))
				_endpoints.Add(endpoint);
		}

		public IEnumerable<IEndpoint> GetEndpoints()
		{
			return _endpoints;
		}
	}
}