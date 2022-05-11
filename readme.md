# C# library for the EpsilonSmart Eshop API

This is the EspilonSmart API descriptor. The particular definition of the API provides API endpoints related to e-shop operations. </br>  All the following actions require Authorization token. Http request should contain a header having key: 'Authorization' and value: 'Bearer {Jwt Token value}'.   If the request lacks Authorization header or the token is invalid, each action responds with status 401 Unauthorized.

## Swagger
https://epsilonsmart6.epsilonnet.gr/swagger/Eshop/swagger.json

## swagger-codegen
https://github.com/swagger-api/swagger-codegen

## Instructions
### Set-up code generation
```
$ ./install-codegen.sh 
```
### Run code generation
~~~
$ ./run-codegen.sh 
~~~