namespace Entities.Exceptions;

public class EmployeeNotFoundException : NotFoundException
{
    public EmployeeNotFoundException(Guid emplooyeeId) :
        base($"Employee with id: {emplooyeeId} doesn't exist in the database")
    {
        
    }
}