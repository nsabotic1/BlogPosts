# Rubicon task
-------------------------

## Run and build

* Install .NET 6 SDK.
* Install the following packages:
  * Microsoft.EntityFrameworkCore (7.0.0)
  * Microsoft.EntityFrameworkCore.Tools (7.0.0)
  * Microsoft.EntityFrameworkCore.Design (7.0.0)
  * Microsoft.EntityFrameworkCore.SqlServer (7.0.0)
  * AutoMapper.Extensions.Microsoft.DependencyInjection (12.0.0)
  * System.Text.Encoding.CodePages
  * coverlet.collector
  * xunit
  * xunit.runner.visualstudio
  * System.Text.Encoding.CodePages
  * Swashbuckle.AspNetCore
  * Microsoft.NET.Test.Sdk
  * FakeItEasy
* Run `update-database` for a database to be made
* Note: Please check your server name (mine is (localdb)\MSSQLLocalDB)).
 In case that your name is different than mine, change the server name
 to your server name in DataContext.cs, line 22
