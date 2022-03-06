using br.com.toodoo.core.FieldAggregate;
using FluentValidation;

namespace br.com.toodoo.core.Validations
{
    public class FieldValidation : AbstractValidator<Field>
    {
        public FieldValidation()
        {
            RuleFor(c => c.FormId)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
