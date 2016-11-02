using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalsRepo
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();

            _lblDevelpoerName = new MyLabel(this)
            {
                Location = new Point(100, 100),
                ForeColor = Color.Red,
                Width = 200,

#warning Ejemplo warning: Para realizar el calculo correctamente no se puede asignar este campo como no númerico.
                Text = "234"
            };



            int a;
            if (int.TryParse(_lblDevelpoerName.Text, out a) && a != 0)
            {
#if DEBUG
                MessageBox.Show("Estoy en depuración.");
#endif
               
                Squared(ref a);

                CreateArrayAndReverseIt();

            }
            else
            {
                MessageBox.Show("'a' no dividible.");
            }




            var result = a;

        }

        #region Methods


        /// <summary>
        /// Refactoring example. See: <see cref="MainForm"/>.
        /// </summary>
        void CreateArrayAndReverseIt()
        {
            int[] array = new int[] { 2, 3, 4, 5, 6, 7, 8 };
            Array.Reverse(array);
        }

        void Squared(ref int a)
        {
            a = a * a;
        }

        void Division(int a)
        {
            double b = 123 / a;
            MessageBox.Show(b.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {            
            MessageBox.Show(_tbxPassword.Text, "Texto actual");
        }


        #endregion

        #region Fields

        private Label _lblDevelpoerName;

#if DEBUG
        int r, t, y, f, d, s, a;
#endif

        #endregion

        #region Obsolete class example.

        [Obsolete("Don't use it! It only for example purposes class. Use MyNewLabel instead.")]
        public class MyLabel : Label
        {
            public MyLabel(Form parent)
            {
                parent.Controls.Add(this);

                // No ovlivar implementar el cuerpo!!!
                // throw new NotImplementedException();
            }
        }

        public class MyNewLabel : MyLabel
        {
            public MyNewLabel(Form parent) : base(parent)
            {
            }
        }

        #endregion
    }
}
