namespace travailFinal_Intro_progra
{
    public partial class Form1 : Form
    {


        Image cacheeImage;
        Image drapeauImage;
        Image mineImage;
        Image mineExploseeImage;
        Image videImage;
        Image[] imagesChiffres = new Image[9];

        PictureBox[,] tableauCasesCahee = new PictureBox[10, 10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlacerPictureBoxDansTableau();

        }

        enum EtatCase
        {
            Cachee,
            Revelee,
            Drapeau
        }
        const int  nombreLignes = 10;
        const int nombreColonnes = 10;

        private Random random = new Random();
        EtatCase[,] etats = new EtatCase[nombreLignes, nombreColonnes];

        // Tableau 2D qui indique si chaque case contient une mine.
        bool[,] mines = new bool[nombreLignes, nombreColonnes];



        private void PlacerPictureBoxDansTableau()
        {
            tableauCasesCahee[0, 0] = pictureBox00;
            tableauCasesCahee[0, 1] = pictureBox01;
            tableauCasesCahee[0, 2] = pictureBox02;
            tableauCasesCahee[0, 3] = pictureBox03;
            tableauCasesCahee[0, 4] = pictureBox04;
            tableauCasesCahee[0, 5] = pictureBox05;
            tableauCasesCahee[0, 6] = pictureBox06;
            tableauCasesCahee[0, 7] = pictureBox07;
            tableauCasesCahee[0, 8] = pictureBox08;
            tableauCasesCahee[0, 9] = pictureBox09;

            tableauCasesCahee[1, 0] = pictureBox10;
            tableauCasesCahee[1, 1] = pictureBox11;
            tableauCasesCahee[1, 2] = pictureBox12;
            tableauCasesCahee[1, 3] = pictureBox13;
            tableauCasesCahee[1, 4] = pictureBox14;
            tableauCasesCahee[1, 5] = pictureBox15;
            tableauCasesCahee[1, 6] = pictureBox16;
            tableauCasesCahee[1, 7] = pictureBox17;
            tableauCasesCahee[1, 8] = pictureBox18;
            tableauCasesCahee[1, 9] = pictureBox19;

            tableauCasesCahee[2, 0] = pictureBox20;
            tableauCasesCahee[2, 1] = pictureBox21;
            tableauCasesCahee[2, 2] = pictureBox22;
            tableauCasesCahee[2, 3] = pictureBox23;
            tableauCasesCahee[2, 4] = pictureBox24;
            tableauCasesCahee[2, 5] = pictureBox25;
            tableauCasesCahee[2, 6] = pictureBox26;
            tableauCasesCahee[2, 7] = pictureBox27;
            tableauCasesCahee[2, 8] = pictureBox28;
            tableauCasesCahee[2, 9] = pictureBox29;

            tableauCasesCahee[3, 0] = pictureBox30;
            tableauCasesCahee[3, 1] = pictureBox31;
            tableauCasesCahee[3, 2] = pictureBox32;
            tableauCasesCahee[3, 3] = pictureBox33;
            tableauCasesCahee[3, 4] = pictureBox34;
            tableauCasesCahee[3, 5] = pictureBox35;
            tableauCasesCahee[3, 6] = pictureBox36;
            tableauCasesCahee[3, 7] = pictureBox37;
            tableauCasesCahee[3, 8] = pictureBox38;
            tableauCasesCahee[3, 9] = pictureBox39;

            tableauCasesCahee[4, 0] = pictureBox40;
            tableauCasesCahee[4, 1] = pictureBox41;
            tableauCasesCahee[4, 2] = pictureBox42;
            tableauCasesCahee[4, 3] = pictureBox43;
            tableauCasesCahee[4, 4] = pictureBox44;
            tableauCasesCahee[4, 5] = pictureBox45;
            tableauCasesCahee[4, 6] = pictureBox46;
            tableauCasesCahee[4, 7] = pictureBox47;
            tableauCasesCahee[4, 8] = pictureBox48;
            tableauCasesCahee[4, 9] = pictureBox49;

            tableauCasesCahee[5, 0] = pictureBox50;
            tableauCasesCahee[5, 1] = pictureBox51;
            tableauCasesCahee[5, 2] = pictureBox52;
            tableauCasesCahee[5, 3] = pictureBox53;
            tableauCasesCahee[5, 4] = pictureBox54;
            tableauCasesCahee[5, 5] = pictureBox55;
            tableauCasesCahee[5, 6] = pictureBox56;
            tableauCasesCahee[5, 7] = pictureBox57;
            tableauCasesCahee[5, 8] = pictureBox58;
            tableauCasesCahee[5, 9] = pictureBox59;

            tableauCasesCahee[6, 0] = pictureBox60;
            tableauCasesCahee[6, 1] = pictureBox61;
            tableauCasesCahee[6, 2] = pictureBox62;
            tableauCasesCahee[6, 3] = pictureBox63;
            tableauCasesCahee[6, 4] = pictureBox64;
            tableauCasesCahee[6, 5] = pictureBox65;
            tableauCasesCahee[6, 6] = pictureBox66;
            tableauCasesCahee[6, 7] = pictureBox67;
            tableauCasesCahee[6, 8] = pictureBox68;
            tableauCasesCahee[6, 9] = pictureBox69;

            tableauCasesCahee[7, 0] = pictureBox70;
            tableauCasesCahee[7, 1] = pictureBox71;
            tableauCasesCahee[7, 2] = pictureBox72;
            tableauCasesCahee[7, 3] = pictureBox73;
            tableauCasesCahee[7, 4] = pictureBox74;
            tableauCasesCahee[7, 5] = pictureBox75;
            tableauCasesCahee[7, 6] = pictureBox76;
            tableauCasesCahee[7, 7] = pictureBox77;
            tableauCasesCahee[7, 8] = pictureBox78;
            tableauCasesCahee[7, 9] = pictureBox79;

            tableauCasesCahee[8, 0] = pictureBox80;
            tableauCasesCahee[8, 1] = pictureBox81;
            tableauCasesCahee[8, 2] = pictureBox82;
            tableauCasesCahee[8, 3] = pictureBox83;
            tableauCasesCahee[8, 4] = pictureBox84;
            tableauCasesCahee[8, 5] = pictureBox85;
            tableauCasesCahee[8, 6] = pictureBox86;
            tableauCasesCahee[8, 7] = pictureBox87;
            tableauCasesCahee[8, 8] = pictureBox88;
            tableauCasesCahee[8, 9] = pictureBox89;

            tableauCasesCahee[9, 0] = pictureBox90;
            tableauCasesCahee[9, 1] = pictureBox91;
            tableauCasesCahee[9, 2] = pictureBox92;
            tableauCasesCahee[9, 3] = pictureBox93;
            tableauCasesCahee[9, 4] = pictureBox94;
            tableauCasesCahee[9, 5] = pictureBox95;
            tableauCasesCahee[9, 6] = pictureBox96;
            tableauCasesCahee[9, 7] = pictureBox97;
            tableauCasesCahee[9, 8] = pictureBox98;
            tableauCasesCahee[9, 9] = pictureBox99;



        }

        private void ChargerLesImages()
        {
            cacheeImage = Image.FromFile("cachee.png");
            drapeauImage = Image.FromFile("drapeau.png");
            mineImage = Image.FromFile("mine.png");
            mineExploseeImage = Image.FromFile("mine_explosee.png");
            videImage = Image.FromFile("vide.png");

            // Le 0 est représenté par vide.png.
            // On charge donc les images de 1 à 8.
            for (int nombre = 1; nombre <= 8; nombre++)
            {
                imagesChiffres[nombre] = Image.FromFile($"{nombre}.png");

            }
        }

        private void initialiserGrille()
        { 
            for (int ligne = 0; ligne < nombreLignes; ligne++)
            {
                for (int colonne = 0; colonne < nombreColonnes; colonne++)
                {
                    etats[ligne, colonne] = EtatCase.Cachee;
                    mines[ligne, colonne] = false;
                }
            }

            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int ligne = 0; ligne < 10; ligne++)
            {
                for (int colonne = 0; colonne < 10; colonne++)
                {
                    tableauCasesCahee[ligne, colonne].Enabled = false;
                }
            }
            Close();
        }
    }
}
