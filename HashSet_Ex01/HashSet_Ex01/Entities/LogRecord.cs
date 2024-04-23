using System;

namespace HashSet_Ex01.Entities
{
    internal class LogRecord
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }

            LogRecord other = (LogRecord)obj;
            return UserName.Equals(other.UserName);
        }
    }
}
