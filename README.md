# EntityFramework con Web API en capas
<h2>Detalles</h2>
<p>Al momento de crear el proyecto web ASP.Net se eligió la plantila WEB Api,depuesse armó la arquitectura en capas y desde el nuget package se instaló la libreria EntityFramework</p>
<p>Al momento de correr las migraciones con el commando "update-database" se tiene que correr desde la capa de Infraestructure y establecerlo como proyecto de inicio.</p>
<p>Cabe resaltar que el controlador llama a la capa de servicios para ejecutar los metodos de mantenimiento.</p>
<h2>Capturas</h2>

<img src="../master/img/img1.png" alt="img1"></img>
<br>
<img src="../master/img/img2.png" alt="img2"></im>
<br>
<img src="../master/img/img3.png" alt="img3"></img>
