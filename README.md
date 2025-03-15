# 🌟 Hope's Peak Library 📖

Hope's Peak Library is an interactive Blazor Server web application inspired by **Danganronpa's Hope's Peak Academy**. It serves as a **digital knowledge hub**, allowing users to create, browse, and manage articles seamlessly. With a sleek UI, Markdown support, and secure authentication, it provides an engaging experience for knowledge sharing.

---

# 🖼️ Screenshots 🖥️

![Home Page](https://github.com/Megamer-studios/Hope-s-Peak-Library/blob/52ff0d3cb4a901c28f64924b94b4abd2314ff394/Media/Screenshot%202025-03-15%20222409.png )
![Articles Page](https://github.com/Megamer-studios/Hope-s-Peak-Library/blob/52ff0d3cb4a901c28f64924b94b4abd2314ff394/Media/Screenshot%202025-03-15%20222430.png )


---
## ✨ Features

- 🔐 **User Authentication** – Secure sign-in and sign-out using Logto.
- 📝 **Article Management** – Create, view, search, and delete articles.
- 🌐 **Interactive UI** – Aesthetic design with smooth animations.
- 📖 **Markdown Support** – Articles are stored and displayed in Markdown format.
- 🏷️ **Admin Controls** – Admin users can delete articles.

---

## 🚀 Getting Started

### 📌 Prerequisites
- .NET 7.0 or later
- Logto account (for authentication)

### 🔧 Installation
1. **Clone the Repository**
   ```sh
   git clone https://github.com/Megamer-studios/Hope-s-Peak-Library
   cd <repository-folder>
   ```

2. **Configure Authentication** in `Program.cs` by replacing placeholders:
   ```csharp
   builder.Services.AddLogtoAuthentication(options =>
   {
       options.Endpoint = "YOUR ENDPOINT HERE";
       options.AppId = "YOUR APPID HERE";
       options.AppSecret = "YOUR APPSECRET HERE";
   });
   ```

3. **Modify `appsettings.json`** as needed:
   ```json
   {
     "Kestrel": {
       "Endpoints": {
         "MyHttpEndpoint": {
           "Url": "http://*:5000"
         }
       }
     },
     "Logging": {
       "LogLevel": {
         "Default": "Information",
         "Microsoft.AspNetCore": "Warning"
       }
     },
     "AllowedHosts": "*"
   }
   ```

4. **Run the Application**
   ```sh
   dotnet run
   ```
   Access the app at **`http://localhost:5000`**.

---

## 📂 Project Structure
```
Hope's Peak Library
│-- Program.cs          # Entry point, authentication setup
│-- appsettings.json    # Configuration settings
│-- App.razor          # Root component
│-- Home.razor         # Main page with authentication and search
│-- CreateArticlee.razor # Article creation page
│-- Articles.razor     # List and view articles
│-- wwwroot/Articles   # Folder storing Markdown articles
```

---

## 🎭 Theme & Purpose
**"Hope is what keeps us moving forward."** Inspired by the themes of **Danganronpa**, this library aims to provide a structured yet creative platform for sharing and storing knowledge. Whether you're an aspiring writer, a researcher, or just someone who loves to document thoughts, this library ensures that information is accessible and well-organized.

---

## 🎯 Usage Guide

### 🔑 Signing In
Click **Sign In** on the home page to authenticate via Logto.

### ✍️ Creating an Article
1. Navigate to **`/CreateArticle`**.
2. Enter a title and content using **Markdown**.
3. Click **Create Article** to publish it.

### 🔎 Viewing & Searching Articles
1. Visit **`/Articles`**.
2. Browse or use the search bar to find articles.
3. Click an article title to read it.

### ❌ Deleting an Article (Admin Only)
Admin users can delete articles by clicking the **Delete Article** button on an article's page.

---

## 👑 Credits
Developed by **Megamer Studios**. 🚀

Or in this case (as a joke) Chihiro Fujisaki 😉

