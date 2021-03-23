using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace SE.CAF.CC.Persistance
{
    public static class GenericMapper
    {
        public static IList<TEntity> Map<TEntity>(IDataReader dr) where TEntity : new()
        {
            Type businessEntityType = typeof(TEntity);
            List<TEntity> entitys = new List<TEntity>();
            Hashtable hashtable = new Hashtable();
            PropertyInfo[] properties = businessEntityType.GetProperties();
            foreach (PropertyInfo info in properties)
            {
                hashtable[info.Name.ToUpper()] = info;
            }

            while (dr.Read())
            {
                TEntity newObject = new TEntity();
                for (int index = 0; index < dr.FieldCount; index++)
                {
                    PropertyInfo info = (PropertyInfo)
                                        hashtable[dr.GetName(index).ToUpper()];
                    if ((info != null) && info.CanWrite)
                    {
                        if (dr.GetValue(index).GetType() != typeof(System.DBNull))
                        {

                            if (dr.GetValue(index).GetType() == typeof(System.Decimal) && info.GetType() != typeof(System.Decimal))
                            {
                                decimal d = Convert.ToDecimal(dr.GetValue(index));
                                if (info.PropertyType == typeof(System.Decimal))
                                {
                                    info.SetValue(newObject, d, null);
                                }
                                else if ((d % 1) == 0)
                                {
                                    if (info.PropertyType == typeof(System.Int32))
                                    {
                                        info.SetValue(newObject, Decimal.ToInt32(d), null);
                                    }
                                    else
                                    {
                                        info.SetValue(newObject, Decimal.ToInt64(d), null);
                                    }
                                }
                                else
                                {
                                    //info.SetValue(newObject, Decimal.ToInt32(Math.Round(d)), null); Decimal values are getting rounded off
                                    info.SetValue(newObject, Decimal.ToDouble(d), null);
                                }
                            }
                            else
                                info.SetValue(newObject, dr.GetValue(index), null);
                        }
                    }
                }
                entitys.Add(newObject);
            }
            //}
            dr.Close();
            return entitys;
        }
    }
}
