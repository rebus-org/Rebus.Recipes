using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Rebus.Transport;

namespace Rebus.Recipes.Test
{
    class FakeTransactionContext : ITransactionContext
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void OnCommitted(Func<Task> commitAction)
        {
            throw new NotImplementedException();
        }

        public void OnAborted(Action abortedAction)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted(Func<Task> completedAction)
        {
            throw new NotImplementedException();
        }

        public void OnDisposed(Action disposedAction)
        {
            throw new NotImplementedException();
        }

        public void Abort()
        {
            throw new NotImplementedException();
        }

        public Task Commit()
        {
            throw new NotImplementedException();
        }

        public ConcurrentDictionary<string, object> Items { get; } = new ConcurrentDictionary<string, object>();
    }
}