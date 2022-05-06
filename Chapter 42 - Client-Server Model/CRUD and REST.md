## CRUD and REST

CREATE, RETRIEVE, UPDATE, DELETE: The four fundamental opeartions for any database or content management system.

**Representation State Transfer**: Enables CRUD to be mapped to data SQL functions:
- The REST API effectively allows JavaScript to talk to a databse server through HTTP.
- This menas that the client computer needs no knowledge at all of how the database server works.
- It doesn't need to care how its requests will actually be carried out.
- The upside is any client or server can be developed independently and they can be sure it won't break the other.

1. Create HTTP Request and call REST API
**WEB-SERVER**
2. Client side javascript passes HTTP request to server
**DATABASE-SERVER**
3. JSON/XML response
**WEB-SERVER**
4. Browser interprets JSON/XML response

 **Crud        HTTP        SQL Database**
1. Create,     POST,       INSERT
2. Retrieve,   GET,        SELECT
3. Update,     PUT,        UPDATE
4. Delete,     DELETE,     DELETE