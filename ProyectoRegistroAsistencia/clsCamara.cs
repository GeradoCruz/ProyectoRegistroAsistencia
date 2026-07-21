using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;



namespace ProyectoRegistroAsistencia
{
    internal class clsCamara
    {
        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice camaraActiva;
        private Bitmap foto;

        public Bitmap Foto { get => foto; set => foto = value; }

        //Buscar camaras conectadas al equipo
        public bool IniciarCamara()
        {

            try
            {
                //se crea el objeto 
                dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                //si no hay ningun dispositivo conectado returna  falso
                if (dispositivos.Count == 0)
                {
                    return false;
                }
                //se genera el objeto al encontrarse un dispositivo conectado
                camaraActiva = new VideoCaptureDevice(dispositivos[0].MonikerString);
                //se suscribe el método al evento NewFrame.
                camaraActiva.NewFrame += camaraActiva_NewFrame;
                //inicia la captura 
                camaraActiva.Start();
                //returna verdadero
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al iniciar la camara: " + ex.Message);
            }
        }

        //método que se ejecuta automáticamente cada vez que la cámara entrega un nuevo fotograma; clona ese fotograma y lo guarda en foto.
        private void camaraActiva_NewFrame(object sender, NewFrameEventArgs e)
        {
            foto = (Bitmap)e.Frame.Clone();
        }

        public void DetenerCamara()
        {
            try
            {
                //valida que la cámara se haya inicializado antes de intentar detenerla
                if (camaraActiva != null)
                {
                    //se desuscribe el método del evento, para que ya no reciba más fotogramas
                    camaraActiva.NewFrame -= camaraActiva_NewFrame;

                    //si la cámara sigue capturando
                    if (camaraActiva.IsRunning)
                    {
                        //solicita a la cámara que detenga la captura
                        camaraActiva.SignalToStop();
                        //esperar a que la camara se detenga por completo 
                        camaraActiva.WaitForStop();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al detener la camara: " + ex.Message);
            }
        }
    }
}
