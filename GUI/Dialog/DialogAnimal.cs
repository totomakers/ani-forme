using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Dialog
{
    public partial class DialogAnimal : Form
    {
        private bool editMode = false;
        private BO.Animaux animalEdited = null;

        /// <summary>
        /// Mode ajout de la fenètre
        /// </summary>
        public DialogAnimal(BO.Clients client = null)
        {
            InitializeComponent();
            CreateMode(client = null);
        }

        /// <summary>
        /// Mode édition de la fenètre pour un animal
        /// </summary>
        /// <param name="animal"></param>
        public DialogAnimal(BO.Animaux animal)
        {
            InitializeComponent();
            EditMode(animal);
        }

        /// <summary>
        /// Permet de passer en mode création
        /// </summary>
        public void CreateMode(BO.Clients client = null)
        {
            animalEdited = null;
            editMode = false;
            if (client != null)
            {
                //@TODO précharger la textbox et la déactivé
                this.comboBoxCustomer.Enabled = false;
            }
        }

        /// <summary>
        /// Permet de passer en mode édition
        /// </summary>
        /// <param name="animal"></param>
        public void EditMode(BO.Animaux animal)
        {
            editMode = true;
            animalEdited = animal;
        }



       
    }
}
