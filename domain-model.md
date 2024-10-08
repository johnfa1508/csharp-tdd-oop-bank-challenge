***
# User stories for Bank challenge

#### 1. As a customer, <br> So I can safely store use my money, <br> I want to create a current account.

#### 2. As a customer, <br> So I can save for a rainy day, <br> I want to create a savings account.

#### 3. As a customer, <br> So I can keep a record of my finances, <br> I want to generate bank statements with transaction dates, amounts, and balance at the time of transaction.

#### 4. As a customer, <br> So I can use my account, <br> I want to deposit and withdraw funds.

***

### Bank domain models

| **Classes** | **Methods** | **Scenario** | **Outputs** | **Description** |
|:---:|:---:|:---:|:---:|
| `Customer` | CreateAccount(string) | Create an account for normal use | bool | The CreateAccount()-method calls a method in  |
|  | CreateSavingsAccount(string) | Create a savings account | bool | The CreateSavingsAccount()-method creates an account by calling a method in the Bank-class. Send customer ID? The customer ID then becomes a key for a dictionary in Bank. |
|  | GetBankStatement() | Generate a bank statement  | void | The GetBankStatement()-method does a print that contains transaction dates, amounts and the balance at the time of the transaction. |
| `BankAccount` | Withdraw(decimal) | Withdraw money from an account | bool | The Withdraw()-method makes a Transaction-object sends it to an account.
|  | Deposit(decimal) | Deposit money to an account | bool | The Deposit()-method makes a Transaction-object and sends it to an account money from an account.

***

### Overview of Classes

| **Classes** | Properties |
|:---:|:---:|
|`Bank`| Dictionary\<int, BankAccount> _bankAccounts_|
|`Person`| Bank _bank_, int _id_, string _name_ |
|`Manager : Person`|  |
|`Customer : Person`|  |
|`Engineer : Person`|  |
|`BankAccount`| string _accountName_, int _customerID_, List\<Transaction> _transactionHistory_, decimal _balance_, StringBuilder _bankStatement_ |
|`SavingsAccount : BankAccount`|  |
|`Account : BankAccount`|  | 
|`Transaction`| string _date_, TransactionType _typeOfTransaction_, decimal _amount_, bool _checked_ |
|`TransactionType`| enum _Withdraw_, enum _Deposit_ |