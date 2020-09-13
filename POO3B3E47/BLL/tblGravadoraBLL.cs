using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using POO3B3E47.DAL;
using POO3B3E47.DTO;

namespace POO3B3E47.BLL
{
    public class tblGravadoraBLL
    {

        private DALBD daoBanco = new DALBD();

        public DataTable index()
        {
            string sql = string.Format($@"select * from TBL_Gravadora");
            return daoBanco.execQuery(sql);
        }

    }
}