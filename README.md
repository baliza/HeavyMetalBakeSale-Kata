# Heavy Metal Bake Sale-Kata

Basado en http://tddbuddy.com/katas/Heavy%20Metal%20Bake%20Sale.pdf


Perteneces a una banda de heay metal y para poder lanzar vuestro proximo disco "los unicornios son de colorines" habeis pensado en hacer pasteles para poder financiaros y teneis los siguientes productos a estos precios

| Short | Name | Price | Amount | 
| ------ | ------ | ------ | ------ |
| B | Brownie | €0.65 | 40 | 
| M | Muffin | €1.00 | 36 | 
| C | Cake Pop | €1.35 | 24 | 
| W | Water | €1.50 | 30 | 

Para gestionar la venta te propones hacer un software que controle el inventarío y os haga las cuentas (piensas que lo vas a petar!)


Asi pues el software te preguntará 
#### Items to Purchase? 
	le pasaras los **shorts** separados por coma
#### Total 
	La aplicacion te respondera con el total del precio de la compra
	Si no hay suficientes items de uno de ellos te dirá que no tiene suficientes:    Not enough stock
#### Amount Paid
	Luego te preguntará cuanto pagas e introduciras el valor de lo que le das	
#### Change
	Te calculará el cambio	
	
Items to Purchase > B, C, W 
Total > $3.50 
Amount Paid > $4.00 
Change > $0.50  

Items to Purchase > B 
Total > $0.65 
Amount Paid > $0.75 
Change > $0.10 

Items to Purchase > B, 
Total > $1.30 
Amount Paid > $1.75 
Change > $0.45 

Items to Purchase > C,M 
Total > $2.35 
Amount Paid > $2.00 
Change > Not enough money 

Items to Purchase > W 
Total > Not enough stock

### Condiciones
*	Para comprar más de uno metes dos veces el short
* 	EL inventario es un Servicio externo, que te dirá ctos quedan (hacedlo hardcodeado en el servicio metiendo los valores iniciales en el ctor, no necesitáis ir a la BBDD) 
*	Como el mercado de la pastelería es un mercado fluctuante meteréis un servicio que te devuelva el precio de un pastel (siempre el mismo precio tb en memoria, igual que el anterior)
*	Quiero ver un objeto compra al cual le metes un objeto ítem (o pastel o lo que creáis conveniente) y un precio (pensad en dominios en interfaces ....)
*	Quiero un servicio calculador de devoluciones singleton que le metes pasas una compra y una cantidad pagada
*	Quiero ver Test al final
*	Quiero código limpio
*	Quiero ver solid
*	No os compliquéis
* 	Intentad hacerlo y luego lo refactorizais


## PARTE 2
* mete un WCF que haga de servicio Externo, este servicio tiene su propia capa de gestión del inventario



## PARTE 3
* mete un servio RESTFull que haga de servicio Externo, este servicio tiene su propia capa de gestión de los precios

	