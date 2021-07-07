using eVet.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eVet.WinUI.Pregledi
{
    public partial class frmPregledUnos : Form
    {
        private APIService _vrsteUsluga = new APIService("VrstaUsluge");
        private APIService _pregledi = new APIService("Pregledi");
        private APIService _dijagnoze = new APIService("Dijagnoze");
        private APIService _racunService = new APIService("Racun");
        private APIService _lijekService = new APIService("Lijek");
        private int? _id;
        private int _ljubimacid;
        public frmPregledUnos(int ljubimacid,int? id = null)
        {
            InitializeComponent();
            _id = id;
            _ljubimacid = ljubimacid;
            
        }
      


        private async void frmPregledUnos_Load(object sender, EventArgs e)
        {
            var result = await _vrsteUsluga.Get<List<Model.VrstaUsluge>>(null);
            result.Insert(0, new Model.VrstaUsluge());
            cmbVrsteUsluga.DisplayMember = "Naziv";
            cmbVrsteUsluga.ValueMember = "VrstaUslugeID";
            cmbVrsteUsluga.DataSource = result;

            var result1 = await _dijagnoze.Get<List<Model.Dijagnoza>>(null);

            clbDijagnoze.DataSource = result1;
            clbDijagnoze.DisplayMember = "Naziv";

            var result2 = await _lijekService.Get<List<Model.Lijek>>(null);
            clbLijekovi.DataSource = result2;
            clbLijekovi.DisplayMember = "Naziv";

            txtPopust.Text = "0";
            if (_id.HasValue)
            {
                var pregledi = await _pregledi.GetById<Model.Pregled>(_id);
                txtNapomena.Text = pregledi.Napomena;
                dtDatum.Value = pregledi.Datum;
                cmbVrsteUsluga.SelectedValue = pregledi.VrstaUslugeId;
                txtPopust.Text = "0";
                var request = new LijekSearchRequest { PregledId = pregledi.PregledId };
                var PregledLijekovi = await _lijekService.Get<List<Model.Lijek>>(request);
                var lijekInt = PregledLijekovi.Select(x => x.LijekID);
                for (int i = 0; i < clbLijekovi.Items.Count; i++)
                {
                    var item = (clbLijekovi.Items[i] as Model.Lijek).LijekID;
                    if (lijekInt.Contains(item))
                    {
                        clbLijekovi.SetItemChecked(i, true);
                    }
                }


                var request1 = new DijagnozaSearchRequest { PregledId = pregledi.PregledId };
                var UstanovljenaDijagnoza = await _dijagnoze.Get<List<Model.Dijagnoza>>(request1);
                var DijagnozaInt = UstanovljenaDijagnoza.Select(x => x.DijagnozaId);
                for (int i = 0; i < clbDijagnoze.Items.Count; i++)
                {
                    var item = (clbDijagnoze.Items[i] as Model.Dijagnoza).DijagnozaId;
                    if (DijagnozaInt.Contains(item))
                    {
                        clbDijagnoze.SetItemChecked(i, true);
                    }
                }

            }

        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                int id = APIService.userid;
                var lista = clbDijagnoze.CheckedItems.Cast<Model.Dijagnoza>().Select(x => x.DijagnozaId).ToList();
                var lista2 = clbLijekovi.CheckedItems.Cast<Model.Lijek>().Select(x => x.LijekID).ToList();
                var request = new PreglediUpsertRequest()
                {
                    VrstaUslugeId = cmbVrsteUsluga.SelectedIndex,
                    Datum = dtDatum.Value,
                    LjubimacId = _ljubimacid,
                    Napomena = txtNapomena.Text,
                    KorisnikId = id,
                    RacunId = null,
                    Dijagnoze = lista,
                    Popust = int.Parse(txtPopust.Text),
                    Lijekovi=lista2
             

                };
                Model.Pregled entity = null;
                if (!_id.HasValue)
                {

                    entity = await _pregledi.Insert<Model.Pregled>(request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno ste dodali pregled");
                        await _racunService.Insert<Model.Racun>(new RacuniInsertRequest
                        {
                            PregledId = entity.PregledId

                        });
                    }




                }
                else
                {
                    entity = await _pregledi.Update<Model.Pregled>(_id.Value, request);
                    MessageBox.Show("Uspješno ste izmjenili pregled");
                }
            }
        }

        private void txtPopust_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^[0-9]$";
            if (string.IsNullOrWhiteSpace(txtPopust.Text))
            {
                errorProvider.SetError(txtPopust, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtPopust.Text, pattern))
            {
                errorProvider.SetError(txtPopust, "Polje mora biti broj");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPopust, null);
            }
        }

        private void txtNapomena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNapomena.Text))
            {
                errorProvider.SetError(txtNapomena, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtNapomena.Text.Length>=200)
            {
                errorProvider.SetError(txtNapomena, "Polje napomena ne smije biti duze od 200 karaktera");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPopust, null);
            }
        }

        private void cmbVrsteUsluga_Validating(object sender, CancelEventArgs e)
        {
            if (cmbVrsteUsluga.SelectedIndex==0)
            {
                errorProvider.SetError(cmbVrsteUsluga, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbVrsteUsluga, null);
            }
        }
    }
}
