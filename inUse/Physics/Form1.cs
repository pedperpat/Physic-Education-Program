using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace Physics
{
    public partial class MainScreen : Form
    {
        // For use on historical, acceleration, angular acceleration,
        // velocity,concepts,constants, videoReviews,energy,equations,
        // helpscreen, initialVHmax, problemsReview.
        public static string BackBt;
        public static string resultBt;
        // For use on historical only
        public static string HistResetBt;
        // For use on acceleration, velocity, 
        public static string initTime;
        public static string finalTime;
        public static string initV;
        public static string finalV;
        // For use on angular acceleration
        public static string angInitV;
        public static string angFinalV;
        // For use on initVHmax
        public static string lb1InitVHmax;
        public static string lb2InitVHmax;
        public static string lb3InitVHmax;
        public static string lb4InitVHmax;
        public static string lb5InitVHmax;
        public static string totalTime;
        public static string lbFormulaVf;
        public static string getV0Bt;
        public static string solveHMax;
        public static string toAc;
        public static string toInitVH;
        public static string toAngAc;
        public static string toFinalV;
        public static string toKE;

        protected static int openForms = Application.OpenForms.Count;

        protected Equations equations;
        public MainScreen()
        {
            InitializeComponent();
        }

        private void conceptsBt_Click(object sender, EventArgs e)
        {
            Concepts concepts = new Concepts();
            Hide();
            concepts.ShowDialog();
            this.Show();
        }

        private void constantsBt_Click(object sender, EventArgs e)
        {
            Constants cons = new Constants();
            Hide();
            cons.ShowDialog();
            this.Show();
        }

        private void problemsBt_Click(object sender, EventArgs e)
        {
            ProblemsReview problems = new ProblemsReview();
            Hide();
            problems.ShowDialog();
            this.Show();
        }

        private void equationsBt_Click(object sender, EventArgs e)
        {
            Equations eq = new Equations();
            Hide();
            eq.ShowDialog();
            this.Show();
        }

        private void helpBt_Click(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen();
            Hide();
            help.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeLog changelog = new ChangeLog();
            Hide();
            changelog.ShowDialog();
            this.Show();
        }

        private void toVideosBt_Click(object sender, EventArgs e)
        {
            VideoReviewForm video = new VideoReviewForm();
            Hide();
            video.ShowDialog();
            this.Show();
        }

        private void toHistoricalBt_Click(object sender, EventArgs e)
        {
            Historical historial = new Historical();
            Hide();
            historial.ShowDialog();
            this.Show();
        }

        // Method to change the languaje using windows forms resource files stored at Lang directory.
        private void changeLanBt_Click(object sender, EventArgs e)
        {
            ChangeLang();
        }
        public void ChangeLang()
        {
            if (englishLan.Checked == true)
            {
                CultureInfo ci = new CultureInfo("en-US");
                Assembly english = Assembly.Load("Physics");
                ResourceManager rm = new ResourceManager("Physics.Lang.LangEn", english);

                // Change the textbox values to the new texts from the internal resource file.
                titleLb.Text = rm.GetString("title", ci);
                ConceptsLb.Text = rm.GetString("concepts", ci);
                conceptsBt.Text = rm.GetString("goConcepts", ci);
                EquationsLb.Text = rm.GetString("simpleEq", ci);
                equationsBt.Text = rm.GetString("goEquations", ci);
                helpBt.Text = rm.GetString("help", ci);
                helpLb.Text = rm.GetString("goHelp", ci);
                toVideosBt.Text = rm.GetString("goVideoReviews", ci);
                videoReviewLb.Text = rm.GetString("VideoReviews", ci);
                ConstantsLb.Text = rm.GetString("constants", ci);
                constantsBt.Text = rm.GetString("goConstants", ci);
                problemsBt.Text = rm.GetString("goProblems", ci);
                ProblemReviewLb.Text = rm.GetString("reviewProblems", ci);
                VersionLb.Text = rm.GetString("version", ci);
                numberVersionLb.Text = rm.GetString("numVersion", ci);
                button1.Text = rm.GetString("loadChange", ci);
                toHistoricalBt.Text = rm.GetString("showHistorical", ci);
                changeLanBt.Text = rm.GetString("changeLang", ci);
                BackBt = rm.GetString("backBt", ci);
                HistResetBt = rm.GetString("resetBt", ci);
                toAc = rm.GetString("toAc", ci);
                toInitVH = rm.GetString("toInitVH", ci);
                toAngAc = rm.GetString("toAngAc", ci);
                toFinalV = rm.GetString("toFinalV", ci);
                toKE = rm.GetString("toKE", ci);
            }
            else
            {
                CultureInfo ci = new CultureInfo("es-ES");
                Assembly spanish = Assembly.Load("Physics");
                ResourceManager rm = new ResourceManager("Physics.Lang.LangEs", spanish);

                // Change the textbox values to the new texts from the internal resource file.
                titleLb.Text = rm.GetString("titulo", ci);
                ConceptsLb.Text = rm.GetString("conceptos", ci);
                conceptsBt.Text = rm.GetString("irAConceptos", ci);
                EquationsLb.Text = rm.GetString("irAEcuaciones", ci);
                equationsBt.Text = rm.GetString("ecuacionessimples", ci);
                helpBt.Text = rm.GetString("ayuda", ci);
                helpLb.Text = rm.GetString("iraAyuda", ci);
                toVideosBt.Text = rm.GetString("IraVideos", ci);
                videoReviewLb.Text = rm.GetString("videosRepaso", ci);
                ConstantsLb.Text = rm.GetString("ConstantesmasUsadas", ci);
                constantsBt.Text = rm.GetString("irConstantes", ci);
                problemsBt.Text = rm.GetString("problemasRepaso", ci);
                ProblemReviewLb.Text = rm.GetString("problemasRepasoLb", ci);
                VersionLb.Text = rm.GetString("VersionActual", ci);
                numberVersionLb.Text = rm.GetString("numeroVersion", ci);
                button1.Text = rm.GetString("CargaRegistro", ci);
                toHistoricalBt.Text = rm.GetString("MuestraHistorial", ci);
                changeLanBt.Text = rm.GetString("CambiaLenguaje", ci);
                lb1InitVHmax = rm.GetString("lb1InitVHmax", ci);
                lb2InitVHmax = rm.GetString("lb2InitVHmax", ci);
                lb3InitVHmax = rm.GetString("lb3InitVHmax", ci);
                lb4InitVHmax = rm.GetString("lb4InitVHmax", ci);
                lb5InitVHmax = rm.GetString("lb5InitVHmax", ci);
                totalTime = rm.GetString("tTotal", ci);
                lbFormulaVf = rm.GetString("lbEqInitHVmax",ci);
                resultBt = rm.GetString("result", ci);
                getV0Bt = rm.GetString("Vo", ci);
                solveHMax = rm.GetString("SolveHmax", ci);
                toAc = rm.GetString("toAc", ci);
                toInitVH = rm.GetString("toInitVH", ci);
                toAngAc = rm.GetString("toAngAc", ci);
                toFinalV = rm.GetString("toFinalV", ci);
                toKE = rm.GetString("toKE", ci);
                BackBt = rm.GetString("backBt", ci);
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            ChangeLang();
        }

        public static void ExitApp()
        {
            for (int i = 0; i < openForms; i++)
            {
                Application.OpenForms[i].Close();
            }
        }

        // TODO: Show message when app is closed.
        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
