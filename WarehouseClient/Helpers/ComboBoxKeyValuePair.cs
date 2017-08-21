using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseClient.Helpers
{
    public class ComboBoxKeyValuePair
    {
        /// <summary>
        /// m_objKey
        /// </summary>
        public object m_objKey;
        private string m_strValue;

        /// <summary>
        /// StrValue
        /// </summary>
        public string StrValue
        {
            get { return m_strValue; }
            set { m_strValue = value; }
        }

        /// <summary>
        /// ComboBoxKeyValuePair
        /// </summary>
        /// <param name="NewKey"></param>
        /// <param name="NewValue"></param>
        public ComboBoxKeyValuePair(object NewKey, string NewValue)
        {
            m_objKey = NewKey;
            m_strValue = NewValue;
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return m_strValue;
        }
    }
}
