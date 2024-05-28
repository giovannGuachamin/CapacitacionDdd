Capacitación Domain Driven Design
    Es un principio para el buen uso de patrones para el código legible

Se basa en 4 aristas
  	Lenguaje ubicuo: Código distribuido entendible para todas las partes del proyecto.
  	Entity Value Objects: Entidades para el dominio.
  	Aggregate root: Persistencia de los repositorios.
  	Bounded Context: Contextos ilimitados, lógica de negocio segmentado or contextos divididos para hacerlo más entendible.
 
Patron Mediator:
	  Separa referencia explicita hacia un objeto, inyectamos una dependencia y hacemos uso de ciertos métodos de la interfaz:
       ISender -> Toma un request y dentro de la clase handler principal sabe que hacer y a que interfaz dirigirse.
     
Unit Of Work
	  Maneja la persistencia de los datos y la transaccionalidad, a través de los repositorios definidos para la persistencia.

CQRS
    Patrón que segrega las responsabilidades, haciendo uso de ciertas clases y métodos para segregar funcionalidades de la aplicación.
    	
    Para temas de consulta manejar nomenclatura sufijo query: ProductoQuery
    Para acceso directo a base de datos usar sufijo command: AddAuthorCommand
