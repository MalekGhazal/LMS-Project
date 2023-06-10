# LMS-Project

## UML Explanation
1. General Description
    - Getter / Setter / toString are not written.
    - Multi-valued fields can use integer or string.
    - Other services' class will be described along with the coding. 
    - Only list complex fields and methods to discuss below. 
2. User Class
    - id: PK, 6 or 8 digits
    - userType: (string) Staff / User / Supplier , or (int) 0 / 1 / 2
    - memberShip: yes / no / tbReviewed : applied but not comfirmed, or (int) 0 / 1 / 2
3. UserDAO Class
    + updateMemberShip(member: User):boolean : update users' memberShip status ( no -> yes => add a member). 
    + searchUsersByMemberShip(memberStatus:String):User[ ]: find users whose memberShip needs to be comfirmed.
    + loginByEmail / Phone / Id : validate users' password when login
4. Book Class
    - id: PK, there are multiple copies of the same book. they have different ids.
    - status: (string) reserved / lentOut / inStock / forSale, or (int) 0 / 1 / 2 / 3
    - userId: if the status is reserved / lentOut / forSale , it's possible to save the person's id who is related with this status. If the book has been sold, just delete it from the database. 
    - time: Date :(optional) record the time when book status changes. For example, according to the time available for borrowing, the time when the book will be returned to the library can be calculated.
5. BookDAO Class : operations on books
    + updateBook(newBookInfo: Book):boolean   :  update books' status, userId and time ,etc, to implement the functions, such as reserve a book , modify info, lend/return books, sell books 

## Saving Data
1. Database is recommended.



