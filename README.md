# Student Course Management System

A C# Windows Forms application for managing students, their courses, weighted grades, and pass/fail results.

> **Türkçe özet:** Öğrenci kaydı, ders ekleme, not girişi ve ders bazlı başarı durumunu yönetmek için hazırlanmış Windows Forms uygulamasıdır.

## Features

- Add students with unique student numbers
- Add courses with course name, code, credit, midterm, and final grades
- Weighted grade calculation: 40% midterm and 60% final
- Pass/fail status at a 50-point threshold
- List the selected student's courses in a data grid
- Basic validation for required fields, credit value, duplicate student IDs, and duplicate course codes

## Run locally

1. Open `SSProject.sln` in Visual Studio on Windows.
2. Install the **.NET desktop development** workload when prompted.
3. Build and run the application.

## Technical notes

- UI: Windows Forms
- Architecture: simple controller and model layers
- Data is kept in memory for the current application session.
