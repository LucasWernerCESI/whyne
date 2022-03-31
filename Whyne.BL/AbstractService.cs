using Whyne.DAL;

namespace Whyne.BL;

public abstract class AbstractService
{
    protected readonly WhyneContext _context;
    public AbstractService(WhyneContext context)
    {
        _context = context;
    }
}