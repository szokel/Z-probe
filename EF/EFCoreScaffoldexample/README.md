Meglevo adatbazisbol generalunk EF Core-ral troeteno hasznalathoz osztalyt.

A generalashoz szukseges parancsot itt talalhato:

	scaffold.cmd

tartalma:

```r
dotnet ef dbcontext scaffold "Data Source=.\DEV2019;Initial Catalog=StoreWeb@data;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Model --use-database-names --context "StoreDbContext" -t afakod
```

forras: [Starting with an existing database](https://www.learnentityframeworkcore.com/walkthroughs/existing-database)

_