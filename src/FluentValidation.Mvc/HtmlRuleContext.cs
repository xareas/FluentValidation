namespace FluentValidation.Mvc {
	using System.Collections.Generic;
	using System.Text;
	using Validators;

	public class HtmlRuleContext {
		public string Prefix { get; set; }
		public string Key { get; set; }
		public StringBuilder RulesBuilder { get; set; }
		public StringBuilder MessageBuilder { get; set; }
		public IEnumerable<IPropertyValidator> Validators { get; set; }
	}
}