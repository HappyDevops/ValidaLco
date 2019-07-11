# Valida LCO
Kit de integración para consulta de Rfcs y LCO.

## Pre requisitos.
Es necesario contar con un usuario integrador y un emisor registrado para poder usar el ambiente productivo.

## Configurar el Kit.
Dentro del proyecto ValidaLco.App, en el archivo de configuración se puede modificar el usuario integrador por defecto, su contraseña o el emisor. El proyecto usa log4net para registrar los errores de las consultas.

## Uso de SlowChetaah.
El proyecto usa Slowchetaah para generar los archivos de configuración, si se elije hacer una Build con Release se usara la configuración de produccion, en cambio si la Build se hace con Debug se usara la configuración de pruebas.

## Proyecto de Testing.
Se agrega un proyecto con los casos de pruebas mas comunes para que entiendas mejor como funciona el servicio e incluso puedes integrarlo en tus flujos de pruebas y/o despliegues.


