using br.com.toodoo.core.FieldAggregate;

namespace br.com.toodoo.core.Interfaces.Service;

public interface IFieldService
{
    Task<Field> Add(Field field);
    Task Delete(long fieldId);
    Task<Field?> GetByIdAsync(long id);
    Task<List<Field>> ListAsync();
    Task<Field> UpdateAsync(Field field);
}
