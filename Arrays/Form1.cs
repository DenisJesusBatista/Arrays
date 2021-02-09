using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTesteVetor_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4];
            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;
            int valor = vetor[1];
            Array.Sort(vetor);

            for (int index=0; index<4; index++)
            {
                MessageBox.Show(vetor [index].ToString(), "Array");
            }

            /*Declarar e instanciar o vetor
             * Atribuição de valores de acordo com cada índice
             * Declara variável "valor" para acessar o vetor
             * Array.Sort - Está classe ordena o vetor
             * Comando for - Percorre o vetor em cada índice.
             * Codição - Para index menor que 4 ( de 0 a 3 ), ela exibe uma msg para o vetor na MessagemBox.
             * */
        }

        private void btnVetorTexto_Click(object sender, EventArgs e)
        {
            string[] semana = new string[7];
            semana[0] = "Domingo";
            semana[1] = "Segunda-Feira";
            semana[2] = "Terça-Feira";
            semana[3] = "Quarta-Feira";
            semana[4] = "Quinta-Feira";
            semana[5] = "Sexta-Feira";
            semana[6] = "Sabado";

            string valor = semana[1];

            for (int index = 0; index < 7; index++)
            {
                MessageBox.Show(semana[index].ToString(), "Array");

            }
            /*Declarar e instanciar o vetor
            * Atribuição de valores de acordo com cada índice
            * Aqui no caso são os dias da semana ( string )
             * Declara variável "valor" para acessar o vetor
            * Por ser se tratar de string não será necessário ordenar.             * 
            * Comando for - Percorre o vetor em cada índice.
            * Codição - Para index menor que 7 ( de 0 a 6 ), ela exibe uma msg para o vetor na MessagemBox, ou seja cada dia da semana.
            * */
        }
    }
}
