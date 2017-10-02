# IEnumerable vs IQuerable
### Introduction
IEnumerable and IQuerable both are the interfaces for .NET collections. 
### IEnumerable
Is the parent interface for all non-generic collections in System.Collections namespace like ArrayList, HastTable etc. that can be enumerated. For the generic version of this interface as IEnumerable<T> which a parent interface of all generic collections class in System.Collections.Generic namespace like List<> and more. 
### IQueryable
The IQueryable interface inherits the IEnumerable interface so that if it represents a query, the results of that query can be enumerated. 
Enumeration causes the expression tree associated with an IQueryable object to be executed. The definition of "executing an expression tree" is specific to a query provider. For example, it may involve translating the expression tree to an appropriate query language for the underlying data source.
Queries that do not return enumerable results are executed when the Execute method is called.
### Difference
- If you create IQueryable, then the query may be converted to SQL and will run on the database server.
- If you create IEnumerable, then all rows will be pulled into memory as objects before running the query

[Read More](http://www.c-sharpcorner.com/UploadFile/a3d5d0/ienumerable-vs-iquerable/)
