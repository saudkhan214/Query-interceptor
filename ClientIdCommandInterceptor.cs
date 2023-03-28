using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreQuery
{
    public class ClientIdCommandInterceptor : DbCommandInterceptor
    {
        public override InterceptionResult<int> NonQueryExecuting(
       DbCommand command,
       CommandEventData eventData,
       InterceptionResult<int> result)
        {
            // TODO: Add your business logic
            // var dbName = connection.Database;
            // var commandText = command.CommandText;
            return result;
        }

        public override ValueTask<InterceptionResult<int>> NonQueryExecutingAsync(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<int> result,
            CancellationToken cancellationToken = default)
        {
            // TODO: Add your business logic
            // var dbName = connection.Database;
            // var commandText = command.CommandText;
            return new ValueTask<InterceptionResult<int>>(result);
        }

        public override InterceptionResult<DbDataReader> ReaderExecuting(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<DbDataReader> result)
        {
            // TODO: Add your business logic
            // var dbName = connection.Database;
            // var commandText = command.CommandText;
            if ((command.CommandText.Contains("ClientId") || command.CommandText.Contains("COUNT")) && !command.CommandText.Contains("INSERT"))
            {
                if (command.CommandText.Contains("where") || command.CommandText.Contains("WHERE"))
                    command.CommandText += " and ClientId=12345";
                else
                    command.CommandText += " where ClientId=12345";
            }
            return result;
        }

        public override ValueTask<InterceptionResult<DbDataReader>> ReaderExecutingAsync(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<DbDataReader> result,
            CancellationToken cancellationToken = default)
        {
            // TODO: Add your business logic
            // var dbName = connection.Database;
            // var commandText = command.CommandText;
            return new ValueTask<InterceptionResult<DbDataReader>>(result);
        }

        public override InterceptionResult<object> ScalarExecuting(
           DbCommand command,
           CommandEventData eventData,
           InterceptionResult<object> result)
        {
            // TODO: Add your business logic
            // var dbName = connection.Database;
            // var commandText = command.CommandText;
            return result;
        }

        public override ValueTask<InterceptionResult<object>> ScalarExecutingAsync(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<object> result,
            CancellationToken cancellationToken = default)
        {
            // TODO: Add your business logic
            // var dbName = connection.Database;
            // var commandText = command.CommandText;
            return new ValueTask<InterceptionResult<object>>(result);
        }
    }

}
