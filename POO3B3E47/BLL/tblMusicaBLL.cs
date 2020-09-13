using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using POO3B3E47.DAL;
using POO3B3E47.DTO;

namespace POO3B3E47.BLL
{
    public class tblMusicaBLL
    {
        private DALBD daoBanco = new DALBD();

        public DataTable index()
        {
            string sql = string.Format($@"select * from TBL_Musica");
            return daoBanco.execQuery(sql);
        }

        public void InserirMusica(tblMusicaDTO dtomusica)
        {
            string sql = string.Format($@"INSERT INTO TBL_Musica VALUES (NULL, '{dtomusica.IdMusica}',
                                                                       '{dtomusica.nome}',
                                                                       '{dtomusica.nomeAutor}',
                                                                       '{dtomusica.idGravadora}',
                                                                       '{dtomusica.idCD}');");

            daoBanco.execCommand(sql);
        }

        public void AlterarMusica(tblMusicaDTO dtoMusica)
        {
            string sql = string.Format($@"UPDATE TBL_Musica set nome = '{dtoMusica.Nome_musica}',
                                                        nomeAutor = '{dtoMusica.Nomeautor_musica}',
                                                        idGravadora = '{dtoMusica.Id_gravadora}',
                                                        idCD = '{dtoMusica.Id_cd}'
                                                where idMusica = '{dtoMusica.Id_musica}';");
            daoBanco.execCommand(sql);
        }

        public void ExcluirMusica(tblMusicaDTO dtomusica)
        {
            string sql = string.Format($@"DELETE FROM TBL_Musica where idMusica = {dtomusica.Id_musica};");
            daoBanco.execCommand(sql);
        }

    }
}