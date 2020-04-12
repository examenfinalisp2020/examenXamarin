<h1>Ejercicio 1: Crear un proyecto Xamarin.Android para calcular la propina</h1>

<ol>
<li>Inicie su IDE preferido (Visual Studio o Visual Studio para Mac).</li>
<li>Crear una nueva vista única proyecto Xamarin.Android. <img src="img/1_ejercicio1.png"  />
En Visual Studio para Mac, utilice Archivo> Nuevo> Solución y , a continuación, elija la plantilla Aplicación de Android en la categoría de Android> Aplicación . 
En Visual Studio, utilice Archivo> Nuevo> Proyecto y , a continuación, elija la plantilla de vista única (Android) de la categoría Visual C #> Android .</li>
<li>Asigne un nombre a la aplicación Propina. <img src="img/2_ejercicio1.png"  /></li>
<li>Elija una ubicación para los archivos del proyecto. <img src="img/3_ejercicio1.png"  /></li>
<li>Utilice los valores predeterminados para todas las demás configuraciones del proyecto.</li>
</ol>


<h2>Examine el código</h2>

<ol>
<li>Ejecute la aplicación y pasa un momento con ella para que entiendas su comportamiento. El código de plantilla normalmente tiene un solo botón que muestra el número de veces que se ha hecho clic.</li>
<li>Abra el archivo Recurso> Diseño> Main.axml en la vista Origen. Si encuentra que está en la vista Diseño, haga clic en la ficha código en la parte inferior de la ventana.</li>
<li>Examine el XML que declara el archivo Button. En particular, tenga en cuenta que el botón tiene un id asignado.</li>
<li>Abra el archivo MainActivity.cs .</li>
<li>La plantilla generó una actividad para usted. Las actividades son los componentes básicos de las aplicaciones de Android. El atributo Activity de MainActivity tiene MainLauncher establecido como true, lo que hace que esta actividad sea la entrada principal de su aplicación (es decir, análoga a un método principal de una aplicación de consola C #). Observe que también asigna un icono a la actividad: esto establece un icono junto al título de la aplicación cuando la aplicación está mostrando esta actividad.</li>
<li>Hay dos cosas a tener en cuenta OnCreate. SetContentViewtoma un identificador de un archivo XML ( Resource.Layout.Main) como su argumento y crea una instancia de la interfaz de usuario. FindViewById toma una id y devuelve una referencia a la vista con ese id. Así es como el código obtiene acceso a las vistas en la interfaz de usuario.</li>
</ol>


<h2>Crear la interfaz para calcular la propina</h2>

<ol>
<li>Abrimos el archivo Main.axml</li>
<li>Eliminamos el botón que se crea de forma predeterminada</li>
<li>Agregamos 2 editText, uno para introducir el precio y otro para introducir el % de propina. Se puede arrastrar o escribir directamente desde el editor axml <img src="img/4_ejercicio1.png"  />  <img src="img/5_ejercicio1.png"  /></li>
<li>Agregamos 4 TextView, 3 para describir lo que es cada campo y un último para mostrar el resultado </li>
<li>Agregamos un botón para realizar la operación</li>
<li>Agregamos un id a los elementos para tener acceso desde código</li>
</ol>

<h2>Aplicar la lógica para realizar el calculo</h2>
<p>Modifique el archivo MainActivity.cs y aplique la lógica de negocio. Intentar hacer sin mirar el código. </p>
