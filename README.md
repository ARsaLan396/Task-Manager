## 🛠️ تکنولوژی‌های استفاده‌شده

- **بک‌اند:** ASP.NET Core MVC, #C
- **دیتابیس:** SQL Server, Entity Framework Core
- **فرانت‌اند:** Razor Views, Bootstrap, جاوااسکریپت خالص (Fetch API)
- **الگوها:** Abstraction با Interface، Dependency Injection، Soft Delete، الگوی DTO

## 🚀 راه‌اندازی پروژه

۱. ریپازیتوری رو Clone کن

۲. Connection String رو تو `appsettings.json` آپدیت کن

۳. Migration ها رو اجرا کن:
```bash
dotnet ef database update --startup-project EndPoint.Site
```

۴. پروژه رو اجرا کن:
```bash
dotnet run --project EndPoint.Site
```

## 👤 سازنده

ساخته‌شده توسط **قاسم** به‌عنوان بخشی از دوره کارآموزی برنامه‌نویسی بک‌اند، با تمرکز بر یادگیری ASP.NET Core، Clean Architecture و EF Core.
