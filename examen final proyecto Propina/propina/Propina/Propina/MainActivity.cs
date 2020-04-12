using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Propina
{
    [Activity(Label = "Propina", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.calcular);


            button.Click += delegate { calcular(); };
        }

        private void calcular(){

           

            var precio = FindViewById<TextView>(Resource.Id.precio);
            var propina = FindViewById<TextView>(Resource.Id.propina);
			var total = FindViewById<TextView>(Resource.Id.resultado);
            decimal auxPrecio;
            int auxPropina;
			;if(string.IsNullOrWhiteSpace(precio.Text)){
                total.Text = "Error,debe introducir el precio a pagar";
            }else{
				try
				{
                    auxPrecio = Convert.ToDecimal(precio.Text);
                    if (string.IsNullOrWhiteSpace(propina.Text))
                    {
                        auxPropina = 0;
                    }else{
                        auxPropina = Convert.ToInt16(propina.Text);
                    }

                    var resultado = auxPrecio + (auxPrecio * auxPropina / 100);
                    total.Text = string.Format("El precio total a pagar es de ${0}.El precio sin propina  es de ${1} con una propina de {2}%.  ", resultado, auxPrecio.ToString(), auxPropina.ToString());

				}
				catch (Exception e)
				{
                    total.Text = "Error:" + e.Message;
				}

              
            }


        }
    }
}

