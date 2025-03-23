
    <h1>BlogProject</h1>
    
    <h2>Overview</h2>
    <p>BlogProject is a .NET 8-based web application that follows the Clean Architecture principles. It implements the CQRS pattern using MediatR and employs various modern development tools such as AutoMapper, FluentValidation, and the Repository Pattern. The application uses SQL Server as its database.</p>
    
    <h2>Technologies Used</h2>
    <ul>
        <li><strong>.NET 8</strong></li>
        <li><strong>Clean Architecture</strong></li>
        <li><strong>CQRS Pattern</strong></li>
        <li><strong>MediatR</strong></li>
        <li><strong>AutoMapper</strong></li>
        <li><strong>FluentValidation</strong></li>
        <li><strong>Repository Pattern</strong></li>
        <li><strong>SQL Server</strong></li>
    </ul>
    
    <h2>Getting Started</h2>
    
    <h3>Prerequisites</h3>
    <p>Ensure you have the following installed:</p>
    <ul>
        <li><a href="https://dotnet.microsoft.com/en-us/download/dotnet/8.0">.NET 8 SDK</a></li>
        <li><a href="https://www.microsoft.com/en-us/sql-server/sql-server-downloads">SQL Server</a></li>
        <li><a href="https://visualstudio.microsoft.com/">Visual Studio 2022</a> or <a href="https://code.visualstudio.com/">VS Code</a></li>
    </ul>
    
    <h3>Installation</h3>
    <ol>
        <li>Clone the repository:
            <pre><code>git clone https://github.com/your-repo/BlogProject.git
cd BlogProject</code></pre>
        </li>
        <li>Configure the database connection string in <code>appsettings.json</code>:
            <pre><code>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=BlogProjectDB;Trusted_Connection=True;"
  }
}</code></pre>
        </li>
        <li>Apply database migrations:
            <pre><code>dotnet ef database update</code></pre>
        </li>
        <li>Run the application:
            <pre><code>dotnet run</code></pre>
        </li>
    </ol>
    
    <h2>Project Structure</h2>
    <p>The project follows Clean Architecture principles and consists of the following layers:</p>
    <ul>
        <li><strong>Presentation</strong>: API controllers for handling requests.</li>
        <li><strong>Application</strong>: Contains CQRS handlers, validation, and business logic.</li>
        <li><strong>Domain</strong>: Defines core business entities.</li>
        <li><strong>Infrastructure</strong>: Handles data access and repository implementations.</li>
    </ul>
    
    <h2>Features</h2>
    <ul>
        <li>Implements CQRS for command-query separation.</li>
        <li>Uses MediatR for request handling and decoupling.</li>
        <li>AutoMapper for efficient object mapping.</li>
        <li>FluentValidation for model validation.</li>
        <li>Repository Pattern for better data management.</li>
    </ul>
    
    <h2>Contribution</h2>
    <p>Feel free to fork the repository and submit pull requests. Any contributions are welcome!</p>
    
    <h2>License</h2>
    <p>This project is licensed under the MIT License.</p>
    
    <h2>Contact</h2>
    <p>For any inquiries, please contact <strong>your-email@example.com</strong>.</p>
</body>
</html>
