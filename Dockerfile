# Use an appropriate base image with .NET runtime or SDK
FROM mcr.microsoft.com/dotnet/aspnet:7.0

# Set the working directory
WORKDIR /app

# Copy the published output of your application to the container
COPY ./TestPatternBuilder/bin/Release/net7.0/publish .

# Expose the port your application listens on
EXPOSE 80

# Define the command to start your application
ENTRYPOINT ["dotnet", "TestPatternBuilder.dll"]

