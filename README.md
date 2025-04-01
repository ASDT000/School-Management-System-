# Skills International - School Management System

![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?logo=microsoft-sql-server&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-0078D6?logo=windows&logoColor=white)

A complete desktop application for school administration developed in C# with SQL Server backend, created as the final project for DITEC Diploma program.

## 🔑 Login Credentials
-Username: Admin
-Password: Skills@123


## ✨ Key Features
- **Secure Admin Dashboard**
- **Student Management** (Add/Edit/Delete records)
- **Teacher Management** (Add/Edit/Delete profiles)
- **Data Grid Views** for all records
- **User-Friendly Interface** with intuitive navigation

## 🛠️ Technical Details
- **Backend**: C# (.NET Framework)
- **Database**: Microsoft SQL Server
- **IDE**: Visual Studio 2022
- **Architecture**: 3-layer design (Presentation, Business Logic, Data Access)
- **Development Model**: Waterfall methodology

## 📦 Database Structure
The system uses two main tables:

**Students Table**:
- Stores registration details, personal info, contact numbers, parent details
- Includes fields for: Registration No, First/Last Name, Gender, Address, Email, etc.

**Teachers Table**:
- Maintains teacher profiles with: Teacher ID, Full Name, Gender, Address, NIC, etc.

## 🚀 Getting Started

### Prerequisites
- Windows 10+
- .NET Framework 4.7.2 or later
- SQL Server Express (LocalDB)
- Visual Studio 2022 (for development)

### Installation
1. Clone this repository
2. Open the solution in Visual Studio
3. Restore NuGet packages if needed
4. Build the solution (Ctrl+Shift+B)
5. Run the application (F5)

## 📝 Usage Guide
1. **Login Screen**:
   - Enter admin credentials
   - Use "Show Password" to verify input
   - "Clear" button resets the form

2. **Main Dashboard**:
   - View student/teacher statistics
   - Navigate to different modules

3. **Student Management**:
   - Add new students with complete details
   - Edit/update existing records
   - Delete student entries when needed

4. **Teacher Management**:
   - Register new teachers
   - Maintain teacher profiles
   - Upload teacher images

## 🔧 Troubleshooting
If you encounter issues:
1. Verify SQL Server LocalDB is installed
2. Check database connection string in App.config
3. Ensure all NuGet packages are restored
4. Confirm .NET Framework version requirements

## 🌟 Future Improvements
- Cloud database integration
- Enhanced reporting features
- Student attendance module
- Grade tracking system
- Multi-user support with roles

## 📜 License
MIT License - See [LICENSE](LICENSE) file for details.

## 📬 Contact
**Developer**: A.S. Dinushka Tharidu  
**Email**: asdinushkatharidu@gmail.com    
**LinkedIn**: [Profile Link](www.linkedin.com/in/dinushka-tharidu-b3a1a1253)

---

Developed as final project for **DITEC Diploma** (Batch 113 - Avissawella Branch)
