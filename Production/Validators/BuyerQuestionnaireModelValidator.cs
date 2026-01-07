using FluentValidation;
using System.Text.RegularExpressions;

namespace xunit_reqnroll.Production.Validators
{
    public class BuyerQuestionnaireModelValidator : AbstractValidator<BuyerQuestionnaireModel>
    {
        private List<string> GetRegexParts(string concatenatedList, string separator)
        {
            if (string.IsNullOrWhiteSpace(concatenatedList))
                return new List<string>();

            var parts = concatenatedList.Split(new[] { separator }, StringSplitOptions.None);
            return parts.Length > 0 ? parts.ToList() : new List<string>();
        }

        public BuyerQuestionnaireModelValidator()
        {
            RuleFor(p => p.QuestionBeingEdited.QuestionType)
                .NotEmpty()
                .WithMessage(BuyerQuestionnaireResource.RequiredField);

            RuleFor(p => p.QuestionBeingEdited.RegEx)
                .Custom((value, context) =>
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        try
                        {
                            var regexParts = GetRegexParts(value, separator: "%%");
                            if (!regexParts.Any())
                                return;

                            foreach (var regexPart in regexParts)
                            {
                                var regexWithReturn = GetRegexParts(regexPart, separator: "||");
                                if (regexWithReturn.Any())
                                    _ = new Regex(regexWithReturn[0], RegexOptions.None, TimeSpan.FromSeconds(5));
                            }
                        }
                        catch
                        {
                            context.AddFailure(BuyerQuestionnaireResource.InvalidRegularExpression);
                        }
                    }
                });
        }
    }
}
