# NttProject
細節說明:

1. BOM表要有表頭和表身2張table

2. MVC架構用Repository Pattern

3. 用 Entity Framework，避免SQL injection

4. 有關的nuget:

Microsoft.EntityFrameworkCore

System.Linq

# 開發人員說明
專案裡面的BomController 是我自行設計與測試用的BOM表，我將BOM表頭與表身藉由is_Head 來區別
小提醒!! 以下BomHeadController與BomDetailController 單純為程式開發能力簡易展示用，並非真實BOM設計!! 

# 佈署說明
1.請將資料庫環境設定於appsettings.json 的DefaultConnection 裡頭 <>
2.於套件管理器主控台執行update-database 
