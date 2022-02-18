using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafío1_Ejercicio1
{
    public partial class Form1 : Form
    {
        //creamos la cola
        Queue<Label> micola = new Queue<Label>();
        //posiciones iniciales
        int x = 0;
        int y = 50;
       
        public Form1()
        {
            InitializeComponent();
        }
       
        //programamos botón salir
        private void btnsalir_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
       //programamos el botón encolar
        private void btnencolar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(nupvalor.Value);    //guardamos el valor del numerical
            Label milabel = new Label();                    //creación y personalización del lab
            milabel.Text = valor.ToString();
            milabel.BackColor = Color.Aqua;
            milabel.Height = 50;
            milabel.Width = 50;
            milabel.TextAlign = ContentAlignment.MiddleCenter;
            milabel.BorderStyle = BorderStyle.FixedSingle;
            milabel.Location = new Point(x, y);
            micola.Enqueue(milabel);                        //encolamos 
            panel1.Controls.Add(milabel);                   //mostramos en panel
            x += milabel.Width;                             //actualizamos posición
           // timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
               
                Label mover1 = micola.Peek();
                mover1.BackColor = Color.White;
                if (mover1.Location.X < x)
                {
                    mover1.Location = new Point(mover1.Location.X + 5, mover1.Location.Y);
                    return;

                }
                if (mover1.Location.Y < y)
                {
                    mover1.Location = new Point(mover1.Location.X, mover1.Location.Y + 5);
                    return;
                }
                x += mover1.Width;
                mover1.BackColor = Color.Aqua;
                timer1.Stop();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la ejecución: " + error);
            }

        }
        //programamos el botón desencolar
        private void btndesencolar_Click(object sender, EventArgs e)
        {
            //verificamos que la cola no esté vacía
            if (micola.Count==0)
            {
                MessageBox.Show("Cola vacía, no hay nada que eliminar");
                return;
            }
            timer2.Start();
          
            

        }
        //validación de datos en el numerical
        private void nupvalor_ValueChanged(object sender, EventArgs e)
        {
            
            if(nupvalor.Value<0 || nupvalor.Value > 99)
            {
                MessageBox.Show("El rango de datos permitidos es de 0 a 99");
                return;
            }
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                
                Label mover2 = micola.Peek();
                mover2.BackColor = Color.White;
                if (mover2.Location.X > 0)
                {
                    mover2.Location = new Point(mover2.Location.X - 5, mover2.Location.Y);
                    return;
                }
                if (mover2.Location.Y > 0)
                {
                    mover2.Location = new Point(mover2.Location.X, mover2.Location.Y-5);
                    return;
                }
                micola.Dequeue();
                panel1.Controls.Remove(mover2);
                mover2.BackColor = Color.Aqua;
                x -= mover2.Width;
                timer2.Stop();
            }
            catch(Exception error)
            {
                MessageBox.Show("Error en la ejecución: " + error);
            }
        }
    }
}
