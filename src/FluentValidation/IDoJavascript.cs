namespace FluentValidation {
	using System.Collections.Generic;

	public interface IDoJavascript {
		IEnumerable<KeyValuePair<string, string>> ToJson();
	}
}