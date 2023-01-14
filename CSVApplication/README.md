### Documentacion de Aplicacion

####Presentacion:

CSVApplication es una aplicacion que nos ayuda a mapear en una vista de una tabla todos los datos que tengamos dentro de un archivo csv. Solo basta con subir el archivo desde tu ordenador y la aplicacion hara el resto. 

***Instalacion***

*- Para poder ejecutar la aplicacion es necesario conectarse por medio de una base de datos para que la informacion se pueda almacenar y actualizar. Es importante utilizar la base de datos sql server. *
*La descarga de el proyecto incluye el script de la base de datos para que se pueda trabajar con ese mismo script.
*
> **Conexion de Data Base**

> Para la conexion con la base de datos es importante establecer en el **appsetting** de la aplicacion el nombre de la base de datos segun con la que se este trabajando, tambien es importante  establecer los valores como usuario y contraseña si se tienen. 

> **Ejemplo**
> ****"ConnectionStrings": {
    "DefaultConnection": "server = DEVELOPJUNIOR; database = CSVApplication; Trusted_Connection = true "
  },****
  
  El codigo esta elaborado en .Net Core 6.0 y tambien posee Paquetes de Entity Framework. 

Para hacer uso de esta aplicacion es importante tener un archivo .csv se puede crear en un blog de notas
y cada elemento separarlo por coma (","). 

Es imprtante agregar 4 elementos importantes en el archivo, los cuales son 

*** id (puede pasarse el valor 0 )**
* Nombre 
* Apellido
* Edad
* Ciudad**

Ya que la aplicacion esta limitada a un rango de columnas especifico. 

**Ejemplo: **

> **1, nombreEjemplo, apellidoEjemplo, edadEjemplo, ciudadEjemplo
> 2, nombreEjemplo, apellidoEjemplo, edadEjemplo, ciudadEjemplo**

Una vez abierta la aplicacion y la base de datos ya este configurada con la aplicacion se puede subir el archivo

**Funcionalidad de la aplicacion:**

> La aplicacion esta desarrollada con el fin de que cualquier archivo .csv pueda subirse, leer la informacion e interpretar los datos que vienen en el archivo convirtiendolos en un formato que pueda adaptarse para trabajar con estos. 

> Estos datos son leidos y enviados a la base de datos, una vez enviados se mapearan y apareceran en la la vista de nuestra aplicacion.

> La apliacion comprobara si existen registros con el mismo nombre, si ya existen entonces omitira agregarlos pero si no existen entonces creara el nuevos archivo. 

> Para ver los cambios es importante refrescar la pagina para que los nuevos elementos aparezcan en la tabla de la vista. 

> La aplicacion actualmente trabaja con un pluggin de DataTable instalado por medio de CDN el cual nos proporciona caracteristicas para la tabla como un buscador y una paginador, el buscador es completamente funcional, para el paginador se debe ingresar en el script del datatable el limite de registros por tabla. 

> Los estilos de la tabla son muy basicos por esa razon se utiliza Bootstrap y una hoja de estilo muy sencilla  en el mismo archivo de el Html. 

> Aqui no se manejaron framworks para el front end debido a que los estilos son muy pocos y no se ve necesario 
> Estos datos son leidos y enviados a la base de datos, una vez enviados se mapearan y apareceran en la la vista
de nuestra aplicacion.

> La apliacion comprobara si existen registros con el mismo nombre, si ya existen entonces omitira agregarlos pero si no existen entonces creara el nuevos archivo. 

> Para ver los cambios es importante refrescar la pagina para que los nuevos elementos aparezcan en la tabla de la vista. 

> La aplicacion actualmente trabaja con un pluggin de DataTable instalado por medio de CDN el cual nos proporciona caracteristicas para la tabla como un buscador y una paginador, el buscador es completamente funcional, para el paginador se debe ingresar en el script del datatable el limite de registros por tabla. 

> Los estilos de la tabla son muy basicos por esa razon se utiliza Bootstrap y una hoja de estilo muy sencilla  en el mismo archivo de el Html. 

> Aqui no se manejaron framworks para el front end debido a que los estilos son muy pocos y no se ve necesario  el tener que instalar un framework ya que puede hacer mas pesada la aplicacion. el tener que instalar un framework ya que puede hacer mas pesada la aplicacion. 

**Muchas gracias!!**
