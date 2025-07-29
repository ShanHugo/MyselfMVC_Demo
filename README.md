# ASP.NET Core MVC 個人作品集 Demo

這是一個使用 ASP.NET Core MVC 建置的個人網站專案，展示了我的自傳、作品集與聯絡表單等功能。  
本版本為觀看設計，**不需額外安裝 SQL Server Management Studio（SSMS）即可執行**。

---

## ✅ 專案亮點

- 使用 Entity Framework Core 連接 SQL Server LocalDB
- 自動建立資料庫與初始化資料（無需手動匯入 `.bak` 或執行 SQL 指令）
- 完整 MVC 架構實作
- 提供兩筆作品集資料可直接瀏覽

---

## 📁 專案結構

| 資料夾/檔案         | 說明 |
|----------------------|------|
| `Models/`            | 資料模型與資料庫上下文 |
| `Controllers/`       | 控制器（作品、聯絡） |
| `Views/`             | Razor 頁面 |
| `Data/DbInitializer.cs` | 程式碼初始化資料庫與種子資料 |
| `appsettings.json`   | 資料庫連線字串（LocalDB） |
| `README.md`          | 本說明檔 |

---

## 🛠 執行前準備

### ✅ 必要條件

- Windows + Visual Studio 2022 或以上（已安裝 ASP.NET Core 工作負載）
- 本機安裝 LocalDB（Visual Studio 預設已安裝）

---

## 🚀 如何執行

1. **打開 Visual Studio**
   - 使用 Visual Studio 開啟本專案資料夾

2. **檢查連線字串（如未更改無須理會）**
   - 在 `appsettings.json` 中：
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ForProject;Trusted_Connection=True;"
     }
     ```

3. **執行專案**
   - 按下 `F5` 或點選「IIS Express」啟動網站
   - 首次執行時會自動建立資料庫並填入資料

---

## 🔎 使用者可瀏覽功能

- `/`：首頁
- `/Project/Index`：作品牆
- `/Home/PersonalStatement`：自傳頁面
- `/Project/Contact`：聯絡我表單

---

## 💡 備註

- 若您想切換成 SQL Server Express 或其他資料庫，可修改 `appsettings.json` 中的連線字串。
- 若您已安裝 SSMS，也可手動執行 `Data/Init.sql` 或匯入 `Data/ForProject.bak` 進行部署。

---

## 👨‍💻 作者

楊善宇  
本專案用於申請資訊所研究所推甄  
