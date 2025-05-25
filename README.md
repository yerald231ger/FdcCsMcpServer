# MCP Server for Forecourt Device Controller (FDC)

This project implements a Model Context Protocol (MCP) server in C# that provides access to Forecourt Device Controller (FDC) data services.

## What is Model Context Protocol (MCP)?

The Model Context Protocol (MCP) is an open protocol designed to simplify interactions between AI tools and systems. Microsoft partnered with Anthropic to create an official C# SDK for MCP.

MCP enables:
- Standardized communication between AI models and external tools
- Tool discovery and invocation
- Structured data exchange
- Dynamic context management

Learn more about MCP:
- [Microsoft Partners with Anthropic to Create Official C# SDK for Model Context Protocol](https://devblogs.microsoft.com/blog/microsoft-partners-with-anthropic-to-create-official-c-sdk-for-model-context-protocol)
- [Build a Model Context Protocol (MCP) Server in C#](https://devblogs.microsoft.com/dotnet/build-a-model-context-protocol-mcp-server-in-csharp/)

## Project Overview

This MCP server application provides tools to interact with an FDC system that monitors fuel tank data. The server exposes methods to retrieve tank delivery information using the MCP protocol.

### Technologies Used

- .NET 9.0
- ModelContextProtocol SDK (v0.2.0-preview.1)
- Microsoft Extensions (Hosting, Http, Logging)
- System.Text.Json for serialization

## Project Structure

- **Services**: Contains service classes for communicating with external APIs
  - `FdcService.cs`: Handles HTTP requests to retrieve tank delivery data

- **Models**: Contains data models for the application
  - `TankDeliveryResponse.cs`: Data models for tank delivery information

- **Tools**: Contains MCP-compatible tool implementations
  - `EchoTool.cs`: Simple echo tools for testing MCP functionality
  - `FdcTool.cs`: Tools for retrieving tank delivery data

## Available MCP Tools

### EchoTool
- `Echo`: Echoes a message back to the client
- `ReverseEcho`: Returns the message in reverse

### FdcTool
- `GetTanksDeliveries`: Retrieves the latest tank delivery data for all tanks
- `GetTankDelivery`: Retrieves the latest tank delivery data for a specific tank

## Getting Started

1. Ensure you have .NET 9.0 SDK installed
2. Clone the repository
3. Build the project: `dotnet build`
4. Run the project: `dotnet run`

The MCP server will start and listen for incoming connections using standard input/output as the transport mechanism.

## How It Works

The application sets up an MCP server with:

- **Logging**: Configured to send trace-level logs to standard error for diagnostic purposes
- **HTTP Client Factory**: Registered for making API calls to the FDC backend
- **Service Registration**: The `FdcService` is registered as a singleton for handling HTTP communication with the FDC system
- **MCP Server Configuration**: 
  - Uses standard input/output as the transport mechanism for MCP protocol communication
  - Automatically discovers and registers tools from the assembly using the `WithToolsFromAssembly()` method
  - Tools are marked with `[McpServerToolType]` for classes and `[McpServerTool]` for methods

When a client connects to the MCP server, it can discover and invoke the available tools:
- Simple echo tools for testing the connection
- FDC-specific tools for retrieving tank delivery data

The server handles the conversion between MCP protocol messages and C# method invocations, providing a standardized way for AI tools to interact with the FDC system.

## Integration Example

You can integrate this MCP server with AI tools or other systems that support the MCP protocol. Here's an example configuration for setting up the MCP server as a stdio service:
```json
 "Fdc C# MCP Server": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "/Users/yerald231ger/Documents/Areas/Courses-Mcp/csharp/src/McpServerFdc/McpServerFdc/McpServerFdc.csproj"
      ]
    }
```