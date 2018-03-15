# packt-helloworld

A very simple hello world for the Packt "ASP.NET Core with Docker" video course.

This application uses Kestrel. It was created using the following steps:

1. `dotnet add webapi`
2. Some minor folder housekeeping.
3. Add a HelloWorldController with a GET route.
4. Add a Dockerfile
5. Run `docker build .`