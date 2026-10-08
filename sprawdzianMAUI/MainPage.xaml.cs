namespace sprawdzianMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void SitoSprawdzanie() {
            for (int i = 2; i * i <= LiczbaDo; i++)
            {
                if (czyPierwsza[i] == true)
                {
                    for (int j = i * i; j <= i; j += i)
                    {
                        czyPierwsza[j] = false;
                    }
                }
            }
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            bool CzyLiczbaOd = int.TryParse(OdEntry.Text, out int LiczbaOd);
            bool CzyLiczbaDo = int.TryParse(DoEntry.Text, out int LiczbaDo);

            if (CzyLiczbaOd && CzyLiczbaDo)
            {
                if (LiczbaOd >= 2 && LiczbaOd <= 10000 && LiczbaDo >= 2 && LiczbaDo <= 10000 && LiczbaOd <= LiczbaDo)
                {
                    bool[] czyPierwsza = new bool[LiczbaDo + 1];

                    SitoSprawdzanie();

                    if (czyPierwsza.Length > 0)
                    {
                        wyniki.Text = "Wynik\n" +
                                      $"Liczby pierwsze: {czyPierwsza} \n" +
                                      "Liczby: " + czyPierwsza.Length;
                    }
                    else
                    {
                        wyniki.Text = "Wynik\n" +
                                      "Liczby pierwsze: brak \n" +
                                      "Liczby: 0";
                    }
                }
                else
                {
                    wyniki.Text = "Błędne dane";
                }
            }
            else
            {
                wyniki.Text = "Błędne dane";
            }
        }
    }
}
