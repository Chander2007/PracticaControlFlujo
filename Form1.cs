using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicio2Prueba.models;

namespace ejercicio2Prueba
{
    public partial class Form1 : Form
    {
        private GeneralRegister names = new GeneralRegister();
        private int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddElement() //Recopila los datos
        {
            try
            {
                string name = tbFullName.Text;        
                DateTime fechaNac = dateTimePicker1.Value; //Guarda la fecha ingreasada por el usuario

                names.AddName(name, index);
                names.AddAge(fechaNac, index);
                index++;

                ShowDetails();

                tbFullName.Clear();
                dateTimePicker1.Value = DateTime.Now; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowDetails() //Muestra los datos
        {
            try
            {
                lbRegister.Items.Clear();
                for (int i = 0; i < index; i++)
                {
                    string name = names.GetName(i);
                    string age = names.GetAge(i);
                    lbRegister.Items.Add($"Name: {name}, Age: {age}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbFullName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void btnAdd_Click(object sender, EventArgs e) //Colocamos la función para que el botón pueda realizar su tarea
        {
            AddElement();
        }

        private void lbRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}