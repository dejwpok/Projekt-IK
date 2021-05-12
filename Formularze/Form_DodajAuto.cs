﻿using Projekt_IK.db;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Projekt_IK.Formularze
{
    public partial class Form_DodajAuto : Form
    {
        private string defaultImage;
        private string skrzynia = string.Empty;

        private BindingList<Marka> markaBindingList;
        private BindingList<Model> modelBindingList;
        private BindingList<RodzajNadwozia> rodzajNadwoziBindingList;
        private BindingList<KolorNadwozia> kolorNadwoziaBindingList;
        private BindingList<RodzajPaliwa> rodzajPaliwaBindingList;
        private BindingList<PojemnoscSilnika> pojemnoscSilnikaBindingList;
        private BindingList<RokProdukcji> rokProdukcjiBindingList;

        private readonly KomisContext _ctx = new KomisContext();

        public Form_DodajAuto()
        {
            InitializeComponent();

            //Wczytanie bazy danych
            _ctx.Marka.Load();
            markaBindingList = _ctx.Marka.Local.ToBindingList();
            listBoxMarkaAuta.DataSource = markaBindingList;
            listBoxMarkaAuta.DisplayMember = "NazwaMarka";

            _ctx.Model.Load();
            modelBindingList = _ctx.Model.Local.ToBindingList();
            listBoxModelAuta.DataSource = modelBindingList;
            listBoxModelAuta.DisplayMember = "NazwaModel";

            _ctx.RodzajNadwozia.Load();
            rodzajNadwoziBindingList = _ctx.RodzajNadwozia.Local.ToBindingList();
            listBoxRodzajNadwozia.DataSource = rodzajNadwoziBindingList;
            listBoxRodzajNadwozia.DisplayMember = "Nadwozie";

            _ctx.KolorNadwozia.Load();
            kolorNadwoziaBindingList = _ctx.KolorNadwozia.Local.ToBindingList();
            listBoxKolor.DataSource = kolorNadwoziaBindingList;
            listBoxKolor.DisplayMember = "Kolor";

            _ctx.RodzajPaliwa.Load();
            rodzajPaliwaBindingList = _ctx.RodzajPaliwa.Local.ToBindingList();
            listBoxRodzajPaliwa.DataSource = rodzajPaliwaBindingList;
            listBoxRodzajPaliwa.DisplayMember = "Paliwo";

            _ctx.PojemnoscSilnika.Load();
            pojemnoscSilnikaBindingList = _ctx.PojemnoscSilnika.Local.ToBindingList();
            listBoxPojemnoscSilnika.DataSource = pojemnoscSilnikaBindingList;
            listBoxPojemnoscSilnika.DisplayMember = "Pojemnosc";

            _ctx.RokProdukcji.Load();
            rokProdukcjiBindingList = _ctx.RokProdukcji.Local.ToBindingList();
            listBoxRokProdukcji.DataSource = rokProdukcjiBindingList;
            listBoxRokProdukcji.DisplayMember = "Rok";

            //defaultImage = Directory.GetCurrentDirectory() + @"\img\Default.png";
            defaultImage = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + @"\Komis\img\Default.png";

            //Wczytywanie i ustawianie domyślnbego zdjęcia
            if (File.Exists(defaultImage))
            {
                Debug.WriteLine("Def zdjecie istnieje");
                pictureBoxZdjecie1.ImageLocation = defaultImage;
                pictureBoxZdjecie2.ImageLocation = defaultImage;
                pictureBoxZdjecie3.ImageLocation = defaultImage;
                pictureBoxZdjecie4.ImageLocation = defaultImage;
            }
            else
            {
                Debug.WriteLine("Plik nie istnieje");
            }
        }

        private void Form_DodajAuto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        //Marka
        private void listBoxMarkaAuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxMarka.Text = listBoxMarkaAuta.Text;
            
        }

        private void buttonMarkaUsun_Click(object sender, EventArgs e)
        {
            Marka doUsuniecia = (Marka)listBoxMarkaAuta.SelectedItem;
            _ctx.Marka.Remove(doUsuniecia);
            _ctx.SaveChanges();
        }

        private void buttonMarkaEdytuj_Click(object sender, EventArgs e)
        {
            Marka doEdycji = (Marka)listBoxMarkaAuta.SelectedItem;
            doEdycji.NazwaMarka = textBoxMarka.Text;
            _ctx.Marka.AddOrUpdate(doEdycji);
            _ctx.SaveChanges();
            textBoxMarka.Clear();
        }

        private void buttonDodajMarka_Click(object sender, EventArgs e)
        {
            Marka doDodania = new Marka();
            doDodania.NazwaMarka = textBoxMarka.Text;
            _ctx.Marka.Add(doDodania);
            _ctx.SaveChanges();
            textBoxMarka.Clear();
        }

        //Model
        private void listBoxModelAuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxModel.Text = listBoxModelAuta.Text;
            
        }

        private void buttonModelUsun_Click(object sender, EventArgs e)
        {

            Model doUsniecia = (Model)listBoxModelAuta.SelectedItem;
            _ctx.Model.Remove(doUsniecia);
            _ctx.SaveChanges();
        }

        private void buttonModelEdytuj_Click(object sender, EventArgs e)
        {
            Model doEdycji = (Model)listBoxModelAuta.SelectedItem;
            doEdycji.NazwaModel = textBoxModel.Text;
            _ctx.Model.AddOrUpdate(doEdycji);
            _ctx.SaveChanges();
            

        }

        private void buttonModelDodaj_Click(object sender, EventArgs e)
        {
            Model doDodania = new Model();
            doDodania.NazwaModel = textBoxModel.Text;
            _ctx.Model.Add(doDodania);
            _ctx.SaveChanges();
            textBoxModel.Clear();
            
        }

        //Rodzaj nadwozia
        private void listBoxRodzajNadwozia_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRodzajNadwozia.Text = listBoxRodzajNadwozia.Text;
            
        }

        private void buttonUsunRodzajNadwozia_Click(object sender, EventArgs e)
        {
            RodzajNadwozia doUsniecia = (RodzajNadwozia)listBoxRodzajNadwozia.SelectedItem;
            _ctx.RodzajNadwozia.Remove(doUsniecia);
            _ctx.SaveChanges();
        }

        private void buttonEdytujRodzajNadwozia_Click(object sender, EventArgs e)
        {
            RodzajNadwozia doEdycji = (RodzajNadwozia)listBoxRodzajNadwozia.SelectedItem;
            doEdycji.Nadwozie = textBoxRodzajNadwozia.Text;
            _ctx.RodzajNadwozia.AddOrUpdate(doEdycji);
            _ctx.SaveChanges();
            
        }

        private void buttonDodajRodzajNadwozia_Click(object sender, EventArgs e)
        {
            RodzajNadwozia doDodania = new RodzajNadwozia();
            doDodania.Nadwozie = textBoxRodzajNadwozia.Text;
            _ctx.RodzajNadwozia.Add(doDodania);
            _ctx.SaveChanges();
            textBoxRodzajNadwozia.Clear();
        }

        //Kolor nadwozia
        private void listBoxKolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxKolor.Text = listBoxKolor.Text;
            
        }

        private void buttonKolorUsun_Click(object sender, EventArgs e)
        {
            KolorNadwozia doUsniecia = (KolorNadwozia)listBoxKolor.SelectedItem;
            _ctx.KolorNadwozia.Remove(doUsniecia);
            _ctx.SaveChanges();
        }

        private void buttonKolorEdytuj_Click(object sender, EventArgs e)
        {
            KolorNadwozia doEdycji = (KolorNadwozia)listBoxKolor.SelectedItem;
            doEdycji.Kolor = textBoxKolor.Text;
            _ctx.KolorNadwozia.AddOrUpdate(doEdycji);
            _ctx.SaveChanges();


        }

        private void buttonKolorDodaj_Click(object sender, EventArgs e)
        {
            KolorNadwozia doDodania = new KolorNadwozia();
            doDodania.Kolor = textBoxKolor.Text;
            _ctx.KolorNadwozia.Add(doDodania);
            _ctx.SaveChanges();
            textBoxKolor.Clear();
        }

        //Rodzaj paliwa
        private void listBoxRodzajPaliwa_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRodzajPaliwa.Text = listBoxRodzajPaliwa.Text;
            
        }

        private void buttonUsunRodzajPaliwa_Click(object sender, EventArgs e)
        {
            RodzajPaliwa doUsniecia = (RodzajPaliwa)listBoxRodzajPaliwa.SelectedItem;
            _ctx.RodzajPaliwa.Remove(doUsniecia);
            _ctx.SaveChanges();
        }

        private void buttonEdytujRodzajPaliwa_Click(object sender, EventArgs e)
        {
            RodzajPaliwa doEdycji = (RodzajPaliwa)listBoxRodzajPaliwa.SelectedItem;
            doEdycji.Paliwo = textBoxRodzajPaliwa.Text;
            _ctx.RodzajPaliwa.AddOrUpdate(doEdycji);
            _ctx.SaveChanges();

        }

        private void buttonDodajRodzajPaliwa_Click(object sender, EventArgs e)
        {
            RodzajPaliwa doDodania = new RodzajPaliwa();
            doDodania.Paliwo = textBoxRodzajPaliwa.Text;
            _ctx.RodzajPaliwa.Add(doDodania);
            _ctx.SaveChanges();
            textBoxRodzajPaliwa.Clear();
        }

        //Pojemnosc silnika
        private void listBoxPojemnoscSilnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPojemnoscSilnika.Text = listBoxPojemnoscSilnika.Text;
            
        }

        private void buttonUsunPojemnoscSilnika_Click(object sender, EventArgs e)
        {
            PojemnoscSilnika doUsniecia = (PojemnoscSilnika)listBoxPojemnoscSilnika.SelectedItem;
            _ctx.PojemnoscSilnika.Remove(doUsniecia);
            _ctx.SaveChanges();
        }

        private void buttonEdytujPojemnoscSilnika_Click(object sender, EventArgs e)
        {
            PojemnoscSilnika doEdycji = (PojemnoscSilnika)listBoxPojemnoscSilnika.SelectedItem;
            doEdycji.Pojemnosc = double.Parse(textBoxPojemnoscSilnika.Text, CultureInfo.InvariantCulture);
            _ctx.PojemnoscSilnika.AddOrUpdate(doEdycji);
            _ctx.SaveChanges();

        }

        private void buttonDodajPojemnoscSilnika_Click(object sender, EventArgs e)
        {
            PojemnoscSilnika doDodania = new PojemnoscSilnika();
            doDodania.Pojemnosc = double.Parse(textBoxPojemnoscSilnika.Text, CultureInfo.InvariantCulture);
            _ctx.PojemnoscSilnika.Add(doDodania);
            _ctx.SaveChanges();
            textBoxPojemnoscSilnika.Clear();
        }

        //Rok produkcji
        private void listBoxRokProdukcji_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRokProdukcji.Text = listBoxRokProdukcji.Text;
            
        }

        private void buttonUsunRokProdukcji_Click(object sender, EventArgs e)
        {
            RokProdukcji doUsniecia = (RokProdukcji)listBoxRokProdukcji.SelectedItem;
            _ctx.RokProdukcji.Remove(doUsniecia);
            _ctx.SaveChanges();
        }

        private void buttonEdytujRokProdukcji_Click(object sender, EventArgs e)
        {
            RokProdukcji doEdycji = (RokProdukcji)listBoxRokProdukcji.SelectedItem;
            doEdycji.Rok = int.Parse(textBoxRokProdukcji.Text);
            _ctx.RokProdukcji.AddOrUpdate(doEdycji);
            _ctx.SaveChanges();

        }

        private void buttonDodajRokProdukcji_Click(object sender, EventArgs e)
        {
            RokProdukcji doDodania = new RokProdukcji();
            doDodania.Rok = int.Parse(textBoxRokProdukcji.Text);
            _ctx.RokProdukcji.Add(doDodania);
            _ctx.SaveChanges();
            textBoxRokProdukcji.Clear();
        }

        private void buttonDodajOferte_Click(object sender, EventArgs e)
        {
            try
            {
                //Tworzenie oferty
                AutoNaSprzedaz autoNaSprzedaz = new AutoNaSprzedaz();
                autoNaSprzedaz.TytulOferty = textBoxTytulOferty.Text;
                autoNaSprzedaz.Przebieg = int.Parse(textBoxPrzebieg.Text);
                autoNaSprzedaz.Moc = int.Parse(textBoxMoc.Text);
                autoNaSprzedaz.IloscMiejs = int.Parse(textBoxIloscMiejsc.Text);
                autoNaSprzedaz.Opis = richTextBoxOpis.Text;
                autoNaSprzedaz.Cena = int.Parse(textBoxCena.Text);
                autoNaSprzedaz.KolorNadwozia = (KolorNadwozia)listBoxKolor.SelectedItem;
                autoNaSprzedaz.Marka = (Marka)listBoxMarkaAuta.SelectedItem;
                autoNaSprzedaz.Model = (Model)listBoxModelAuta.SelectedItem;
                autoNaSprzedaz.PojemnoscSilnika = (PojemnoscSilnika)listBoxPojemnoscSilnika.SelectedItem;
                autoNaSprzedaz.RodzajNadwozia = (RodzajNadwozia)listBoxRodzajNadwozia.SelectedItem;
                autoNaSprzedaz.RodzajPaliwa = (RodzajPaliwa)listBoxRodzajPaliwa.SelectedItem;
                autoNaSprzedaz.RokProdukcji = (RokProdukcji)listBoxRokProdukcji.SelectedItem;
                autoNaSprzedaz.TypSkrzyniBiegow = skrzynia;
                autoNaSprzedaz.Pic1 = pictureBoxZdjecie1.ImageLocation;
                autoNaSprzedaz.Pic2 = pictureBoxZdjecie2.ImageLocation;
                autoNaSprzedaz.Pic3 = pictureBoxZdjecie3.ImageLocation;
                autoNaSprzedaz.Pic4 = pictureBoxZdjecie4.ImageLocation;

                //Zapisywanie w bazie danych
                _ctx.AutoAutoNaSprzedaz.Add(autoNaSprzedaz);
                _ctx.SaveChanges();
                MessageBox.Show("Pomyślnie dodano ofertę sprzedaży!");
            }
            catch
            {
                MessageBox.Show("Coś poszło nie tak.");
            }
        }

        //Obsluga pol ze zdjęciami
        private void buttonDodajZdjecie1_Click(object sender, EventArgs e)
        {
            pictureBoxZdjecie1.ImageLocation = WyborZdjecia();
        }

        private void buttonUsunZdjecie1_Click(object sender, EventArgs e)
        {
            pictureBoxZdjecie1.ImageLocation = defaultImage;
        }

        private void buttonDodajZdjecie2_Click(object sender, EventArgs e)
        {
            pictureBoxZdjecie2.ImageLocation = WyborZdjecia();
        }

        private void buttonUsunZdjecie2_Click(object sender, EventArgs e)
        {
            pictureBoxZdjecie2.ImageLocation = defaultImage;

        }

        private void buttonDodajZdjecie3_Click(object sender, EventArgs e)
        {
            pictureBoxZdjecie3.ImageLocation = WyborZdjecia();
        }

        private void buttonUsunZdjecie3_Click(object sender, EventArgs e)
        {
            pictureBoxZdjecie3.ImageLocation = defaultImage;

        }

        private void buttonDodajZdjecie4_Click(object sender, EventArgs e)
        {
            pictureBoxZdjecie4.ImageLocation = WyborZdjecia();
        }

        private void buttonUsunZdjecie4_Click(object sender, EventArgs e)
        {
            pictureBoxZdjecie4.ImageLocation = defaultImage;
        }

        private string WyborZdjecia()
        {

            string targetImagePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + @"\Komis\img\";
            string uniqueFileName = defaultImage;

            //wybiera zdjęcie
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Zdjęcia(*.jpg, *jpeg, *.bmp, *.png) | *.jpg; *.jpeg; *.bmp; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceImagePath = openFileDialog.FileName;
                //Kopiuje zdjęcie do katalogu common documents\Komis\img\ i nadaje mu uniklną nazwe
                uniqueFileName = targetImagePath + string.Format(@"{0}" + Path.GetExtension(openFileDialog.FileName), DateTime.Now.Ticks);
                File.Copy(sourceImagePath, uniqueFileName);
            }
            //zwraca sciezka dostepu do pliku
            return uniqueFileName;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            skrzynia = "Automatyczna";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            skrzynia = "Manualna";
        }

        private void pictureBoxZdjecie1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMarka_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
