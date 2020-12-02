Let's suppose that you have two big lists with incomings and outgoings from your company.
You want to calculate the budget and you want to do it faster so you decide to do it on two threads, one for each list.
You know that the end result should be 0, however the result is always different.
Where is the problem in the following code?