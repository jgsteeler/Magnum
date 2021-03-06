// Copyright 2007-2010 The Apache Software Foundation.
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
namespace Magnum.Actors
{
	using Internal;
	using Messages;


	public static class ExtensionsToActorInstance
	{
		/// <summary>
		/// Sends an Exit message to an actor instance
		/// </summary>
		/// <param name="instance">The actor instance</param>
		public static void Exit(this ActorInstance instance)
		{
			instance.Send<Exit>(new ExitImpl());
		}

		/// <summary>
		/// Sends a Kill message to an actor instance
		/// </summary>
		/// <param name="instance">The actor instance</param>
		public static void Kill(this ActorInstance instance)
		{
			instance.Send<Kill>(new KillImpl());
		}
	}
}