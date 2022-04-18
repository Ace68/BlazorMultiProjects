using Microsoft.AspNetCore.Components;

namespace MultiProjectsRoute.Modules.Counter;

public class CounterBase : ComponentBase, IDisposable
{
    protected int CurrentCount = 0;

    protected void IncrementCount()
    {
        CurrentCount++;
    }

    #region Dispose
    public void Dispose(bool disposing)
    {
        if (disposing)
        {
        }
    }
    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~CounterBase()
    {
        this.Dispose(false);
    }
    #endregion
}