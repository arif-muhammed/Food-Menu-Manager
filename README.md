🍽️ Food Menu Manager

📌 Overview

A C# Windows Forms application for creating and managing a food menu.
The system uses object-oriented programming (OOP) concepts with inheritance, polymorphism, and list management.

🚀 Features

Base Class: Yiyecek (fields: name, type, price, tax rate)

Derived Classes: Meyve, Salata, Tatli, Icecek (extra field: calories, override yazdir())

Menu Class:

Stores items in a generic List<Yiyecek>

Supports add, remove, and print menu functions

Form1.cs:

ComboBox for selecting food type

TextBoxes for entering data

Button to add items → shown in ListBox

Validation: Menu accepted if items meet calorie & price range


🖥️ How to Run

Open the solution in Visual Studio 2022+.

Build and run (F5).

Use the form to add items (choose type, fill fields, click Add).

Menu items are displayed in ListBox.

🔮 Future Improvements

Save menu to file (CSV/JSON).

Add search & filter by calories/price.

Export accepted menus as reports.

📜 License

This project is licensed under the MIT License.
