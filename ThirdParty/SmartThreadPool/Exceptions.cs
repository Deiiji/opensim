using System;
using System.Runtime.Serialization;

namespace Amib.Threading
{
    #region Exceptions

    /// <summary>
    /// Represents an exception in case IWorkItemResult.GetResult has been canceled
    /// </summary>
    public sealed partial class WorkItemCancelException : Exception
    {
        public WorkItemCancelException()
        {
        }

        public WorkItemCancelException(string message)
            : base(message)
        {
        }

        public WorkItemCancelException(string message, Exception e)
            : base(message, e)
        {
        }
    }

    /// <summary>
    /// Represents an exception in case IWorkItemResult.GetResult has been timed out
    /// </summary>
    public sealed partial class WorkItemTimeoutException : Exception
    {
        public WorkItemTimeoutException()
        {
        }

        public WorkItemTimeoutException(string message)
            : base(message)
        {
        }

        public WorkItemTimeoutException(string message, Exception e)
            : base(message, e)
        {
        }
    }

    /// <summary>
    /// Represents an exception in case IWorkItemResult.GetResult has been timed out
    /// </summary>
    public sealed partial class WorkItemResultException : Exception
    {
        public WorkItemResultException()
        {
        }

        public WorkItemResultException(string message)
            : base(message)
        {
        }

        public WorkItemResultException(string message, Exception e)
            : base(message, e)
        {
        }
    }
    #endregion
}
