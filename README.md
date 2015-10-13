# FizzBuzzFun
Taking the FizzBuzz problem to absurdity.

This project is just a fun approach to the classic interview question FizzBuzz.

Here is the problem for those who haven't heard of it: 
You have to cycle through a range of numbers (usually 1 - 100) and for each number output the relevant text to the console.

- If the number is divisible by 3 output Fizz
- If the number is divisible by 5 output Buzz
- If the number is divisible by both 3 and 5 output FizzBuzz

I decided to write a console app that really breaks the problem out a lot more than is necessary.
You will see some patterns in use, like Strategy and NullObject (kind of).  
Test coverage is over 90% but I intentionally omitted some negative tests that could reveal bugs in the logic.
All in all it is just a fun POC that only took a few hours to crank out.

Next steps might be implementing IOC and DI, covering some of the Negative Tests, 
allowing the user to select a number range to be checked or writing some integration tests
to cover logic over the whole pipeline.
