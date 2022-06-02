using S10_MultipleForms.Util.Entity;
using S10_MultipleForms.Util.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_MultipleForms
{
    internal class S10_MultipleForms{
        private static S10_MultipleForms instance = new S10_MultipleForms();
        private SQL sql = new SQL();
        private ProvTable provTable = new ProvTable();

        public void onStart()
        {
            sql.connectSQL();
        }



        public static S10_MultipleForms getInstance() { return instance; }
        public SQL getSQL() { return sql; }
        public ProvTable GetProvTable() { return provTable; }

    }
}
