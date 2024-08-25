# 🚗✨ ABC Car Traders Management System

**Welcome to the ABC Car Traders Management System!** 🎉  
ABC Car Traders has built a strong reputation as a supplier of high-quality vehicles and as a provider of reliable transport solutions. This project aims to maintain and enhance that reputation by delivering a smooth, efficient management system. Whether you're an **Admin** managing cars and orders or a **Customer** looking for your dream car, this system has got you covered! 🌟

## 📋 Overview

This project brings you a robust management system that helps **ABC Car Traders**:  
- 🛠️ **Admin**: Manage car, car parts, customer, and order details, with the ability to generate detailed reports. 📊
- 🧑‍💼 **Customer**: Register, log in, browse cars and car parts, place orders, and track order statuses.

## 🌟 Features

### 🛠️ Admin Panel Features

- 🔐 **Login**: Secure login for admins.  
- 🚗 **Manage Car Details**: Add, edit, or delete cars in the system's inventory.  
- ⚙️ **Manage Car Parts**: Keep your spare parts database up to date with ease.  
- 👥 **Manage Customer Details**: Update and maintain customer records in just a few clicks.  
- 🛒 **Manage Customer Orders**: View and update customer orders, ensuring accurate order tracking.  
- 📊 **Generate Reports**: Create reports for:
  - Car Details 🚘
  - Car Parts ⚙️
  - Customer Information 🧑‍💻
  - Customer Orders 📦

### 👨‍💼 Customer Portal Features

- 📝 **Register**: New customers can easily sign up to access services.  
- 🔐 **Login**: Existing customers can securely log in to their accounts.  
- 🔍 **Search for Cars**: Browse through the available vehicles effortlessly.  
- 🛠️ **Search for Car Parts**: Find the right parts for your car from the inventory.  
- 🛒 **Order Vehicles/Parts**: Place an order for cars or parts with a few simple clicks.  
- 🚚 **Track Order Status**: Stay updated on your order progress and expected delivery.

## 💻 Technology Stack

This project is built using **C#** and .NET, with a focus on performance and scalability.  

- **Frontend**: Windows Forms / WPF  
- **Backend**: C# with .NET  
- **Database**: SQL Server  
- **Reporting**: Microsoft Report Viewer for generating detailed reports in PDF format.

## 🚀 Getting Started

### Prerequisites

- Install **Visual Studio** with the **.NET Desktop Development** workload.
- SQL Server up and running on your system.

### Installation Steps

1. Clone this repository:
    ```bash
    git clone https://github.com/avishkaJSPshehan/ABC-Car-Traders.git
    ```

2. Open the solution in **Visual Studio**:
    ```bash
    ABC_CarTraders.sln
    ```

3. Restore NuGet packages:
    - In Visual Studio, right-click on the solution and select **Restore NuGet Packages**.

4. Set up your database:
    - Update your database connection string in `appsettings.json`:
      ```json
      "ConnectionStrings": {
        "DefaultConnection": "your_sql_server_connection_string"
      }
      ```

5. Build and run the project:
    - Press **F5** to build and run the application in debug mode.

## 🛠️ Available Functionalities

- **Admin Operations**: Manage cars, car parts, customers, and orders.
- **Customer Operations**: Browse, order, and track vehicles/parts.
- **Reports**: Dynamic report generation for business insights.

## 🤝 Contributing

We 💖 contributions! Here’s how you can get involved:

1. Fork this repository 🍴  
2. Create a new branch (`git checkout -b feature/amazing-feature`) 🌿  
3. Make your changes and commit (`git commit -m 'Add amazing feature'`) ✏️  
4. Push to the branch (`git push origin feature/amazing-feature`) 🚀  
5. Open a Pull Request 📩

## 📄 License

This project is licensed under the **MIT License** – feel free to use it as you see fit! See the [LICENSE](LICENSE) file for more details. 🎓