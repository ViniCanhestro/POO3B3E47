using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B3E47.DTO
{
    public class tblGravadoraDTO
    {

        {
        private int idGravadora;
        private string nome;

        public int idGravadora;{ get => idGravadora; set => idGravadora = value; }

    // tratamento de exceção para controle e validação dos campos email e senha

    public string nome
    {
        set
        {
            if (value != string.Empty)
            {
                this.nome = value;
            }
            else
            {
                throw new Exception("O campo nome é obrigatório.");
            }
        }
        get { return this.nome; }

    }

   }

    
