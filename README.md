# C# Backend (ASP.NET Core Web API)

This project contains the backend implementation of a simple ASP.NET Core Web API to handle rectangle dimensions.

## Getting Started

To get started with the backend, follow these steps:

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) must be installed on your machine.

### Installation

1. Clone this repository.
2. Navigate to the `csharp-backend` directory.
3. Run the command `dotnet run` to start the backend server.
4. The server will start running on `https://localhost:5001`.

## API Endpoints

- `GET /api/rectangle`: Get the current dimensions of the rectangle.
- `PUT /api/rectangle`: Update the dimensions of the rectangle.

### Request and Response Examples

#### GET /api/rectangle

Request:
GET /api/rectangle
Content-Type: application/json

Response: 
200 Ok
```json
{
  "width": 100,
  "height": 50
}

Request:
PUT /api/rectangle
Content-Type: application/json

{
  "width": 200,
  "height": 150
}

Response:
204 No Content
