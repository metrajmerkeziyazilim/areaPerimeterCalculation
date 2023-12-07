namespace matematik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true; // Kare hesaplama butonuna t�kland���nda panelin a��lmas�
            calculationTitle.Text = "Kare Hesaplama Men�s�ne Ho� Geldiniz...."; // Kare hesaplama butonuna t�kland���nda Ba�l���n de�i�mesi
            secondEdgeLabel.Visible = false; // Kare hesaplama yaparken ikinci kenar ba�l���n�n kapat�lmas�
            secondEdgeBox.Visible = false;// Kare hesaplama yaparken ikinci kenar textbox'�n�n kapat�lmas�

        }
        private void rectangleMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;// dikd�rtgen hesap butonuna t�kland���nda panel1'in g�r�n�r hale getirilmesi
            calculationTitle.Text = "Dikd�rtgen Hesaplama Men�s�ne Ho� Geldiniz....";// Dikd�rtgen hesap butonuna t�klan�ld���nda ba�l�k label yaz�s�n�n de�i�tirilmesi
            secondEdgeLabel.Visible = true; // Dikd�rtgen hesap butonuna t�kland���nda birinci kenar ba�l���n�n a��lmas�
            secondEdgeBox.Visible = true; // Dikd�rtgen hesap butonuna t�kland���nda ikinci kenar Textbox kutusunun a��lmas�
        }

        private void circleMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true; // dairesel hesap butonuna t�kland���nda panel1'in g�r�n�r hale getirilmesi
            calculationTitle.Text = "Dairesel Hesaplama Men�s�ne Ho� Geldiniz...."; // Dairesel hesap butonuna t�klan�ld���nda ba�l�k label yaz�s�n�n de�i�tirilmesi
        }

        private void squareCalculationButton_Click(object sender, EventArgs e)
        {

            #region
            /*
             KARE VE D�KD�RTGEN ALANLARININ HESAPLANMASI ���N KODLAR
             */

            // KAREN�N B�R KENARININ UZUNLU�UNUN DE���KEN OLARAK TANIMLANMASI
            //Math Fonksiyonu Kullanaca��m ��in double tan�mlad�m.

            int squareEdgeLength; //KAREN�N B�R KENARININ DE���KEN OLARAK TANIMLANMASI
            int squareArea, squarePerimeter; // KARE ALANI VE �EVRES� ���N DE���KENLER�N TANIMLANMASI

            squareEdgeLength = Convert.ToInt32(firstEdgeBox.Text); //textBox de�erinin integer'a d�n��t�r�lmesi

            squareArea = squareEdgeLength * squareEdgeLength; // Alan�n Hesaplanmas�
            squarePerimeter = 4 * squareEdgeLength; // �evrenin Hesaplanmas�

            areaResult.Text = squareArea.ToString(); // Alan Sonucunun Label'a yazd�r�lmas�
            perimeterResult.Text = squarePerimeter.ToString(); // �evre Sonucunun Label'a Yazd�r�lmas�
            #endregion

            #region
            int firstEdgeLength, secondEdgeLength; // Dikd�rtgenin 1. ve 2. Kenar�n�n de�i�ken olarak tan�mlanmas� (K�sa, Uzun)
            int rectangleArea, rectanglePerimeter; // Dikd�rtgen alan ve �evresinin de�i�ken olarak tan�mlanmas�

            firstEdgeLength = Convert.ToInt32(firstEdgeBox.Text); // Birinci Kenar Textbox de�erinin integer'a d�n��t�r�lmesi
            secondEdgeLength = Convert.ToInt32(secondEdgeBox.Text); // �kinci Kenar Textbox de�erinin integer'a d�n��t�r�lmesi

            rectangleArea = firstEdgeLength * secondEdgeLength; // Dikd�rtgen Alan�n�n Hesaplanmas�
            rectanglePerimeter = 2 * (firstEdgeLength + secondEdgeLength); // Dikd�rtgen �evresinin Hesaplanmas�

            areaResult.Text = rectangleArea.ToString(); // Dikd�rtgen alan� hesap sonucunun label'a yazd�r�lmas�
            perimeterResult.Text = rectanglePerimeter.ToString(); // Dikd�rtgen �evre hesap sonucunun label'a yazd�r�lmas�
            #endregion






        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false; // Panel1'in uygulama �al��t�r�l�rken g�r�n�rl�l���n�n (Visibility) false yani kapal� olmas�.
        }
    }
}