# LMS-Project

## UML Explanation
1. General Description
    - Getter / Setter / toString methods are not written.
    - String or Enum can be used for multi-valued fields.
    - Only list complex fields and methods to discuss below. 
2. Person class
    - role: Staff / User / Supplier,
3. User Class
    - memberShip: yes / no / tbReviewed : applied but not comfirmed, 
4. Book Class
    - status: reserved / lentOut / inStock / forSale,
    - userId: if the status is reserved / lentOut / forSale , it's possible to save the user's id who is related with this status. If the book has been sold, just set it empty in the database. 
    - timeOfStatusChanged: Date type(optional), records the time when book status changes. For example, according to the length of time user can borrow, the time when the book will be returned to the library can be calculated.



