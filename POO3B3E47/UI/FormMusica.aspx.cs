using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using POO3B3E47.BLL;
using POO3B3E47.DTO;

namespace POO3B3E47.UI
{
    public partial class FormMusica : System.Web.UI.Page
    {

        tblGravadoraBLL gravadoraBLL = new tblGravadoraBLL();
        tblCdBLL cdBLL = new tblCdBLL();

        tblMusicaBLL musicaBLL = new tblMusicaBLL();
        tblMusicaDTO musicaDTO = new tblMusicaDTO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                drpCd.DataSource = cdBLL.index();
                drpCd.DataTextField = "nome";
                drpCd.DataValueField = "idCd";
                drpCd.DataBind();

                drpGravadora.DataSource = gravadoraBLL.index();
                drpGravadora.DataTextField = "nome";
                drpGravadora.DataValueField = "idGravadora";
                drpGravadora.DataBind();

                PopulateGrid();
            }
        }

        public void PopulateGrid()
        {
            GridMusica.DataSource = musicaBLL.index();
            GridMusica.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                musicaDTO.IdCD = int.Parse(drpCd.SelectedValue.ToString());
                musicaDTO.IdGravadora = int.Parse(drpGravadora.SelectedValue.ToString());
                musicaDTO.Nome = txtNome.Text;
                musicaDTO.NomeAutor = txtNomeAutor.Text;

                musicaBLL.InserirMusica(musicaDTO);

                messageError.Visible = false;

                PopulateGrid();

                messageSuccess.Visible = true;
                messageSuccess.Text = "Música salva!";
            }
            catch (Exception error)
            {
                messageSuccess.Visible = false;
                messageError.Visible = true;
                messageError.Text = error.Message;
            }
        }

        protected void GridMusica_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                musicaDTO.IdMusica = Convert.ToInt32(e.Values[0]);
                musicaBLL.ExcluirMusica(musicaDTO);

                messageSuccess.Visible = true;
                messageSuccess.Text = "Música deletada!";

                PopulateGrid();
            }
            catch (Exception ex)
            {
                messageError.Visible = true;
                messageError.Text = ex.Message;
            }
        }

        protected void GridMusica_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridMusica.EditIndex = e.NewEditIndex;
            PopulateGrid();
        }

        protected void GridMusica_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                musicaDTO.IdCD = int.Parse(e.NewValues[0].ToString());
                musicaDTO.IdGravadora = int.Parse(e.NewValues[1].ToString());
                musicaDTO.Nome = e.NewValues[2].ToString();
                musicaDTO.NomeAutor = e.NewValues[3].ToString();

                musicaBLL.AlterarMusica(musicaDTO);

                GridMusica.EditIndex = -1;
                PopulateGrid();
            }
            catch (Exception ex)
            {
                messageError.Visible = true;
                messageError.Text = ex.Message;
            }
        }

        protected void GridMusica_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridMusica.EditIndex = -1;
            PopulateGrid();
        }
    }
}
}