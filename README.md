# Paginated API with ASP.NET Core Web API

## Project Description
This project implements an ASP.NET Core Web API that supports paginated data retrieval. The API allows clients to specify the page size and page number to fetch a subset of data.

## Features
- **Pagination**: Retrieve data in a paginated manner using `pageSize` and `pageNumber` parameters.
- **Error Handling**: Validates pagination parameters and handles errors gracefully.
- **Structured Response**: Returns data along with metadata such as total item count and total pages.

## API Endpoint
### GET /api/data
Retrieve paginated data.

#### Parameters
- `pageSize` (int): The number of items to retrieve per page.
- `pageNumber` (int): The specific page of data to retrieve.

#### Example Request
```http
GET /api/data?pageSize=10&pageNumber=1
GET https://localhost:7187/api/Items?pageNumber=5&pageSize=10
