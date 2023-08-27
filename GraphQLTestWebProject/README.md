# GraphQL - Graph Query Language

**What is GraphQL &#63;**</br>
-	A query language to build & query the Api's
-	Invented by facebook in 2012
-	Open sourced in 2015
-	1000+ companies are using GraphQL like facebook, twitter, pinterest, Instagram, Shopify, PayPal, Starbucks
-	Language and Platform independent

**Why we need GraphQL &#63;**
-	GraphQL has solved the data under fetching and over fetching challenges.

**Note:**
-	REST is not going anywhere
-	GraphQL is not a replacement of REST
-	When the project scope is bigger then use GraphQL otherwise use REST

**GraphQL Query**
-	GraphQL Query is used to read and fetch the data from the server.
-	GraphQL Explorer: https://docs.github.com/en/graphql/overview/explorer

> **Simple Query**</br>
  The Query start with query keyword (It is not compulsory). The query followed by Fields. The field have subfield. Below is the example of query.

    query MyFirstQuery {
      viewer {
        id
        name
        login
        createdAt
      }
    }

  In the above MyFirstQuery is query name.

> **Query With Argument** </br>

    query {
      repository(name: "graphql" owner: "facebook") {
        createdAt
        id
      }
    }

> **Query With Aliases** </br>

    query {
      DotNetRepo: repository(name: "core", owner: "dotnet") {
        createdAt
        id
        url
      }
      WPFRepo: repository(name: "wpf", owner: "dotnet") {
        createdAt
        id
        url
      }
    }

> **Query with Fragments** </br>
  The fragments can be used if we want to separate common subfields.

    query {
      DotNetRepo: repository(name: "core", owner: "dotnet") {
        ... RepoCommonField
      }
      WPFRepo: repository(name: "wpf", owner: "dotnet") {
        ... RepoCommonField
      }
    }
    
    fragment RepoCommonField on Repository {
      createdAt
        id
        url
    }

> **Query with Variables** </br>

    query DotNetRepo($name:String! $owner: String!){
      repository(name: $name, owner: $owner) {
        createdAt
        id
        name
        description
      }
    }

  We have to put variables value in Query Variable Request Header

    {
      "name": "core",
      "owner": "dotnet"
    }

**GraphQL Mutation** </br>
-  Mutation is for making the changes in the server data.
-  Mutation include - CREATE, UPDATE and DELETE Operation
-  Mutation syntax start with **mutation** keyword

> Example </br>

    mutation AddProject($input: CreateProjectInput!) {
      createProject(input:$input) {
        clientMutationId,
        project {
          id
          createdAt
          url
        }
      }
    }

  Query Variables  
  
    {
    "input": {
      "ownerId": "U_kgDOCEiXrg",
      "name": "First GraphQL Project",
      "body": "Test GraphQL Project",
      "clientMutationId": "11763763"
      }
    }

