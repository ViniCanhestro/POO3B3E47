using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B3E47.BLL
{
    public class tblCdBLL
    {

        tblCdBLL


private DALBD daoBanco = new DALBD();

        public void InserirCd(tblCdDTO dtocd)
        {
            string sql = string.Format($@"INSERT INTO TBL_CD VALUES (NULL, '{dtocd.idCD}',
                                                                   '{dtocd.nomeCD}',
                                                                   '{dtocd.precoVenda}',
                                                                   '{dtocd.dtLancamento}');");

            daoBanco.executarComando(sql);
        }

        public DataTable PesquisarCd(string condicao)
        {
            string sql = string.Format($@"select * from TBL_CD where " + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }

        public void AlterarCd(tblCdDTO dtoCd)
        {
            string sql = string.Format($@"UPDATE TBL_CD set nomeCD = '{dtoCd.Nome_cd}',
                                                    precoVenda = '{dtoCd.Precovenda_cd}',
                                                    dtLancamento = '{dtoCd.Dtlancamento_cd}'
                                                where idCD = '{dtoCd.Id_cd}';");
            daoBanco.executarComando(sql);
        }

        public void ExcluirCd(tblCdDTO dtocd)
        {
            string sql = string.Format($@"DELETE FROM TBL_CD where idCD = {dtocd.Id_cd};");
            daoBanco.executarComando(sql);
        }


    }
}