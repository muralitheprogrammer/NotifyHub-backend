# Notification API

A simple ASP.NET Core Web API for sending notifications using SignalR. This API can be used in conjunction with a Vue.js frontend to deliver real-time notifications to users.

## Features

- Send notifications via POST requests.
- Real-time notification delivery using SignalR.
- Swagger UI for testing API endpoints.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- [Postman](https://www.postman.com/) (optional, for testing)


## Setup Instructions

### Frontend (Vue.js)
Download and setup the frontend service from: https://github.com/muralitheprogrammer/NotifyHub.git


### Backend (C#)
1. Clone the Repository
    ```
    git clone https://github.com/muralitheprogrammer/NotifyHub-backend.git
    cd NotifyHub-backend
    dotnet restore
2. **Build and Run the application**:
    ```
    dotnet build
    dotnet run
## Testing the API
You can test the API endpoints using Postman or Swagger UI:
### Swagger UI: 
Open your browser and navigate to http://localhost:5144/swagger to view and interact with the API documentation.
### Send a Notification: 
Make a POST request to http://localhost:5144/api/notifications with a JSON body containing the notification message.