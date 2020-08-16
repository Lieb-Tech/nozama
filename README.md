# nozama

A variation on APIEndpoints (https://github.com/ardalis/ApiEndpoints)

Felt inspired after listenting to a .Net Rocks episode with Steve Smith to create a SOLID way of doing MVC/API controllers. It was focused on created 
a focused and streamlined workflow. (Note: this just an exercise for me, not a statement on Steve's version - just a different take on some of the concepts)

In the past, I would code controllers with many related, but differing function endpoints. While having a single controller class as a container, with 
class members reduced code repeating and number of files, it can cause extra code noise:
	- It's not clear where the functionality exactly is, causing uncertainty.
	- To scroll through various number of functions to get to the endpoint you are interested in. 
	- To find the datamodel, you need to navigate to different in the folder structure. 
	- To review configurations (like AutoMapper), it's a combination of the two above.

Not only that, these traditional massive controllers, go against SOLID principals - especially single responbility. 

To try out some ideas on how address and streamline these situations, I created a fictious book selling site. It will start with some basic book functionality, and 
grow to offer products from different categories.

Technologies:
	Dapper			- DB to POCO mapping
	AutoMapper		- POCO to POCO mapping/projection
	ASPNet Core		- Server-side framework
	ASPNet Core DI	- Dependency Injection
	Angular			- Frontent

Concepts:
	Single Responsibly		- Controller classes only serve 1 method, sub classes in Service and Repositories only provide 1 function
	Open/Close Principal	- Abstract base classes provide minimum functionlity, which can be added on to by implimentations
	Liskov Substituion		- Allows for 
	Interface Segregation	- Interfaces are kept to a minimum, and are used instead of the implimentations
	Dependancy Inveresion	- Utilizes ASPNet Core's "built-in" Injection
	Factory Pattern			- Used get Services and Repositories, this helps with Single Responsilibity Principal
	Service Layer			- Contains Actions - which is the business logic layer, between controller and repository   (ex: Insert review == (1) Save a review & (2) update the review count)
	Repository - Query		- Returns data from DB without modifications (ex: Get reviews)
	Repository - Command	- Executes DML in the DB (ex: Save a review)
	Repository - Model		- POCO representing DB values 

RESTful
	Get (GET) 		Single entity
						ex: /Book/1

	List (GET)		Multiple entities, with optional paging, pluralized name 
						ex: /Books			-- all books
						/Books/10/0		-- 10 books, with a starting ID of zero

	Create (PUT)	Create a new value 
						ex: /Book

	Update (POST)	Update an existing value
						ex: /Book/1
	
Folder Structure:
/Controllers            
	/{Section}					(book, reviews, cart, etc)
		Method.cs				(get, list, delete, update)
		Method.Profile.cs		(automapper config)
		Method.Model.cs			(return poco)
		Method.Response.cs		(return wrapper, meta info like status codes, errors)

/Service
	/{Section}
		/{Section}Service.cs	(called by the Controller)
		/Action.cs				(sub-classes that contain the method & calls repository)
		/Action.Model.cs		(poco return object, if different than repository)
		/Action.Profile.cs		(automapper config)

/Repository
	/{Section}
		/CommandQuery.cs		(called by the Service)
		/CommandQuery.Model.cs	(poco return object)
