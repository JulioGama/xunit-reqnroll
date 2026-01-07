using Xunit;
using FluentValidation.TestHelper;
using xunit_reqnroll.Production.Validators;
using xunit_reqnroll.Production.Models; 

namespace xunit_reqnroll.Tests.Drivers
{
    public class BuyerQuestionnaireModelValidatorTests
    {
        private readonly BuyerQuestionnaireModelValidator _validator;
        public BuyerQuestionnaireModelValidatorTests()
        {
            _validator = new BuyerQuestionnaireModelValidator();
        }
        [Fact]
        public void QuestionType_Obrigatorio_DeveFalharSeVazio()
        {
            var model = new BuyerQuestionnaireModel
            {
                QuestionBeingEdited = new Question
                {
                    QuestionType = "", // inválido
                    RegEx = null
                }
            };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(q => q.QuestionBeingEdited.QuestionType);
        }
    }
}