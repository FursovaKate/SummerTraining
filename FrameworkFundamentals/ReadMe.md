1. Customer class has three public properties - Name (string), ContactPhone (string) and Revenue (decimal). Implement for the Customer's objects the capability of a various string representation. For example, the object with the Name = "Jeffrey Richter", Revenue = 1000000, ContactPhone = "+1 (425) 555-0100" can have the following string representation:
Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100
Customer record: +1 (425) 555-0100
Customer record: Jeffrey Richter, 1,000,000.00
Customer record: Jeffrey Richter
Customer record: 1000000, etc. Add to Customer class an additional formatting capability, that is not provided by the class (Customer class do not change). Develop unit tests.

2. A string is considered to be in title case if each word in the string is either (a) capitalised (that is, only the first letter of the word is in upper case) or (b) considered to be an exception and put entirely into lower case unless it is the first word, which is always capitalised. Write a function that will convert a string into title case, given an optional list of exceptions (minor words). The list of minor words will be given as a string with each word separated by a space. Your function should ignore the case of the minor words string -- it should behave in the same way even if the case of the minor word string is changed.
Arguments:
First argument (required): the original string to be converted.
Second argument (optional): space-delimited list of minor words that must always be lowercase except for the first word in the string.


3. You need to write a function AddOrChangeUrlParameter(url, keyValueParameter) that can manipulate URL parameters. It should be able to add a parameter to an existing URL, but also to change a parameter if it already exists. Example:
AddOrChangeUrlParameter("www.example.com", "key=value") => 'www.example.com?key=value' (adds a parameter).
AddOrChangeUrlParameter("www.example.com?key=value", "key2=value2" ) => 'www.example.com?key=value&key2=value2' (adds another parameter).
AddOrChangeUrlParameter("www.example.com?key=oldValue", "key=newValue" ) => 'www.example.com?key=newValue' (changes the parameter).

4. Implement the function UniqueInOrder which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements. For example (Note that you can return any data structure you want, as long it inherits the IEnumerable interface.)

5. Complete the solution so that it reverses all of the words within the string passed in. Example: ReverseWords("The greatest victory is that which requires no battle") => "battle no requires which that is victory greatest The"

6. Write a function that returns the sum of two big numbers. The input numbers are strings and the function must return a string.