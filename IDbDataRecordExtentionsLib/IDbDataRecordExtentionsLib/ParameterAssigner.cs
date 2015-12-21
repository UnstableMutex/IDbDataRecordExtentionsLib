 using System;
 using System.Data.SqlClient;
 using System.Linq;

static class ParametersAssigner
    {
       static bool IsNullable<T>(T obj)
       {
           if (obj == null) return true; // obvious
           Type type = typeof(T);
           if (!type.IsValueType) return true; // ref-type
           if (Nullable.GetUnderlyingType(type) != null) return true; // Nullable<T>
           return false; // value-type
       }
       public static void Assign(this SqlCommand cmd, object obj)
       {
           SqlCommandBuilder.DeriveParameters(cmd);
           var t = obj.GetType();
           var pr = t.GetProperties();
           foreach (SqlParameter p in cmd.Parameters)
           {
               if (p.ParameterName=="@RETURN_VALUE")
                   continue;
               
               var pn = p.ParameterName.Replace("@", string.Empty).Replace("_", string.Empty).ToLower();
               var prop = pr.SingleOrDefault(x => string.Equals(x.Name, pn, StringComparison.CurrentCultureIgnoreCase));
               object val = prop.GetValue(obj);
               var isnull = IsNullable(val);
               if (isnull & val == null)
               {
                   val = DBNull.Value;
               }



               p.Value = val;
           }

       }
    }
