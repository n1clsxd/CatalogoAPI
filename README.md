## CatalogoAPI
Projeto do Curso Web API ASP .NET Core Essencial (.NET 6)

This project is a simple products catalogue API using Entity Framework for model mapping.

### Endpoints and Operations

#### Categories
`POST /catalogoapi/categories` Creates a new product category using JSON payload.

`GET /catalogoapi/categories` Retrieves a list with all categories.

`GET /catalogoapi/categories/products` Retrieves a list with all categories and their products.

`GET /catalogoapi/categories/{id}` Retrieves a specific category by it ID.

`PUT /catalogoapi/categories/{id}` Updates a specific category by it ID using JSON payload.

`DELETE /catalogoapi/categories/{id}` Deletes a specific category by it ID.

#### Products

`POST /catalogoapi/products` Creates a new product using JSON payload.

`GET /catalogoapi/products` Retrieves a list with all products.

`GET /catalogoapi/products/{id}` Retrieves a specific product by it ID.

`PUT /catalogoapi/products/{id}` Updates a specific product by it ID using JSON payload.

`DELETE /catalogoapi/products/{id}` Deletes a specific product by it ID.
