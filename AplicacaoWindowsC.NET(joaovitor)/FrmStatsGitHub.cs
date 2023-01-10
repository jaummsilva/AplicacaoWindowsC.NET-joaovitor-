using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace AplicacaoWindowsC.NET_joaovitor_
{
    public partial class FrmStatsGitHub : Form
    {
        public FrmStatsGitHub()
        {
            InitializeComponent();
        }
        private void FrmStatsGitHub_Load(object sender, System.EventArgs e)
        {

            dataGridViewStats.DataSource = GitHubStatsProjects.ListGitHub();
        }

        
    }
    public class GitHubStatsProjects
    {

        public int Id { get; set; }
        public string name { get; set; }
        public string language { get; set; }
        public string description { get; set; }


        public static List<GitHubStatsProjects> ListGitHub()
        {
            var listGitHub = new List<GitHubStatsProjects>();
            var l1 = new GitHubStatsProjects
            {
                Id = 1,
                name = "Backend-SulTurismo",
                language = "Python",
                description = "Backend em Python com VueJs"
            };
            listGitHub.Add(l1);

            l1 = new GitHubStatsProjects
            {
                Id = 2,
                name = "Frontend-SulTurismo",
                language = "VueJS",
                description = "Frontend com Vue js"
            };
            listGitHub.Add(l1);

            l1 = new GitHubStatsProjects
            {
                Id = 3,
                name = "Backend-Livraria",
                language = "JavaScript,Python",
                description = "Backend com Django usando Python"
            };
            listGitHub.Add(l1);

            l1 = new GitHubStatsProjects
            {
                Id = 4,
                name = "RefeitorioFrontend",
                language = "VueJS",
                description = "Frontend com Vue js"
            };
            listGitHub.Add(l1);

            l1 = new GitHubStatsProjects
            {
                Id = 5,
                name = "Calculator",
                language = "HTML",
                description = "Frontend de uma calculadora simples com Html"
            };
            listGitHub.Add(l1);

            l1 = new GitHubStatsProjects
            {
                Id = 6,
                name = "LivrariaNovo",
                language = "JavaScript,Python",
                description = "Backend novo da livraria com Django usando Python"
            };
            listGitHub.Add(l1);

            l1 = new GitHubStatsProjects
            {
                Id = 7,
                name = "ProjectJavaReact",
                language = "Java,ReactJS",
                description = "Mini Projeto com Java de backend e ReactJS de frontend"
            };
            listGitHub.Add(l1);

            l1 = new GitHubStatsProjects
            {
                Id = 8,
                name = "Backend-PJGPlantas",
                language = "JavaScript,Python",
                description = "Backend TCC, usando Django"
            };
            listGitHub.Add(l1);

            l1 = new GitHubStatsProjects
            {
                Id = 9,
                name = "Frontend-PJGPlantas",
                language = "VueJS",
                description = "Frontend TCC, usando VueJs"
            };
            listGitHub.Add(l1);

            l1 = new GitHubStatsProjects
            {
                Id = 10,
                name = "Curso-.Net",
                language = "C#",
                description = "Curso em andamento com C#"
            };
            listGitHub.Add(l1);

            l1 = new GitHubStatsProjects
            {
                Id = 11,
                name = "AplicacaoWindows-C.Net",
                language = "C#",
                description = "Aplicação Windows no curso em andamento com C#"
            };
            listGitHub.Add(l1);

            return listGitHub;
        }

        }
}
