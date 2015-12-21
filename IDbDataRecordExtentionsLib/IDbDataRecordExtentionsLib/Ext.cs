using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

using System.Text;


namespace IDbDataRecordExtentionsLib
{
    public static class Ext
    {
        public static bool GetBoolean(this IDataRecord r, string fieldName, bool def)
        {
            var ind = r.GetOrdinal(fieldName);
            if (r.IsDBNull(ind))
            {
                return def;
            }
            else
            {
                return r.GetBoolean(ind);
            }
        }

        public static bool GetBoolean(this IDataRecord r, string fieldName)
        {
            return r.GetBoolean(r.GetOrdinal(fieldName));
        }

        public static byte GetByte(this IDataRecord r, string fieldName, byte def)
        {
            var ind = r.GetOrdinal(fieldName);
            if (r.IsDBNull(ind))
            {
                return def;
            }
            else
            {
                return r.GetByte(ind);
            }
        }

        public static byte GetByte(this IDataRecord r, string fieldName)
        {
            return r.GetByte(r.GetOrdinal(fieldName));
        }

        public static DateTime GetDateTime(this IDataRecord r, string fieldName, DateTime def)
        {

            var ind = r.GetOrdinal(fieldName);
            if (r.IsDBNull(ind))
            {
                return def;
            }
            else
            {
                return r.GetDateTime(ind);
            }
        }

        public static DateTime GetDateTime(this IDataRecord reader, string fieldName)
        {
            return reader.GetDateTime(reader.GetOrdinal(fieldName));
        }

        public static decimal GetDecimal(this IDataRecord r, string fieldName, decimal def)
        {
            var ind = r.GetOrdinal(fieldName);
            if (r.IsDBNull(ind))
            {
                return def;
            }
            else
            {
                return r.GetDecimal(ind);
            }
        }

        public static decimal GetDecimal(this IDataRecord r, string fieldName)
        {
            return r.GetDecimal(r.GetOrdinal(fieldName));
        }

        public static Guid GetGuid(this IDataRecord r, string fieldName, Guid def)
        {
            var ind = r.GetOrdinal(fieldName);
            if (r.IsDBNull(ind))
            {
                return def;
            }
            else
            {
                return r.GetGuid(ind);
            }
        }

        public static Guid GetGuid(this IDataRecord r, string fieldName)
        {
            return r.GetGuid(r.GetOrdinal(fieldName));
        }

        public static short GetInt16(this IDataRecord r, string fieldName, short def)
        {
            var ind = r.GetOrdinal(fieldName);
            if (r.IsDBNull(ind))
            {
                return def;
            }
            else
            {
                return r.GetInt16(ind);
            }
        }

        public static short GetInt16(this IDataRecord r, string fieldName)
        {
            return r.GetInt16(r.GetOrdinal(fieldName));
        }

        public static int GetInt32(this IDataRecord r, string fieldName, int def)
        {
            var ind = r.GetOrdinal(fieldName);
            if (r.IsDBNull(ind))
            {
                return def;
            }
            else
            {
                return r.GetInt32(ind);
            }
        }

        public static int GetInt32(this IDataRecord r, string fieldName)
        {
            return r.GetInt32(r.GetOrdinal(fieldName));
        }

        public static long GetInt64(this IDataRecord r, string fieldName, long def)
        {
            var ind = r.GetOrdinal(fieldName);
            if (r.IsDBNull(ind))
            {
                return def;
            }
            else
            {
                return r.GetInt64(ind);
            }
        }

        public static long GetInt64(this IDataRecord r, string fieldName)
        {
            return r.GetInt64(r.GetOrdinal(fieldName));
        }

        public static string GetString(this IDataRecord r, string fieldName, string def)
        {
            var ind = r.GetOrdinal(fieldName);
            if (r.IsDBNull(ind))
            {
                return def;
            }
            else
            {
                return r.GetString(ind);
            }
        }
        public static string GetString(this IDataRecord r, string fieldName)
        {
            var ind = r.GetOrdinal(fieldName);
            return r.GetString(ind);
        }
        public static string GetStringTrim(this IDataRecord r, int index)
        {
            return r.GetString(index).Trim();
        }

        public static string GetStringTrim(this IDataRecord r, string fieldName)
        {
            return r.GetString(r.GetOrdinal(fieldName)).Trim();
        }

        public static bool IsDBNull(this IDataRecord r, string fieldName)
        {
            return r.IsDBNull(r.GetOrdinal(fieldName));
        }
    }
}
