using Clases.Pilas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Implementacion;
using Clases;

namespace GUI
{
    public partial class Form1 : Form
    {
        Pila<Libro> biblioteca = new Pila<Libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            string genero = txtGenero.Text;
            int año = int.Parse(txtAño.Text);
            Libro libroApilado = new Libro(titulo,autor,año,genero);
            biblioteca.Apilar(libroApilado);

            // Llamar a un método para mostrar la pila en el DataGridView.
            MostrarPilaEnDataGridView();

            // Limpiar los TextBox para la siguiente entrada (opcional, pero recomendable).
            txtTitulo.Clear();
            txtAutor.Clear();
            txtGenero.Clear();
            txtAño.Clear();
        }
        private void MostrarPilaEnDataGridView()
        {
            // Limpia las filas actuales del DataGridView para evitar duplicados.
            dgvBiblioteca.Rows.Clear();

            // Recorre la pila. Una forma de hacerlo es copiarla a una lista o un array
            // para poder iterar sobre ella sin desapilar los elementos.
            foreach (var libro in biblioteca)
            {
                // Agrega una nueva fila al DataGridView con los datos del libro.
                dgvBiblioteca.Rows.Add(libro.Titulo, libro.Autor, libro.Genero, libro.Ano);
            }
        }
        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            if (!biblioteca.EstaVacia())
            {
                Libro libroDesapilado = biblioteca.Desapilar();
                MessageBox.Show($"Se ha desapilado el libro: {libroDesapilado.Titulo}", "Libro Desapilado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarPilaEnDataGridView();
            }
            else
            {
                MessageBox.Show("La pila de libros está vacía.", "Pila Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvBiblioteca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Columnas: clTitulo clAutor clGenero clAño
        }
    }
}
