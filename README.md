# 📦 Inventory & Sales Management System

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)

A **C# Windows Forms** desktop application that enables users to register products with stock and pricing details, view real-time inventory analytics, and dynamically update stock levels through sales transactions.

---

## 🖥️ Application Screenshots

### 1. Products Tab (Product Entry & Analytics)
Users add new items to the system by entering the product name, stock quantity, and unit price. The summary panel on the right dynamically calculates and displays the total product count, average product price, cheapest/most expensive items, and lowest/highest stock items.

<p align="center">
  <img src="urunler.png" alt="Products and Analytics Screen" width="700">
</p>

### 2. Transactions Tab (Sales & Live Stock Tracking)
Users select an existing product from the dropdown menu, specify the sales quantity, and click the **Sell (Sat)** button. The sold quantity is immediately deducted from inventory, and the updated stock list is refreshed in real time on the right panel.

<p align="center">
  <img src="islemler.png" alt="Sales Transactions and Live Stock Screen" width="700">
</p>

---

## ✨ Features

* **Product & Inventory Management:** Dynamic record creation with product name, initial stock quantity, and unit pricing.
* **Real-Time Inventory Analytics:** Automated calculation across registered items for:
  * Total number of distinct products,
  * Average unit price,
  * Lowest and highest priced products,
  * Minimum and maximum stock levels.
* **Dynamic Sales & Stock Deduction:** Instant inventory adjustment upon sale execution with synchronized stock list updates.

---

## 🛠️ Tech Stack

* **Language:** C#
* **UI Framework:** Windows Forms (WinForms)
* **IDE:** Visual Studio
