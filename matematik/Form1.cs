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
            panel1.Visible = true; // Kare hesaplama butonuna týklandýðýnda panelin açýlmasý
            calculationTitle.Text = "Kare Hesaplama Menüsüne Hoþ Geldiniz...."; // Kare hesaplama butonuna týklandýðýnda Baþlýðýn deðiþmesi
            secondEdgeLabel.Visible = false; // Kare hesaplama yaparken ikinci kenar baþlýðýnýn kapatýlmasý
            secondEdgeBox.Visible = false;// Kare hesaplama yaparken ikinci kenar textbox'ýnýn kapatýlmasý

        }
        private void rectangleMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;// dikdörtgen hesap butonuna týklandýðýnda panel1'in görünür hale getirilmesi
            calculationTitle.Text = "Dikdörtgen Hesaplama Menüsüne Hoþ Geldiniz....";// Dikdörtgen hesap butonuna týklanýldýðýnda baþlýk label yazýsýnýn deðiþtirilmesi
            secondEdgeLabel.Visible = true; // Dikdörtgen hesap butonuna týklandýðýnda birinci kenar baþlýðýnýn açýlmasý
            secondEdgeBox.Visible = true; // Dikdörtgen hesap butonuna týklandýðýnda ikinci kenar Textbox kutusunun açýlmasý
        }

        private void circleMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true; // dairesel hesap butonuna týklandýðýnda panel1'in görünür hale getirilmesi
            calculationTitle.Text = "Dairesel Hesaplama Menüsüne Hoþ Geldiniz...."; // Dairesel hesap butonuna týklanýldýðýnda baþlýk label yazýsýnýn deðiþtirilmesi
        }

        private void squareCalculationButton_Click(object sender, EventArgs e)
        {

            #region
            /*
             KARE VE DÝKDÖRTGEN ALANLARININ HESAPLANMASI ÝÇÝN KODLAR
             */

            // KARENÝN BÝR KENARININ UZUNLUÐUNUN DEÐÝÞKEN OLARAK TANIMLANMASI
            //Math Fonksiyonu Kullanacaðým Ýçin double tanýmladým.

            int squareEdgeLength; //KARENÝN BÝR KENARININ DEÐÝÞKEN OLARAK TANIMLANMASI
            int squareArea, squarePerimeter; // KARE ALANI VE ÇEVRESÝ ÝÇÝN DEÐÝÞKENLERÝN TANIMLANMASI

            squareEdgeLength = Convert.ToInt32(firstEdgeBox.Text); //textBox deðerinin integer'a dönüþtürülmesi

            squareArea = squareEdgeLength * squareEdgeLength; // Alanýn Hesaplanmasý
            squarePerimeter = 4 * squareEdgeLength; // Çevrenin Hesaplanmasý

            areaResult.Text = squareArea.ToString(); // Alan Sonucunun Label'a yazdýrýlmasý
            perimeterResult.Text = squarePerimeter.ToString(); // Çevre Sonucunun Label'a Yazdýrýlmasý
            #endregion

            #region
            int firstEdgeLength, secondEdgeLength; // Dikdörtgenin 1. ve 2. Kenarýnýn deðiþken olarak tanýmlanmasý (Kýsa, Uzun)
            int rectangleArea, rectanglePerimeter; // Dikdörtgen alan ve çevresinin deðiþken olarak tanýmlanmasý

            firstEdgeLength = Convert.ToInt32(firstEdgeBox.Text); // Birinci Kenar Textbox deðerinin integer'a dönüþtürülmesi
            secondEdgeLength = Convert.ToInt32(secondEdgeBox.Text); // Ýkinci Kenar Textbox deðerinin integer'a dönüþtürülmesi

            rectangleArea = firstEdgeLength * secondEdgeLength; // Dikdörtgen Alanýnýn Hesaplanmasý
            rectanglePerimeter = 2 * (firstEdgeLength + secondEdgeLength); // Dikdörtgen Çevresinin Hesaplanmasý

            areaResult.Text = rectangleArea.ToString(); // Dikdörtgen alaný hesap sonucunun label'a yazdýrýlmasý
            perimeterResult.Text = rectanglePerimeter.ToString(); // Dikdörtgen çevre hesap sonucunun label'a yazdýrýlmasý
            #endregion






        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false; // Panel1'in uygulama çalýþtýrýlýrken görünürlülüðünün (Visibility) false yani kapalý olmasý.
        }
    }
}