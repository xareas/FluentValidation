namespace FluentValidation.MvcSample.Models {
	public class Step1Validator : AbstractValidator<Step1> {
		public Step1Validator() {
			RuleFor(u => u.Required).NotEmpty().WithMessage("Please fill this in!");
			RuleFor(u => u.Minimum).NotEmpty().Length(3);
			RuleFor(u => u.Maximum).Length(0, 10);
			RuleFor(u => u.MinMax).NotEmpty().Length(4, 9);
			RuleFor(u => u.Email).NotEmpty().EmailAddress(); //.Pattern(ValidationPattern.Email);
			//TODO
			//RuleFor(u => u.CreditCard).NotEmpty().Pattern(ValidationPattern.CreditCard);
			//RuleFor(u => u.Url).NotEmpty().Pattern(ValidationPattern.Url);
			//RuleFor(u => u.Number).NotEmpty().Pattern(ValidationPattern.Number);
			//sRuleFor(u => u.Digits).NotEmpty().Pattern(ValidationPattern.Digits);
		}
	}
}