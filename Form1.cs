using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AC_1
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seleção da funcao
            switch (cboFuncao.SelectedIndex)
            {
                case 0:
                    nudB.Minimum = -100000;
                    nudC.Enabled = false;
                    break;
                case 1:
                    nudB.Value = 1;
                    nudB.Minimum = 0;
                    nudC.Enabled = false;
                    break;
                case 2:
                    nudB.Minimum = -100000;
                    nudC.Enabled = true; 
                    break;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nudX_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            string funcaoescolhida = cboFuncao.Text;
            decimal decimalx = nudX.Value;
            decimal decimala = nudA.Value;
            decimal decimalb = nudB.Value;
            decimal decimalc = nudC.Value;
            float x = (float)decimalx, a = (float)decimala, b = (float)decimalb, c = (float)decimalc;
            float y=0,expoY=1,QuadX=1;


            //Numeros necessários para o cálculo das funcaes
            
            double dexpoY = (double)expoY;

            for (int i = 0; i < 2; i++)//Para Y com X elevado por 2
            {
                QuadX *= x;
            }


            switch (cboFuncao.SelectedIndex)
            {
                case 0:
                    nudB.Minimum = -10000;
                    y = a * x + b;
                    break;
                case 1:
                    
                    dexpoY = Math.Pow(b, x)*a;
                    break;
                case 2:
                    nudB.Minimum = -10000;
                    y = a*QuadX+(b*x)+c ;
                    break;
            }
            //em cada caso para calcular o x
            if (funcaoescolhida == "Função Afim") lblcoords.Text = (funcaoescolhida + "\nF(x) = " + a + "*X" + b + "\n X = " + x.ToString() + "\n Y = " + y.ToString("f2"));
            else if (funcaoescolhida == "Função Exponencial") lblcoords.Text = (funcaoescolhida + "\nF(X) = " + a + "*" + b + "^X\n X = " + x.ToString() + "\n Y = " + dexpoY.ToString("f2"));
            else if (funcaoescolhida == "Função Quadrática") lblcoords.Text = (funcaoescolhida + "\nF(X) = " + a + "*X^2 + " + b + "*X + " + c + "\n X = " + x.ToString() + "\n Y = " + y.ToString("f2"));
            else lblcoords.Text = ("Funcao nao escolhida");
            

        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            lblGrafico.Text = String.Empty;

            string funcaoescolhida = cboFuncao.Text;
            decimal decimalx = nudX.Value, decimala = nudA.Value, decimalb = nudB.Value, decimalc = nudC.Value;
            float x = (float)decimalx, a = (float)decimala, b = (float)decimalb, c = (float)decimalc;
            float expoY = 1, QuadX = 1;


            //Numeros necessários para o cálculo das funções
            double dx = (double)x, db = (double)b;
            double dexpoY = (double)expoY;

            for (int i = 0; i < 2; i++)//x ao quadrado
            {
                QuadX *= x;
            }



            if (funcaoescolhida == "Função Afim")//para ver a função escolhida
            {
                for (int i = 1; i < 12; i++)
                {
                    lblGrafico.Text += "\nX = " + (i - 1) + " |  Y = " + (a * (i-1) + b).ToString("f2");
                }
            }
            else if (funcaoescolhida == "Função Exponencial")
            {
                for (int i = 1; i < 12; i++)
                {
                    lblGrafico.Text += "\nX = " + (i-1) + " |  Y = " + (Math.Pow(b, (i - 1)) * a).ToString("f2");
                }
            }
            else if (funcaoescolhida == "Função Quadrática")
            {
                for (int i = 1; i < 12; i++)
                {
                    lblGrafico.Text += "\nX = " + (i - 1) + " |  Y = " + (a * (i - 1)*(i - 1) + (b * (i - 1)) + c).ToString("f2");
                }
            }
            else lblGrafico.Text = ("Funcao nao escolhida");


            
            //-----------------------------------------------------------------------------------------------------
            
            Bitmap graficofeito = new Bitmap(720,720);
            Graphics grafico = Graphics.FromImage(graficofeito); //classe desenha
            Brush pintar = Brushes.BlueViolet, pintar1 = Brushes.Red, pintar2 = Brushes.Red;


            int centrox = pictureBox1.Width/2, centroy = pictureBox1.Height/2;
            
            float pixel = 40;//quanto cada unidade de conta x da função vai valer na prática
            float centroy1 = 0;
            float ytela = 400;
            float sla = 0, sla1 = 0, primerosla =0;
            float xgrafico = 0, ygrafico = 1; //x sempre sera x, o valor que colocamos na funcao


            //para fazer o plano cartesiano
            for (int inicio = 0; inicio < 800; inicio += 1)//tamanho do pic
            {   
                centroy1 = centroy + inicio-400; //ex ja que centroy é 400 pois 800/2 é 400 logo o centro y inicial é zero
                float xtela = centrox;
                sla++;
                primerosla++;


                if (sla1 == 5 * 4 + 20)
                {
                    sla1 = 0;
                    grafico.FillRectangle(pintar2, xtela, centroy1, 10, 4);
                    grafico.FillRectangle(pintar2, centroy1, centrox, 4, 10);
                }
                if (sla == 1) {
                    sla = 0;
                    sla1 = sla1 + 1;
                    grafico.FillRectangle(pintar1, xtela, centroy1, 4, 4);
                    grafico.FillRectangle(pintar1, centroy1, centrox, 4, 4);
                }
                
                


            }

            //para fazer a imagem da funcao
            for (int inicio = -400; inicio < 400; inicio += 1)//ex quando pegar x do graf ele tem que ser 0 
            {
                xgrafico = inicio / pixel;
                if (funcaoescolhida == "Função Afim") ygrafico = (a * xgrafico + b);
                else if (funcaoescolhida == "Função Exponencial")
                {
                        float expo = (float)(Math.Pow(b, xgrafico) * a);
                        ygrafico = expo;//quando x sobre função exponencial o x fica diferente
                }
                else if (funcaoescolhida == "Função Quadrática")
                {
                    ygrafico = (a * xgrafico * xgrafico) + (b * xgrafico) + c;
                }  
                float xtela = centrox + (xgrafico * pixel);
                ytela = centroy - (ygrafico * pixel);
                grafico.FillRectangle(pintar, xtela, ytela, 4, 4);
                
                
            }
            pictureBox1.Image = graficofeito;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nudB_ValueChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}

