using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1Login_Valentin_Massa
{
    public partial class Form1 : Form
    {
        private const string v = "Adm";
        private int errores;
        private object inicio;

        public Form1()
        {
            InitializeComponent();
        }

        private object btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasenia = txtContrasenia.Text;
            string modulo = cbModulo.Text;
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            string frmInicio inicio = new FrmInicio();
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            switch (usuario)
            {
                case V:
                    if (contrasenia == "adm123" && (modulo == "ADM" || modulo == "COM" || modulo == "VTA")
                     {
                        errores = 0;
                        this.Hide();
                        inicio.ShowDialog();
                    }
                    else
                    {

                        MessageBox.Show("Contraseña y/o módulo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errores++;

                    }
                    break;
                case "Jhon"
                     if (contrasenia == "J125" && modulo == "STST")
                    {
                        errores == 0 &&
                        this.Hide();
                        inicio.ShowDialog();

                    }
                    else
                    { MessageBox.Show("Contraseña y/o modulo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errores++;
                    }
                    break;
                case "Ceci":
                    if (contrasena == "ceci12" && (modulo == "ADM" || modulo == "VTA"))
                    {
                        errores = 0;
                        this.Hide();
                        inicio.Showdialog();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña y/o modulo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errores++;



                        break;
                        {
#pragma warning disable CS0162 // Se detectó código inaccesible
                            MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#pragma warning restore CS0162 // Se detectó código inaccesible
                            errores++;
                        }
                        if (errores == 2)
                        {
                            MessageBox.Show("Demasiados intentos. Se cerrará el formulario.");
                            this.Close();
                        }
            }        }
private void btnCancelar_Click(object sender, EventArgs e)
        {

        }