using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionJuegodeMemoria
{
    public partial class frm_inicio : Form
    {   
        //DECLARACIÓN DE VARIABLES
        //Configuramos la cantidad de filas y columnas del tablero.
        int TamanioColumnasFilas = 4; // Declaramos que esta variable corresponde a números enteros.
        int Movimientos = 0; // Declaramos que esta variable corresponde a números enteros.
        int CantidadDeCartasGiradas = 0; // Declaramos que esta variable corresponde a números enteros.
        List<string> CartasEnumeradas; // Declaramos una lista para las cartas enumeradas.
        List<string> CartasRevueltas; // Declaramos una lista para las cartas revueltas.
        ArrayList CartasSeleccionadas; // Declaramos una lista para las cartas seleccionadas (esta es una clase que permite almacenar datos de manera dinámica).
        PictureBox CartaTemporal1; // Utilizamos dos picturebox para almacenar de manera transitoria los pares de cartas seleccionados.
        PictureBox CartaTemporal2;
        int CartaActual = 0; // Declaramos que esta variable corresponde a números enteros y es útil para almacenar las cartas seleccionadas.

       
        public frm_inicio()
        {
            InitializeComponent();
            iniciarJuego();
        }

        //CREAMOS UN MÉTODO QUE SE LLAMA INICIAR JUEGO
        
        public void iniciarJuego() {
            timer1.Enabled = false;
            timer1.Stop(); //Insertamos el stop con la finalidad de detener el reloj (timer) para que no siga avanzando el tiempo.
            lbl_Record.Text = "0"; // Insertamos el lblrecord para poder reiniciar las cantidad de cartas volteadas.
            CantidadDeCartasGiradas = 0; //Contador de cartas volteadas (para visibilizar en el panel)
            Movimientos = 0;
            PanelJuego.Controls.Clear(); // Con esta instrucción se limpia el panel al finalizar el juego.
            CartasEnumeradas = new List<string>(); //Utilizamos las listas
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();

            //Con el FOR generamos las cartas en forma de números.
            for (int i = 0; i < 8; i++) {  
                //Utilizamos dos arreglos para insertar dos veces la cantidad de cartas, que son 8 con sus respectivos pares.
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            //Ahora generamos la posibilidad de que las cartas se mezclen de manera aleatoria (random).
            //Para ello creamos la variable resultado para que se orden aleatoriamente las figuras.
            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next()); //Generamos la variable Resultado para pode almezar los resultados.

            //Con el FOREACH enumeramos los elementos de la colección y se ejecuta su cuerpo para cada elemento de la colección.
            foreach (string ValorCarta in Resultado) {
                CartasRevueltas.Add(ValorCarta);
            }
            var tablaPanel = new TableLayoutPanel(); // Con El TableLayoutPanel incorporamos los valores de las cartas en el panel.
            tablaPanel.RowCount = TamanioColumnasFilas; // Tamaño de las columnas y filas.
            tablaPanel.ColumnCount = TamanioColumnasFilas;
            //Hacemos un conteo de columnas y filas 
            //Con el FOR implementamos la mezcla de todas las imágenes que usamos.
            for (int i=0; i < TamanioColumnasFilas;i++)
            {
            //Adaptamos el tamaño de las columnas y filas al panel.
                var Porcentaje = 150f / (float)TamanioColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));

            }
            //Introducimos un contador de fichas.
            int contadorFichas = 1;
            //
            for (var i = 0; i < TamanioColumnasFilas; i++)
            {
                for (var j = 0; j < TamanioColumnasFilas; j++)
                {
                    //Agregamos las cartas del juego.  
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", contadorFichas); //Cada carta que se genera va a tener un nombre en el formato contador de fichas.
                    CartasJuego.Dock = DockStyle.Fill; //Cada carta que se genera se adapta al estilo de diseño.
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage; //Especifica como se coloca la imagen en el PictureBox.
                    CartasJuego.Image = Properties.Resources.Girada; //Configura la carta girada con la imagen del mundial.
                    CartasJuego.Cursor = Cursors.Hand; 
                    CartasJuego.Click += btnCarta_Click; //Evento para validar toda acción de PictureBox
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    contadorFichas++;

                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(tablaPanel);
        }
        // Creo el metodo Reiniciar_Click con el botón reiniciar para poder volver a jugar.
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            iniciarJuego();
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            //Contabilizamos cuantos click hizo el usuario sobre las cartas.
            if (CartasSeleccionadas.Count < 2){
                Movimientos++;
                lbl_Record.Text = Convert.ToString(Movimientos); //Indicamos que se registren la cantidad de movimientos
                var CartasSeleccionadasUsuario = (PictureBox)sender; //Señalamos la carta seleccionada por el usuario.
                //Convertimos la carta seleccionada a un número específico.
                CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual); //Recupera la imagen que se muestra por PictureBox.
                CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                // Si la cantdiad es igual a 2, entonces se realizó dos veces el movimiento del click.
                    if (CartasSeleccionadas.Count == 2)
                    {
                        //Generamos las cartas temporales, en relación a las cartas seleccionadas por el usuario cada vez que realiza el click.
                        CartaTemporal1 = (PictureBox)CartasSeleccionadas[0]; //Se almacenan en carta temporal 1.
                        CartaTemporal2 = (PictureBox)CartasSeleccionadas[1]; //Y carta temporal 2.
                        //Hacemos la conversión a número entero para poder contabilizar cada una.
                        int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]); 
                        int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);

                    //Se introduce un operador de desigual en caso que los pares de cartas dadas vueltas no sean las mismas.
                    if (Carta1 != Carta2) 
                    {
                        timer1.Enabled = true; //Se habilita que la carta quede a la vista un instante para poder identificarla.
                        timer1.Start();
                    }

                    else
                    {
                        //En caso que las cartas volteadas son mayores a 7 (son 8 pares) significa que el juego terminó y se completó.
                        CantidadDeCartasGiradas++;
                        if (CantidadDeCartasGiradas > 7)
                        {
                            MessageBox.Show("¡Felicitaciones, completaste el juego!");
                        }
                    CartaTemporal1.Enabled = false; 
                    CartaTemporal2.Enabled = false;
                    CartasSeleccionadas.Clear(); //se borra de la memoria temporal las cartas seleccionadas al no ser idénticas.
                    
                    }
                }
            }   
            
        }

        //CREAMOS EL MÉTODO RECUPERAR IMAGEN.
        public Bitmap RecuperarImagen(int NumeroImagen) //Se relaciona con la carta actual.
        { 
        Bitmap TmpImg = new Bitmap(200,100);
        //Introducimos la estructura condicional que ejecuta diferentes instrucciones.
        //En caso que el valor sea 0 entonces la imagen será la nro 11.
        switch (NumeroImagen)
        {
            case 0: TmpImg = Properties.Resources.img11;
               break;
            default: TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("img"+NumeroImagen);
               break;
            }
        return TmpImg;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int TiempoGirarCarta = 1; //Declaramos que el tiempo de girar la carta es = 1.
            //Introducimos el condicional para asegurarnos que si el tiempo pasó se borran las cartas giradas.
            if (TiempoGirarCarta == 1)
            {

                CartaTemporal1.Image = Properties.Resources.Girada; //Llamamos a la carta de la imagen girada.
                CartaTemporal2.Image = Properties.Resources.Girada; //Llamamos a la carta de la imagen girada.
                CartasSeleccionadas.Clear();
                TiempoGirarCarta = 0;
                timer1.Stop();
            }
        }
    }

}
