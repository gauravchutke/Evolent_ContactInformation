
    Project Architecture :

	1. API :- 1. It will recieve the HTTP request, calls the ContactInformationClientRepository layer of the project 
                     & returns the response in Json.
		  2. It also does the Model Validation.

	2. Contact Information Client Repository  :-  1. It works as client repository which doesn't have 
			                                 the business logic but call has been given to the main repository.
			                              2. It has Interface-Class architechture. It doesn't show business logic to client.
			                              3. If requires, we can make it posible.
						      4. It uses the Factory Pattern to instantiate the Repository

	3. Contact Information Main Repository :- 1. It actually implements the business logic. 
						  2. It dynamically creates the Database using Entity Framework Code First Approach.  
					          2. It performs CRUD operations and sends appropriate result back to API.

	4. Contact Information Model :- It contains all Models required to any layer of the project architecture.
