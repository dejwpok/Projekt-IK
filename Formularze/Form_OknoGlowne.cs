﻿using Projekt_IK.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Projekt_IK.Formularze
{
    public partial class Form_OknoGlowne : Form
    {
        private BindingList<AutoNaSprzedaz> data;
        private readonly KomisContext _ctx = new KomisContext();

        public int PoziomLogowania;

        public Form_OknoGlowne()
        {
            InitializeComponent();
            listcollection.Clear();
            foreach (string str in listBoxSearch.Items)
            {
                listcollection.Add(str);
                textBox1Search.CharacterCasing = CharacterCasing.Lower;
            }

            buttonPanelUzytkownikow.Visible = false;
            buttonDodajAuto.Visible = false;
            buttonUsun.Visible = false;


        }
        private void Form_OknoGlowne_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void buttonPanelUzytkownikow_Click(object sender, EventArgs e)
        {
            //otwierania okna uzytkownikow (poziom kierownik)
            Form_PanelUzytkownikow panelUzytkownikow = new Form_PanelUzytkownikow();
            panelUzytkownikow.Show(this);
            this.Hide();
        }

        //lista ofert (wszyscy)
        private void listBoxListaOfert_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoNaSprzedaz zaznaczoneAutoNaSprzedaz = (AutoNaSprzedaz)listBoxListaOfert.SelectedItem;
            labelTytulOferty.Text = zaznaczoneAutoNaSprzedaz.TytulOferty;
            labelCena.Text = "Cena: " + zaznaczoneAutoNaSprzedaz.Cena;
            labelIloscMiejs.Text = "Liczba miejsc: " + zaznaczoneAutoNaSprzedaz.IloscMiejs;
            labelKolorNadwozia.Text = "Kolor: " + zaznaczoneAutoNaSprzedaz.KolorNadwozia.Kolor;
            labelMarka.Text = zaznaczoneAutoNaSprzedaz.Marka.NazwaMarka + " " + zaznaczoneAutoNaSprzedaz.Model.NazwaModel;
            labelMoc.Text = "Moc: " + zaznaczoneAutoNaSprzedaz.Moc + "KM";
            labelPojemnoscSilnika.Text = "Pojemność silnika: " + zaznaczoneAutoNaSprzedaz.PojemnoscSilnika.Pojemnosc.ToString(CultureInfo.InvariantCulture);
            labelPrzebieg.Text = "Przebieg: " + zaznaczoneAutoNaSprzedaz.Przebieg;
            labelRodzajNadwozia.Text = "Nadwozie: " + zaznaczoneAutoNaSprzedaz.RodzajNadwozia.Nadwozie;
            labelRodzajPaliwa.Text = "Rodzaj paliwa: " + zaznaczoneAutoNaSprzedaz.RodzajPaliwa.Paliwo;
            labelRokProdukcji.Text = "Rok produkcji: " + zaznaczoneAutoNaSprzedaz.RokProdukcji.Rok;
            labelTypSkrzyniBiegow.Text = "Skrzynia biegów: " + zaznaczoneAutoNaSprzedaz.TypSkrzyniBiegow;
            richTextBoxOpis.Text = zaznaczoneAutoNaSprzedaz.Opis;
            pictureBox.ImageLocation = zaznaczoneAutoNaSprzedaz.Pic1;
        }

        //otwieranie okna dodania auta (poziom sprzedawca i kierownik)
        private void buttonDodajAuto_Click(object sender, EventArgs e)
        {
            Form_DodajAuto dodajAuto = new Form_DodajAuto();
            dodajAuto.Show(this);
            this.Hide();
        }
        //Usuwanie w bazie danych
        private void buttonUsun_Click(object sender, EventArgs e)
        {
            AutoNaSprzedaz zaznaczoneAutoNaSprzedaz = (AutoNaSprzedaz)listBoxListaOfert.SelectedItem;
            _ctx.AutoAutoNaSprzedaz.Remove(zaznaczoneAutoNaSprzedaz);
            _ctx.SaveChanges();
            MessageBox.Show("Pomyślnie usunięto ofertę sprzedaży!");
        }

        private void Form_OknoGlowne_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Okno główne, przyjęty parametr: " + PoziomLogowania);
            //przyjecie wartości z panelu logowania
            switch (PoziomLogowania)
            {
                case 0:
                    Debug.WriteLine("switch 0");
                    break;
                case 1:
                    Debug.WriteLine("switch 1");
                    buttonDodajAuto.Visible = true;
                    buttonUsun.Visible = true;
                    break;
                case 2:
                    Debug.WriteLine("switch 2");
                    buttonPanelUzytkownikow.Visible = true;
                    buttonDodajAuto.Visible = true;
                    buttonUsun.Visible = true;
                    break;
            }

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            //klikniecie otwiera przegladarke zdjec
            Form_PrzegladarkaZdjec przegladarkaZdjec = new Form_PrzegladarkaZdjec();
            AutoNaSprzedaz zaznaczoneAutoNaSprzedaz = (AutoNaSprzedaz)listBoxListaOfert.SelectedItem;
            przegladarkaZdjec.pic1 = zaznaczoneAutoNaSprzedaz.Pic1;
            przegladarkaZdjec.pic2 = zaznaczoneAutoNaSprzedaz.Pic2;
            przegladarkaZdjec.pic3 = zaznaczoneAutoNaSprzedaz.Pic3;
            przegladarkaZdjec.pic4 = zaznaczoneAutoNaSprzedaz.Pic4;
            przegladarkaZdjec.Show();

        }

        private void Form_OknoGlowne_VisibleChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Form_OknoGlowne_VisibleChanged");
            _ctx.AutoAutoNaSprzedaz.Load();
            data = _ctx.AutoAutoNaSprzedaz.Local.ToBindingList();
            listBoxListaOfert.DataSource = data;
            listBoxListaOfert.DisplayMember = "TytulOferty";

            //object[] lista = data.Cast<object>().ToArray();
            //listBoxSearch.Items.AddRange(lista);

            listBoxSearch.DataSource = data;
            listBoxSearch.DisplayMember = "TytulOferty";


        }

        private void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*AutoNaSprzedaz zaznaczoneAutoNaSprzedaz = (AutoNaSprzedaz)listBoxListaOfert.SelectedItem;
            labelTytulOferty.Text = zaznaczoneAutoNaSprzedaz.TytulOferty;
            labelCena.Text = "Cena: " + zaznaczoneAutoNaSprzedaz.Cena;
            labelIloscMiejs.Text = "Liczba miejsc: " + zaznaczoneAutoNaSprzedaz.IloscMiejs;
            labelKolorNadwozia.Text = "Kolor: " + zaznaczoneAutoNaSprzedaz.KolorNadwozia.Kolor;
            labelMarka.Text = zaznaczoneAutoNaSprzedaz.Marka.NazwaMarka + " " + zaznaczoneAutoNaSprzedaz.Model.NazwaModel;
            labelMoc.Text = "Moc: " + zaznaczoneAutoNaSprzedaz.Moc + "KM";
            labelPojemnoscSilnika.Text = "Pojemność silnika: " + zaznaczoneAutoNaSprzedaz.PojemnoscSilnika.Pojemnosc.ToString(CultureInfo.InvariantCulture);
            labelPrzebieg.Text = "Przebieg: " + zaznaczoneAutoNaSprzedaz.Przebieg;
            labelRodzajNadwozia.Text = "Nadwozie: " + zaznaczoneAutoNaSprzedaz.RodzajNadwozia.Nadwozie;
            labelRodzajPaliwa.Text = "Rodzaj paliwa: " + zaznaczoneAutoNaSprzedaz.RodzajPaliwa.Paliwo;
            labelRokProdukcji.Text = "Rok produkcji: " + zaznaczoneAutoNaSprzedaz.RokProdukcji.Rok;
            labelTypSkrzyniBiegow.Text = "Skrzynia biegów: " + zaznaczoneAutoNaSprzedaz.TypSkrzyniBiegow;
            richTextBoxOpis.Text = zaznaczoneAutoNaSprzedaz.Opis;
            pictureBox.ImageLocation = zaznaczoneAutoNaSprzedaz.Pic1;*/
        }
        List<string> listcollection = new List<string>();
        private void textBox1Search_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1Search.Text) == false)
            {
                listBoxSearch.Items.Clear();
                foreach (string str in listcollection)
                {
                    if (str.StartsWith(textBox1Search.Text))
                    {
                        listBoxSearch.Items.Add(str);

                    }
                }
            }
            else if (textBox1Search.Text == "")
            {
                listBoxSearch.Items.Clear();
                foreach (string str in listcollection)
                {
                    listBoxSearch.Items.Add(str);
                }
            }
        }
        /* private void textBox1Search_TextChanged(object sender, EventArgs e)
         {
             DataView dvAuta = dtAuta.DefaultView;
             dvAuta.RowFilter = "auto LIKE '%" + textBox1Search.Text + "%'";
         }
        */
        private void button1Search_Click(object sender, EventArgs e)
        {

        }
    }
}
