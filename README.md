ניהול בנק<br>

מערכת לניהול חשבונות בנק, באמצעות המערכת ניתן לעקוב אחר פרטי החשבון, ליצור חשבון חדש ולנהל את כלל התורים של הלקוחות.<br>
ישויות:<br>
• תורים<br>
• פקידים<br>
• לקוחות<br>

מיפוי Routes לתורים:<br>
• שליפת רשימת כלל התורים <Get https://bank.co.il/queues <br>
• שליפת תור לפי מזהה תורGet https://bank.co.il/queues/5874 <br>
• יצירת תור חדש Post https://bank.co.il/queues<br>
• עדכון תור Put https://bank.co.il/queues/5874 <br>
• מחיקת תור לפי מזהה Delete https://bank.co.il/queues/5874 <br>
• עדכון שם בעל התור: Put https://bank.co.il/queues/5874/ownersName<br>

מיפוי Routes לפקידים:<br>
• שליפת רשימת הפקידים Get https://bank.co.il/officials <br>
• שליפת רשימת הפקידים לפי סניף Get https://bank.co.il/officials/branch <br>
• שליפת פקיד לפי מזהה Get https://bank.co.il/officials/1 <br>
• הוספת פקיד Post https://bank.co.il/officials <br>
• עדכון פרטי פקיד Put https://bank.co.il/officials/1 <br>
• מחיקת פקיד לפי מזהה Delete https://bank.co.il/officials/1 <br>

מיפוי Routes ללקוחות:<br>
• שליפת רשימת הלקוחות Get https://bank.co.il/customers <br>
• שליפת רשימת לקוחות לפי כתובת Get https://bank.co.il/customers/address
• שליפת לקוח לפי מזהה Get https://bank.co.il/customers/1 <br>
• הוספת לקוח Post https://bank.co.il/customers <br>
• עדכון פרטי לקוח Put https://bank.co.il/customers/1 <br>
• מחיקת לקוח לפי מזהה Delete https://bank.co.il/customers/1 <br>
