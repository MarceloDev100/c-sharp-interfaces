## C# .NET 6.0 

### Exercise (Using interface) - Project 2

A company wants to automate the processing of its contracts. Processing a contract consists of generating the installments to be paid for that contract, based on the desired number of months.


The company uses an online payment service to pay installments. Online payment services typically charge a monthly interest as well as a per-payment fee. For now, the service contracted by the company is Paypal, which applies simple interest of 1% to each installment, plus a payment fee of 2%.


Write a program to read contract data (contract number, contract date and total contract value). Next, the program must read the number of months for installment of the contract, and then generate the records of the installments to be paid (date and value), with the first installment to be paid one month after the contract , the second installment two months after the contract and so on. Show the installment data on screen.


![example](https://user-images.githubusercontent.com/88597534/234165497-7f4f124a-87ee-49f7-afc6-2ebd0ab6b4e9.png)

---

### 📝 Domain layer design

![uml1](https://user-images.githubusercontent.com/88597534/234157682-92fed770-669d-4bd2-b6d3-9cd60b98454f.png)

---

### 📝 Service layer design

![uml2](https://user-images.githubusercontent.com/88597534/234157732-bc0602f8-8804-45dc-9300-0eed3191e439.png)

---

### 💻 Result on screen

![result](https://user-images.githubusercontent.com/88597534/234162656-a38e2500-1971-492a-b2aa-8e3e49da9a8b.png)