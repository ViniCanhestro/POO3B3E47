using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B3E47.DTO
{
    public class tblCdDTO
    {
        private int idCD;
        private string nomeCD;
        private Double precoVenda;
        private DateTime dtLancamento;

        public int idCD { get => idCD; set => idCD = value; }
        public double precoVenda { get => precoVenda; set => precoVenda = value; }

      

        public string nomeCD
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeCD = value;
                }
                else
                {
                    throw new Exception("O campo nome é obrigatório.");
                }
            }
            get { return this.nomeCD; }
        }


        public double precoVenda
        {
            set
            {
                if (value != 0)
                {
                    this.precoVenda = value;
                }
                else
                {
                    throw new Exception("O campo preco do CD é obrigatório.");
                }
            }
            get { return this.precoVenda; }
        }



        public DateTime dtLancamento
        {
            set
            {
                if (value != 0)
                {
                    this.dtLancamento = value;
                }
                else
                {
                    throw new Exception("O campo data de lançamento do CD é obrigatório.");
                }
            }
            get { return this.dtLancamento; }
        }


    }
}