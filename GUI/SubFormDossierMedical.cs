using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using BLL;

namespace GUI
{
    public partial class SubFormDossierMedical : Form
    {
        /// <summary>
        /// Construction d'un dossier médical avec navigation
        /// </summary>
        public SubFormDossierMedical()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construction d'un dossier médical avec un animal en param
        /// Déactive la recherche
        /// </summary>
        /// <param name="animal"></param>
        public SubFormDossierMedical(BO.Animaux animal)
        {
            InitializeComponent();
        }
    }
}
