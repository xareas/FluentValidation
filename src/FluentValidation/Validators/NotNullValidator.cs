#region License
// Copyright 2008-2009 Jeremy Skinner (http://www.jeremyskinner.co.uk)
// 
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
// 
// http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License.
// 
// The latest version of this file can be found at http://www.codeplex.com/FluentValidation
#endregion

namespace FluentValidation.Validators {
	using System;
	using System.Collections.Generic;
	using Resources;

	public class NotNullValidator : PropertyValidator, INotNullValidator, IDoJavascript {
		private readonly static KeyValuePair<string, string> json = new KeyValuePair<string, string>("required", "true");

		public NotNullValidator() : base(() => Messages.notnull_error) {
			SupportsStandaloneValidation = true;
		}

		protected override bool IsValid(PropertyValidatorContext context) {
			if (context.PropertyValue == null) {
				return false;
			}
			return true;
		}

		public IEnumerable<KeyValuePair<string, string>> ToJson() {
			yield return json;
		}
	}

	public interface INotNullValidator : IPropertyValidator {
	}
}