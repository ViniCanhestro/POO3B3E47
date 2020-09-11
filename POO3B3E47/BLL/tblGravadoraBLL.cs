using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B3E47.BLL
{
    public class tblGravadoraBLL
    {
        tblGravadoraBLL


private DALBD daoBanco = new DALBD();

        public void InserirGravadora(tblGravadoraDTO dtogravadora)
        {
            string sql = string.Format($@"INSERT INTO TBL_Gravadora VALUES (NULL, '{dtogravadora.idGravadora}',
                                                                          '{dtogravadora.nome}');");

            daoBanco.executarComando(sql);
        }

        public DataTable PesquisarGravadoras(string condicao)
        {
            string sql = string.Format($@"select * from TBL_Gravadora where " + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }

        public void AlterarGravadora(tblGravadoraDTO dtoGravadora)
        {
            string sql = string.Format($@"UPDATE TBL_Gravadora set nome = '{dtoGravadora.Nome_gravadora}'
    												   where idGravadora = '{dtoGravadora.Id_gravadora}';");
            daoBanco.executarComando(sql);
        }

        public void ExcluirCliente(tblGravadoraDTO dtogravadora)
        {
            string sql = string.Format($@"DELETE FROM TBL_Gravadora where idGravadora = {dtogravadora.Id_gravadora};");
            daoBanco.executarComando(sql);
        }

    }
}