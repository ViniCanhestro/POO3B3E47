using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B3E47.BLL
{
    public class tblMusicaBLL
    {
        tblMusicaBLL


private DALBD daoBanco = new DALBD();

        public void InserirMusica(tblMusicaDTO dtomusica)
        {
            string sql = string.Format($@"INSERT INTO TBL_Musica VALUES (NULL, '{dtomusica.idMusica}',
                                                                       '{dtomusica.nome}',
                                                                       '{dtomusica.nomeAutor}',
                                                                       '{dtomusica.idGravadora}',
                                                                       '{dtomusica.idCD}');");

            daoBanco.executarComando(sql);
        }

        public DataTable PesquisarMusica(string condicao)
        {
            string sql = string.Format($@"select * from TBL_Musica where " + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }

        public void AlterarMusica(tblMusicaDTO dtoMusica)
        {
            string sql = string.Format($@"UPDATE TBL_Musica set nome = '{dtoMusica.Nome_musica}',
                                                        nomeAutor = '{dtoMusica.Nomeautor_musica}',
                                                        idGravadora = '{dtoMusica.Id_gravadora}',
                                                        idCD = '{dtoMusica.Id_cd}'
                                                where idMusica = '{dtoMusica.Id_musica}';");
            daoBanco.executarComando(sql);
        }

        public void ExcluirMusica(tblMusicaDTO dtomusica)
        {
            string sql = string.Format($@"DELETE FROM TBL_Musica where idMusica = {dtomusica.Id_musica};");
            daoBanco.executarComando(sql);
        }

    }
}