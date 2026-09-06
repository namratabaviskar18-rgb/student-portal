# Student Portal — PHP + MySQL

Full-stack Student Portal based on the supplied project PPT.

## Modules
- Student login, dashboard and profile
- Semester-wise marks (six semesters / four-subject structure)
- Online test
- Student helpdesk and admin replies
- eBook/PDF download page
- Admin dashboard
- Student records
- Marks management
- Question manager

## Requirements
- XAMPP or WAMP
- PHP 8+
- MySQL/MariaDB
- Browser

## Run locally
1. Copy the folder to `C:\xampp\htdocs\student-portal`.
2. Start Apache and MySQL in XAMPP.
3. Open phpMyAdmin and import `database.sql`.
4. Visit `http://localhost/student-portal/setup.php` once.
5. Delete `setup.php` after setup.
6. Visit `http://localhost/student-portal/`.

### Login
Student: `STU001` / `student123`
Admin: `ADMIN` / `admin123`

## GitHub
Push the project folder to GitHub. Do not upload real student data, passwords, or private PDFs. Add real PDFs to `ebooks/` locally and keep sensitive files out of a public repository.
