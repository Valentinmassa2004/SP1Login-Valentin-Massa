using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1Login_Valentin_Massa
{
    public partial class frmLogin: Form
    {
        int varintentos;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Adm" && txtContraseña.Text == "@1Am")
            {
                if (cboMódulo.Text == "ADM" || cboMódulo.Text == "COM" || cboMódulo.Text == "VTA")
                {
                    this.Hide();
                    FrmInicio Bienvenida = new FrmInicio();
                    Bienvenida.ShowDialog();
                    varintentos = 0;
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                    varintentos++;
                }
            } 
            else
            {
                if ((txtUsuario.Text == "John") && (txtContraseña.Text == "*2b"))
                {
                    if (cboMódulo.Text == "SIST")
                    {
                        this.Hide();
                        FrmInicio Bienvenida = new FrmInicio();
                        Bienvenida.ShowDialog();
                        varintentos = 0;
                    }

                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                        varintentos++;
                    }
                }
                else
                {
                    if (txtUsuario.Text == "Ceci" && txtContraseña.Text == "*@3c")
                    {
                        if (cboMódulo.Text == "ADM" || cboMódulo.Text == "VTA")
                        {
                            this.Hide();
                            FrmInicio Bienvenida = new FrmInicio();
                            Bienvenida.ShowDialog();
                            varintentos = 0;
                        }
                        else
                        {
                            MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                            varintentos++;
                        }
                    }

                    else
                    {
                        if ((txtUsuario.Text == "Goro") && (txtContraseña.Text == "*4d"))
                        {
                            if (cboMódulo.Text == "ADM" || cboMódulo.Text == "SIST" || cboMódulo.Text == "COM" || cboMódulo.Text == "VTA")
                            {
                                this.Hide();
                                FrmInicio Bienvenida = new FrmInicio();
                                Bienvenida.ShowDialog();
                                varintentos = 0;
                            }
                            else
                            {
                                MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                                varintentos++;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Los datos ingresados son incorrectos");
                            varintentos++;
                        }
                    }

                }
            }

            if (varintentos == 3)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
