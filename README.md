# wealth
A Demo project for Wealth. This is far from production-ready code and still missing unit testing, functional testing which we can use in-memory hosting to do API testing and lacks of HATEOAS discoverable API which we can use Swagger.

Instruction:
1. Clone the project.
2. Use VS 2017 to open "Wealth.sln".
3. Open Package Manager Console and run a command "Update-Database" to initialise the database.
4. Build and run the application

If the automated EF code-first approach does not work, please create a new database, run the script "ManualDB.sql" and change the database config in Web.config file accordingly.
