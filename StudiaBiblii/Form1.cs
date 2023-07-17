using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace StudiaBiblii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("lista_ksiag.txt");

            while (!sr.EndOfStream)
                ListaKsiąg.Items.Add(sr.ReadLine());

            for (int i = 1; i <= 50; i++)
                ListaRozdziałów.Items.Add(i);

            for (int i = 1; i <= 31; i++)
                ListaWersetów.Items.Add(i);

            sr.Close();

            ListaKsiąg.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaKsiąg.SelectedIndex = 0;

            ListaRozdziałów.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaRozdziałów.SelectedIndex = 0;

            ListaWersetów.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaWersetów.SelectedIndex = 0;
        }

        private void ListaKsiąg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string linia = PodajNazwęKsięgi(); //zmienna linia przechowuje nazwę księgi, której liczbę rozdziałów szukamy

            string filtr = linia + "*.txt";

            string[] pliki_filtrowane = Directory.GetFiles(".\\tekst", filtr);

            ListaRozdziałów.Items.Clear();

            for (int i = 1; i <= pliki_filtrowane.Length; i++)
                ListaRozdziałów.Items.Add(i);

            ListaRozdziałów.SelectedIndex = 0;
            AktualizacjaWersetów();
        }

        public string PodajNazwęKsięgi()
        {
            StreamReader sr = new StreamReader("lista_ksiag_tech.txt");

            string linia;
            int i = -1;

            do
            {
                i++;
                linia = sr.ReadLine();
            }
            while (i != ListaKsiąg.SelectedIndex);

            sr.Close();

            return linia;
        }

        public void AktualizacjaWersetów()
        {
            string księga = PodajNazwęKsięgi();

            int rozdział = ListaRozdziałów.SelectedIndex + 1;
            string rozdział_string = WersetIntNaString(rozdział);

            string plik = księga + " " + rozdział_string + ".txt";

            StreamReader sr = new StreamReader(".\\tekst\\" + plik);

            //liczenie linii
            int ile_linii = 0;

            ListaWersetów.Items.Clear();

            while (!sr.EndOfStream)
            {
                ile_linii++;
                ListaWersetów.Items.Add(ile_linii);
                sr.ReadLine();
            }

            ListaWersetów.SelectedIndex = 0;
        }

        private void ListaRozdziałów_SelectedIndexChanged(object sender, EventArgs e)
        {
            AktualizacjaWersetów();
        }

        private void Pokaż_Click(object sender, EventArgs e)
        {
            string plik = ".\\tekst\\" + PodajNazwęKsięgi() + " " + WersetIntNaString(ListaRozdziałów.SelectedIndex + 1) + ".txt";
            string szukany_werset = "";

            StreamReader sr = new StreamReader(plik);

            int i = -1;
            do
            {
                i++;
                szukany_werset = sr.ReadLine();
            }
            while (i != ListaWersetów.SelectedIndex);

            sr.Close();

            MessageBox.Show(szukany_werset);
        }

        public string WersetIntNaString(int numer)
        {
            string wynik;

            if (numer < 10)
                wynik = "00" + numer.ToString();
            else if (numer < 100)
                wynik = "0" + numer.ToString();
            else
                wynik = numer.ToString();

            return wynik;
        }

        private void Losowy_Click(object sender, EventArgs e)
        {
            Random los = new Random();
            int który;

            //losowanie księgi
            który = los.Next(ListaKsiąg.Items.Count);
            ListaKsiąg.SelectedIndex = który;

            //losowanie rozdziału
            który = los.Next(ListaRozdziałów.Items.Count);
            ListaRozdziałów.SelectedIndex = który;

            //losowanie wersetu
            który = los.Next(ListaWersetów.Items.Count);
            ListaWersetów.SelectedIndex = który;

            //pokaż
            Pokaż_Click(null, null);
        }
    }
}
