using br.com.toodoo.core.FieldAggregate;
using br.com.toodoo.core.Interfaces.Infrastructure;
using br.com.toodoo.core.Interfaces.Service;
using br.com.toodoo.core.Validations;
using br.com.toodoo.sharedkernel;
using br.com.toodoo.sharedkernel.Interfaces;

namespace br.com.toodoo.service;

public class FieldService : BaseService<Field>, IFieldService
{
    private readonly IFieldRepository _fieldRepository;

    public FieldService(IFieldRepository fieldRepository, INotifier notifier)
        : base(notifier)
    {
        _fieldRepository = fieldRepository;
    }

    public async Task<Field> Add(Field field)
    {
        if (!ExecutarValidacao(new FieldValidation(), field))
        {
            return null;
        }

        return await _fieldRepository.AddAsync(field);
    }

    public async Task Delete(long fieldId)
    {
        await _fieldRepository.DeleteAsync(fieldId);
    }

    public async Task<Field?> GetByIdAsync(long id)
    {
        return await _fieldRepository.GetByIdAsync(id);
    }

    public async Task<List<Field>> ListAsync()
    {
        return await _fieldRepository.ListAsync();
    }

    public async Task<Field> UpdateAsync(Field field)
    {
        if (!ExecutarValidacao(new FieldValidation(), field))
        {
            return null;
        }

        return await _fieldRepository.UpdateAsync(field);
    }
}
