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
namespace Magnum.Reflection
{
	using System;
	using System.Linq.Expressions;

	public static class ExtensionsToSafeProperty
	{
		public static SafeProperty CreateSafeProperty<T,V>(this Expression<Func<T, V>> expression)
		{
			return SafeProperty.Create(expression);
		}

		public static SafeProperty CreateSafeProperty<T,V>(this Expression<Func<T, int, V>> expression)
		{
			return SafeProperty.Create(expression);
		}
	}
}